using System;
using System.Collections.Generic;
using System.Text;

namespace VnExpress.ViewModel.Categories
{
    public class CategoryUpdateRequest
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
