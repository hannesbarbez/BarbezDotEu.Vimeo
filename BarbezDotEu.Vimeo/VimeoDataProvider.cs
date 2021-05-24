// Copyright (c) Hannes Barbez. All rights reserved.
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
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BarbezDotEu.Vimeo
{
    public class VimeoDataProvider : PoliteProvider, IVimeoDataProvider
    {
        private readonly string getUsersRootUrl;
        private readonly AuthenticationHeaderValue authorizationHeader;
        private readonly MediaTypeWithQualityHeaderValue acceptHeader;

        public VimeoDataProvider(ILogger<IHostedService> logger, IConfiguration configuration, IHttpClientFactory httpClientFactory)
            : base(logger, httpClientFactory)
        {
            this.getUsersRootUrl = configuration["Vimeo:GetUsersUrl"];
            this.SetRateLimitPerMinute(configuration["Vimeo:RateLimit:PerMinute"]);
            this.authorizationHeader = new AuthenticationHeaderValue("bearer", configuration["Vimeo:Token"]);
            this.acceptHeader = new MediaTypeWithQualityHeaderValue(MediaTypeNames.Application.Json);
        }

        public async Task<IEnumerable<VideoHostingUser>> GetUsersLike(params string[] userQueries)
        {
            var result = new HashSet<VideoHostingUser>(new VideoHostingUserComparer());
            if (userQueries != null)
            {
                this.SetMultiplier(userQueries.Length);
                foreach (string userQuery in userQueries)
                {
                    var response = await this.GetUsersLike(userQuery);
                    if (response != null && response.Any())
                    {
                        result.UnionWith(response);
                    }
                }
            }

            return result.AsEnumerable();
        }

        private async Task<List<VideoHostingUser>> GetUsersLike(string userQuery)
        {
            var query = WebUtility.UrlEncode(userQuery.ToLowerInvariant());
            var queryUrl = $"{this.getUsersRootUrl}{query}";
            var request = new HttpRequestMessage(HttpMethod.Get, queryUrl);
            request.Headers.Accept.Add(acceptHeader);
            request.Headers.Authorization = this.authorizationHeader;
            var result = await this.Request<GetUsersResponse>(request);
            return result?.AsVideoHostingUsers();
        }
    }
}
