// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using Newtonsoft.Json;

namespace BarbezDotEu.Vimeo.DTO
{
    /// <summary>
    /// Implements the Vimeo paging object according to the contract defined by Vimeo.
    /// </summary>
    public class Paging
    {
        /// <summary>
        /// Relative URL pointing to the next page.
        /// </summary>
        [JsonProperty("next")]
        public string Next { get; set; }

        /// <summary>
        /// Relative URL pointing to the previous page.
        /// </summary>
        [JsonProperty("previous")]
        public string Previous { get; set; }

        /// <summary>
        /// Relative URL pointing to the first page.
        /// </summary>
        [JsonProperty("first")]
        public string First { get; set; }

        /// <summary>
        /// Relative URL pointing to the last page.
        /// </summary>
        [JsonProperty("last")]
        public string Last { get; set; }
    }
}
