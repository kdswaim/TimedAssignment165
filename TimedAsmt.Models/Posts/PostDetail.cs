using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimedAsmt.Models.Posts
{
    public class PostDetail
    {
        public int Id { get; set; }

        public string Title { get; set; } = String.Empty;
        public string Text { get; set; } = String.Empty;
        
        public DateTimeOffset CreatedUTC { get; set; }
        public DateTimeOffset? ModifiedUTC { get; set; }


        public string AuthorId { get; set; } = null!;
    }
}