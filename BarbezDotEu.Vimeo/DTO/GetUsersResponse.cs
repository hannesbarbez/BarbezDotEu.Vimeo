﻿// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using BarbezDotEu.VideoHost.DTO;

namespace BarbezDotEu.Vimeo.DTO
{
    /// <summary>
    /// Implements the query response contract as defined by Vimeo after querying for users.
    /// </summary>
    public class GetUsersResponse
    {
        /// <summary>
        /// Gets or sets the resulting set of <see cref="User"/>s.
        /// </summary>
        [JsonPropertyName("data")]
        public User[] Users { get; set; } = Array.Empty<User>();

        /// <summary>
        /// Gets or sets the total number of results.
        /// </summary>
        [JsonPropertyName("total")]
        public long Total { get; set; }

        /// <summary>
        /// Gets or sets the current page of results.
        /// </summary>
        [JsonPropertyName("page")]
        public long Page { get; set; }

        /// <summary>
        /// Gets or sets the number of results per page.
        /// </summary>
        [JsonPropertyName("per_page")]
        public long PerPage { get; set; }

        /// <summary>
        /// Gets or sets the paging information.
        /// </summary>
        [JsonPropertyName("paging")]
        public Paging Paging { get; set; }

        /// <summary>
        /// Returns this <see cref="GetUsersResponse"/> as collection of <see cref="VideoHostingUser"/>s.
        /// </summary>
        /// <returns>This <see cref="GetUsersResponse"/> as collection of <see cref="VideoHostingUser"/>s.</returns>
        public List<VideoHostingUser> AsVideoHostingUsers()
        {
            var results = new List<VideoHostingUser>();
            foreach (var user in Users)
            {
                var location = user.LocationDetails;
                var connections = user.MetaData?.Connections;
                var flatUser = new VideoHostingUser(
                    user.Bio,
                    user.CreatedTime,
                    user.Gender,
                    user.Link,
                    user.Location,
                    user.Name,
                    user.ShortBio,
                    user.Uri,
                    location.City,
                    location.Country,
                    location.CountryIsoCode,
                    location.FormattedAddress,
                    location.Latitude,
                    location.Longitude,
                    location.Neighborhood,
                    location.State,
                    location.StateIsoCode,
                    location.SubLocality,
                    totalVideos: connections?.Videos?.Total,
                    uriVideos: connections?.Videos?.Uri,
                    totalAlbums: connections?.Albums?.Total,
                    uriAlbums: connections?.Albums?.Uri,
                    totalAppearances: connections?.Appearances?.Total,
                    uriAppearances: connections?.Appearances?.Uri,
                    totalChannels: connections?.Channels?.Total,
                    uriChannels: connections?.Channels?.Uri,
                    totalFeed: connections?.Feed?.Total,
                    uriFeed: connections?.Feed?.Uri,
                    totalFoldersRoot: connections?.FoldersRoot?.Total,
                    uriFoldersRoot: connections?.FoldersRoot?.Uri,
                    totalFollowers: connections?.Followers?.Total,
                    uriFollowers: connections?.Followers?.Uri,
                    totalFollowing: connections?.Following?.Total,
                    uriFollowing: connections?.Following?.Uri,
                    totalGroups: connections?.Groups?.Total,
                    uriGroups: connections?.Groups?.Uri,
                    totalLikes: connections?.Likes?.Total,
                    uriLikes: connections?.Likes?.Uri,
                    totalMembership: connections?.Membership?.Total,
                    uriMembership: connections?.Membership?.Uri,
                    totalModeratedChannels: connections?.ModeratedChannels?.Total,
                    uriModeratedChannels: connections?.ModeratedChannels?.Uri,
                    totalPictures: connections?.Pictures?.Total,
                    uriPictures: connections?.Pictures?.Uri,
                    totalPortfolios: connections?.Portfolios?.Total,
                    uriPortfolios: connections?.Portfolios?.Uri,
                    totalSharedVideos: connections?.Shared?.Total,
                    uriSharedVideos: connections?.Shared?.Uri,
                    totalTeams: connections?.Teams?.Total,
                    uriTeams: connections?.Teams?.Uri,
                    user.Websites.Select(x => x.AsWebsiteData()));

                results.Add(flatUser);
            }

            return results;
        }
    }
}
