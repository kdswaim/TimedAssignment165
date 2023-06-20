using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimedAsmt.Data
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = String.Empty;
        public DateTimeOffset CreatedUTC { get; set; }
        public DateTimeOffset? ModifiedUTC { get; set; }

        [Required]
        public string Text { get; set; } = String.Empty;

        public string AuthorId { get; set; } = null!;

        [ForeignKey(nameof(comment.AuthorId))]
        public virtual List<comment> commentList { get; set; } = null!;

        [ForeignKey(nameof(Hate.OwnerId))]
        public virtual List<Hate> HateList { get; set; } = null!;
    }
}