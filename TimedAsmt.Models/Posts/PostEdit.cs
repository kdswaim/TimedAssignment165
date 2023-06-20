using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimedAsmt.Models.Posts
{
    public class PostEdit
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; } = String.Empty;

        [Required]
        public string Text { get; set; } = String.Empty;
    }
}