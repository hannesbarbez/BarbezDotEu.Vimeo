// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Text.Json.Serialization;

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
        [JsonPropertyName("next")]
        public string Next { get; set; }

        /// <summary>
        /// Relative URL pointing to the previous page.
        /// </summary>
        [JsonPropertyName("previous")]
        public string Previous { get; set; }

        /// <summary>
        /// Relative URL pointing to the first page.
        /// </summary>
        [JsonPropertyName("first")]
        public string First { get; set; }

        /// <summary>
        /// Relative URL pointing to the last page.
        /// </summary>
        [JsonPropertyName("last")]
        public string Last { get; set; }
    }
}
