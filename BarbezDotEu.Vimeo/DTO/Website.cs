// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Text.Json.Serialization;
using BarbezDotEu.VideoHost.DTO;

namespace BarbezDotEu.Vimeo.DTO
{
    /// <summary>
    /// Implements a website according to the contract as defined by Vimeo.
    /// </summary>
    public class Website
    {
        [JsonPropertyName("uri")]
        public string Uri { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        public WebsiteData AsWebsiteData()
        {
            return new WebsiteData(this.Uri, this.Name, this.Link, this.Type, this.Description);
        }
    }
}
