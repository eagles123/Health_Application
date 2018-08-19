using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Health_Application.Models
{

    public class MyUserInfo
    {
       
        public int Id { get; set; }

        public ApplicationUser User { get; set; }

        public String UserName { get; set; }

        public IList<UserData> UserDatas { get; set; }

        public IList<Post> Posts { get; set; }


    }

}