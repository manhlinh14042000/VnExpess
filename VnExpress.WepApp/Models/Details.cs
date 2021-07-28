using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VnExpress.ViewModel.Categories;
using VnExpress.ViewModel.Posts;

namespace VnExpress.WepApp.Models
{
    public class Details
    {
        public CategoryVm Category { get; set; }
        public PostVm Post { get; set; }
    }
}
