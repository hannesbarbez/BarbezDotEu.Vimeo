﻿// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
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
        private readonly VimeoConfiguration configuration;
        private readonly MediaTypeWithQualityHeaderValue acceptHeader;

        /// <summary>
        /// Constructs a new <see cref="VimeoDataProvider"/>.
        /// </summary>
        /// <param name="logger">A <see cref="ILogger"/> to use for logging.</param>
        /// <param name="httpClientFactory">The <see cref="IHttpClientFactory"/> to use.</param>
        /// <param name="configuration">The <see cref="VimeoConfiguration"/> to configure this <see cref="IVimeoDataProvider"/> with.</param>
        public VimeoDataProvider(ILogger logger, IHttpClientFactory httpClientFactory, VimeoConfiguration configuration)
            : base(logger, httpClientFactory)
        {
            this.acceptHeader = new MediaTypeWithQualityHeaderValue(MediaTypeNames.Application.Json);
            this.configuration = configuration;
            this.SetRateLimitPerMinute(this.configuration.RateLimitPerMinute);
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
            return await this.Request<GetUsersResponse>(request);
        }

        /// <inheritdoc/>
        public async Task<List<VideoHostingUser>> GetVideoHostingUsersLike(string userQuery)
        {
            var result = await GetUsersLike(userQuery);
            return result.Content?.AsVideoHostingUsers();
        }
    }
}
