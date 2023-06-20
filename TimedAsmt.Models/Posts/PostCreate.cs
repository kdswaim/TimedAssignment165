using System.ComponentModel.DataAnnotations;

namespace TimedAsmt.Models.Posts
{
    public class PostCreate
    {
        [Required]
        public string Title { get; set; } = String.Empty;

        [Required]
        public string Text { get; set; } = String.Empty;
    }
}