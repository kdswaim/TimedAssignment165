using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimedAsmt.Models.Comments
{
    public class CommentCreate
    {        
       public string Text { get; set; } = string.Empty; 
       
       public Guid AuthorId { get; set; }
                     
       public int PostId { get; set; }
    }
}