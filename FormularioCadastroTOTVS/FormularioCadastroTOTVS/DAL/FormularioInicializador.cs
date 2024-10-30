using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using FormularioCadastroTOTVS.Models;

namespace FormularioCadastroTOTVS.DAL
{
    public class FormularioInicializador : System.Data.Entity.DropCreateDatabaseIfModelChanges<FormularioContext>
    {
        protected override void Seed(FormularioContext context)
        {
            var Usuarios = new List<Usuario>
            {
            new Usuario{Nome="Marlon",Sobrenome="Santos",Email="marlon.santos@totvs.com.br",DataNascimento=DateTime.Parse("2000-05-18")}
            
          
            };
            Usuarios.ForEach(s => context.Usuarios.Add(s));
            context.SaveChanges();          
        }
    }
}