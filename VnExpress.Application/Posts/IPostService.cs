using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VnExpress.ViewModel.Posts;

namespace VnExpress.Application.Posts
{
    public interface IPostService
    {
        Task<List<PostVm>> GetAll();
        Task<PostVm> GetById(int postId);
        Task<int> Create(PostCreateRequest request);
        Task<int> Delete(int postId);
        Task<int> Update(PostUpdateRequest request);
        Task<List<PostVm>> GetFeaturedPosts();
        Task<List<PostVm>> GetLatestPosts();
        Task<List<PostVm>> GetNewPosts();



    }
}
