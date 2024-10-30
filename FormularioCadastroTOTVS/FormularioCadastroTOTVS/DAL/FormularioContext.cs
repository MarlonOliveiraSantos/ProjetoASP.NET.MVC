using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FormularioCadastroTOTVS.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FormularioCadastroTOTVS.DAL
{
    public class FormularioContext : DbContext
    {

        public FormularioContext() :base("FormularioContext")
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        //Para não deixar a tabela no plural dentro do banco de dados
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}