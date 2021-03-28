// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using BarbezDotEu.Provider.Interfaces;
using BarbezDotEu.VideoHost.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BarbezDotEu.Vimeo.Interfaces
{
    public interface IVimeoDataProvider : IPoliteProvider
    {
        Task<IEnumerable<VideoHostingUser>> GetUsersLike(params string[] userQueries);
    }
}
