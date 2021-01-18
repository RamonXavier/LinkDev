using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using LinkDevRamon.Models;

namespace LinkDevRamon.DAO
{
    public class LinkDevContext : DbContext
    {
        public LinkDevContext() : base("LinkDevContext")
        {
        }

        public DbSet<UsuarioTalento> UsuarioTalentos { get; set; }
        public DbSet<CategoriaTalento> CategoriaTalentos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}