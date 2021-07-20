using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VnExpress.ViewModel.Posts;

namespace VnExpress.WepApp.Models
{
    public class HomeViewModel
    {
        public List<PostVm> FeaturedPosts { get; set; }
        public List<PostVm> LatestPosts { get; set; }
        public List<PostVm> NewPosts { get; set; }
    }
}
