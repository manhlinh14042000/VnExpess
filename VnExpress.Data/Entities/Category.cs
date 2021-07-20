using System;
using System.Collections.Generic;
using System.Text;

namespace VnExpress.Data.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
        public string  Description { get; set; }
        public List<Post> Posts { get; set; }

    }
}

