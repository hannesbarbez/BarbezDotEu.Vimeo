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
        /// Gets the URL for querying user information.
        /// </summary>
        public string GetUsersUrl { get; }

        /// <summary>
        /// Gets maximum number of requests per minute.
        /// </summary>
        public long RateLimitPerMinute { get; }

        /// <summary>
        /// Gets a bearer token to be used in the authentication header for requests.
        /// </summary>
        public string BearerToken { get; }
    }
}
