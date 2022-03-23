// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

namespace BarbezDotEu.Vimeo
{
    /// <summary>
    /// Implements and houses configuration parameters to correctly connect to and communicate with Vimeo.com's services.
    /// </summary>
    public class VimeoConfiguration
    {
        /// <summary>
        /// Constructs a <see cref="VimeoConfiguration"/>.
        /// </summary>
        /// <param name="rateLimitPerMinute">The maximum number of requests per minute.</param>
        /// <param name="bearerToken">A bearer token to be used in the authentication header for requests.</param>
        public VimeoConfiguration(long rateLimitPerMinute, string bearerToken)
        {
            GetUsersRootUrl = "https://api.vimeo.com/users?direction=desc&sort=date&per_page=100&query=";
            RateLimitPerMinute = rateLimitPerMinute;
            BearerToken = bearerToken;
        }

        /// <summary>
        /// Gets the root URL for querying user information (without actual user info).
        /// </summary>
        public string GetUsersRootUrl { get; }

        /// <summary>
        /// Gets the maximum number of requests per minute.
        /// </summary>
        public long RateLimitPerMinute { get; }

        /// <summary>
        /// Gets a bearer token to be used in the authentication header for requests.
        /// </summary>
        public string BearerToken { get; }
    }
}
