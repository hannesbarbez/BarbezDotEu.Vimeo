// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Collections.Generic;
using System.Threading.Tasks;
using BarbezDotEu.Provider;
using BarbezDotEu.Provider.Interfaces;
using BarbezDotEu.VideoHost.DTO;
using BarbezDotEu.Vimeo.DTO;

namespace BarbezDotEu.Vimeo.Interfaces
{
    /// <summary>
    /// Defines a blueprint for a data provider that connects to and can call Vimeo.com APIs.
    /// </summary>
    public interface IVimeoDataProvider : IPoliteProvider
    {
        /// <summary>
        /// Configures this <see cref="IVimeoDataProvider"/> so that it can successfully communicate with the Vimeo.com APIs.
        /// </summary>
        /// <param name="configuration">The <see cref="VimeoConfiguration"/> to configure this <see cref="IVimeoDataProvider"/> with.</param>
        /// <remarks>
        /// Configuration is required before any APIs can be called.
        /// </remarks>
        void Configure(VimeoConfiguration configuration);

        /// <summary>
        /// Queries for occurences of users on the video hosting platform likely to correspond to the given list of usernames.
        /// </summary>
        /// <param name="usernames">The users for whom to return likely accounts for.</param>
        /// <returns>A plausible list of video hosting platform users corresponding to the give list of usernames.</returns>
        Task<IEnumerable<VideoHostingUser>> GetUsersLike(params string[] usernames);

        /// <summary>
        /// Queries for occurences of users on the video hosting platform likely to correspond to a given username.
        /// </summary>
        /// <param name="username">The user for whom to return likely accounts for.</param>
        /// <returns>A plausible list of video hosting platform users corresponding to a given username.</returns>
        Task<PoliteReponse<GetUsersResponse>> GetUsersLike(string username);

        /// <summary>
        /// Queries for occurences of users on the video hosting platform likely to correspond to a given username.
        /// </summary>
        /// <param name="username">The user for whom to return likely accounts for.</param>
        /// <returns>A plausible list of video hosting platform users corresponding to a given username.</returns>
        Task<List<VideoHostingUser>> GetVideoHostingUsersLike(string username);
    }
}
