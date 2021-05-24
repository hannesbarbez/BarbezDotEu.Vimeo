// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Text.Json.Serialization;

namespace BarbezDotEu.Vimeo.DTO
{
    public class MetaData
    {
        [JsonPropertyName("connections")]
        public Connections Connections { get; set; }

        // Skipping "interactions" property because no interest in interacting in the planned scopes.
    }
}
