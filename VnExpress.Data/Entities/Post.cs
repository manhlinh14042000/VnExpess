using System;
using System.Collections.Generic;
using System.Text;

namespace VnExpress.Data.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortContent { get; set; }
        public string MainContent { get; set; }
        public string Author { get; set; }
        public DateTime DateCreated { get; set; }
        public string Images { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
