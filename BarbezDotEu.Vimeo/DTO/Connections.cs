// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using Newtonsoft.Json;

namespace BarbezDotEu.Vimeo.DTO
{
    /// <summary>
    /// Implements connections according to the contract defined by Vimeo.
    /// </summary>
    public class Connections
    {
        [JsonProperty("albums")]
        public HttpQueryDefinition Albums { get; set; }

        [JsonProperty("appearances")]
        public HttpQueryDefinition Appearances { get; set; }

        [JsonProperty("channels")]
        public HttpQueryDefinition Channels { get; set; }

        [JsonProperty("feed")]
        public HttpQueryDefinition Feed { get; set; }

        [JsonProperty("followers")]
        public HttpQueryDefinition Followers { get; set; }

        [JsonProperty("following")]
        public HttpQueryDefinition Following { get; set; }

        [JsonProperty("groups")]
        public HttpQueryDefinition Groups { get; set; }

        [JsonProperty("likes")]
        public HttpQueryDefinition Likes { get; set; }

        [JsonProperty("membership")]
        public HttpQueryDefinition Membership { get; set; }

        [JsonProperty("moderated_channels")]
        public HttpQueryDefinition ModeratedChannels { get; set; }

        [JsonProperty("portfolios")]
        public HttpQueryDefinition Portfolios { get; set; }

        [JsonProperty("videos")]
        public HttpQueryDefinition Videos { get; set; }

        [JsonProperty("shared")]
        public HttpQueryDefinition Shared { get; set; }

        [JsonProperty("pictures")]
        public HttpQueryDefinition Pictures { get; set; }

        [JsonProperty("folders_root")]
        public HttpQueryDefinition FoldersRoot { get; set; }

        [JsonProperty("teams")]
        public HttpQueryDefinition Teams { get; set; }

    }
}
