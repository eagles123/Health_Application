using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Health_Application.Models
{
    public class Response
    {
        public int Id { get; set; }

        [ForeignKey("PostId")]
        public virtual Post Post { get; set; }

        
        public int PostId { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        public DateTime Time { get; set; }

        public String Message { get; set; }
    }
}