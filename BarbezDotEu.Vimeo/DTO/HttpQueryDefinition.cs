// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using Newtonsoft.Json;

namespace BarbezDotEu.Vimeo.DTO
{
    /// <summary>
    /// Implements a <see cref="HttpQueryDefinition"/> as outlined in the contract defined by Vimeo.
    /// </summary>
    public class HttpQueryDefinition
    {
        /// <summary>
        /// The URI to the HTTP query.
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or sets the total results to expect when executing the HTTP query.
        /// </summary>
        [JsonProperty("total")]
        public long Total { get; set; }

        // Skipping "Options" property as complex and irrelevant to the planned scopes of this project.
    }
}
