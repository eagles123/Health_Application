using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Health_Application.Models
{
    public class Post
    {
        public int Id { get; set; }

        public ApplicationUser User { get; set; }

        [Required]
        public String Title { get; set; }

        public DateTime Time { get; set; }

        public String Body { get; set; }

        public IList<Response> Response { get; set; }
    }
}