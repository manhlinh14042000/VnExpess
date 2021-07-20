using System;
using System.Collections.Generic;
using System.Text;

namespace VnExpress.ViewModel.Posts
{
    public class PostVm
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime DateCreated { get; set; }
        public string ShortContent { get; set; }
        public string MainContent { get; set; }
        public string Images { get; set; }
        public int CategoryId { get; set; }
        public List<string> Categories { get; set; } = new List<string>();

    }
}
