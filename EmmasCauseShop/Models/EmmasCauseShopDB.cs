﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmmasCauseShop.Models
{
    public class EmmasCauseShopDB : IdentityDbContext<User>
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public EmmasCauseShopDB() : base("name=EmmasCauseShopDB")
        {


        }

        public System.Data.Entity.DbSet<EmmasCauseShop.Models.Cause> Causes { get; set; }

        public System.Data.Entity.DbSet<EmmasCauseShop.Models.Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //....
        }















    }
}