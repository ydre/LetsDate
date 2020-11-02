﻿using API.DTO;
using API.Entities;
using API.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(int sourceUserId, int likedUserId);
        Task<User> GetUserWithLikes(int userId);
        Task<PagedList<LikeDto>> GetUserLikes(LikesParams likesParams);

        
    }
}
