using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Health_Application.Models
{
    public class Response
    {
        public int Id { get; set; }

        public Post Post { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        public String Message { get; set; }
    }
}