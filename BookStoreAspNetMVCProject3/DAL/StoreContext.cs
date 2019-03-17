using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ProjektKsiegarniBCity.Models;
namespace ProjektKsiegarniBCity.DAL
{
    public class StoreContext : DbContext
    {
        public StoreContext() : base("StoreContext")
        {

        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Article> Article { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}