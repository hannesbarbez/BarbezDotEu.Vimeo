// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using BarbezDotEu.VideoHost.DTO;
using Newtonsoft.Json;

namespace BarbezDotEu.Vimeo.DTO
{
    /// <summary>
    /// Implements a website according to the contract as defined by Vimeo.
    /// </summary>
    public class Website
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        public WebsiteData AsWebsiteData()
        {
            return new WebsiteData(this.Uri, this.Name, this.Link, this.Type, this.Description);
        }
    }
}
