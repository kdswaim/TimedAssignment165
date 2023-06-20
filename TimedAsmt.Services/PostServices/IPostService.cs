using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimedAsmt.Services.PostServices
{
    public class IPostService
    {
        Task<bool> CreatePost(PostCreate model);
        Task<bool> UpdatePost(PostEdit model);
        Task<bool> DeletePost(int id);
        Task<PostDetail> GetPost(int id);
        Task<List<PostListItem>> GetPosts();
    }
}