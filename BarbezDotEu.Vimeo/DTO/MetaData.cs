// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Text.Json.Serialization;

namespace BarbezDotEu.Vimeo.DTO
{
    /// <summary>
    /// Implements a metadata object according to the interface defined by Vimeo.
    /// </summary>
    public class MetaData
    {
        /// <summary>
        /// Gets or sets the connections.
        /// </summary>
        [JsonPropertyName("connections")]
        public Connections Connections { get; set; }

        // Skipping "interactions" property for now.
    }
}
