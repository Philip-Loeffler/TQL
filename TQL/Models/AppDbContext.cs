using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TQL.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext() : base() { }

        public DbSet<Result> Results { get; set; }
    }
}