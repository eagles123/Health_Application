﻿
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Health_Application.Models
{
    public class DbContextFactory
    {
        public static ApplicationDbContext GetCurrentDbContext()
        {
            //initialise a shared context, can new other context make program more scaleble
            
            return new ApplicationDbContext();
        }
    }
}