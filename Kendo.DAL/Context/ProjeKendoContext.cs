using Kendo.DAL.Model;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Kendo.DAL.Context
{
    public partial class ProjeKendoContext : DbContext
    {
        public ProjeKendoContext()
            : base("name=ProjeKendoContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<User> Users{ get; set; }

    }
}
