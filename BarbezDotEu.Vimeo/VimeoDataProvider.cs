// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text.Json;
using System.Threading.Tasks;
using BarbezDotEu.Provider;
using BarbezDotEu.VideoHost.DTO;
using BarbezDotEu.VideoHost.EqualityComparers;
using BarbezDotEu.Vimeo.DTO;
using BarbezDotEu.Vimeo.Interfaces;
using Microsoft.Extensions.Logging;

namespace BarbezDotEu.Vimeo
{
    /// <summary>
    /// Implements a data provider that connects to and can call Vimeo.com APIs.
    /// </summary>
    public class VimeoDataProvider : PoliteProvider, IVimeoDataProvider
    {
        private VimeoConfiguration configuration;
        private readonly MediaTypeWithQualityHeaderValue acceptHeader;

        /// <summary>
        /// Gets the <see cref="VimeoConfiguration"/> this <see cref="VimeoConfiguration"/> uses to communicate to the APIs.
        /// </summary>
        private VimeoConfiguration Configuration
        {
            get
            {
                if (this.configuration == null)
                {
                    throw new ApplicationException(
                        $"An {nameof(VimeoDataProvider)} cannot be used before it is configured. To fix, call the {nameof(VimeoDataProvider)}.{nameof(Configure)} method right after initialization.");
                }

                return this.configuration;
            }
        }

        /// <inheritdoc/>
        public void Configure(VimeoConfiguration configuration)
        {
            this.configuration = configuration;
            this.SetRateLimitPerMinute(this.configuration.RateLimitPerMinute);
        }

        /// <summary>
        /// Constructs a new <see cref="VimeoDataProvider"/>.
        /// </summary>
        /// <param name="logger">A <see cref="ILogger"/> to use for logging.</param>
        /// <param name="httpClientFactory">The <see cref="IHttpClientFactory"/> to use.</param>
        public VimeoDataProvider(ILogger logger, IHttpClientFactory httpClientFactory)
            : base(logger, httpClientFactory)
        {
            this.acceptHeader = new MediaTypeWithQualityHeaderValue(MediaTypeNames.Application.Json);
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<VideoHostingUser>> GetUsersLike(params string[] userQueries)
        {
            var result = new HashSet<VideoHostingUser>(new VideoHostingUserComparer());
            if (userQueries != null)
            {
                this.SetMultiplier(userQueries.Length);
                foreach (string userQuery in userQueries)
                {
                    var response = await this.GetVideoHostingUsersLike(userQuery);
                    if (response != null && response.Any())
                    {
                        result.UnionWith(response);
                    }
                }
            }

            return result.AsEnumerable();
        }

        /// <inheritdoc/>
        public async Task<PoliteReponse<GetUsersResponse>> GetUsersLike(string userQuery)
        {
            var query = WebUtility.UrlEncode(userQuery.ToLowerInvariant());
            var queryUrl = $"{this.configuration.GetUsersRootUrl}{query}";
            var request = new HttpRequestMessage(HttpMethod.Get, queryUrl);
            request.Headers.Accept.Add(acceptHeader);
            request.Headers.Authorization = new AuthenticationHeaderValue("bearer", this.configuration.BearerToken);
            try
            {
                var result = await this.Request<GetUsersResponse>(request);
                return result;
            }
            catch (JsonException e)
            {
                base.Logger.LogWarning($"An error occurred that we're going to ignore since occasionally, OtcMarkets sends back XML/HTML responses. Moving on from: {e}");
                return null;
            }
}

        /// <inheritdoc/>
        public async Task<List<VideoHostingUser>> GetVideoHostingUsersLike(string userQuery)
        {
            var result = await GetUsersLike(userQuery);
            return result.Content?.AsVideoHostingUsers();
        }
    }
}
