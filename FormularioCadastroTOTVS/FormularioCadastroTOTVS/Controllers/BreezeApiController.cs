using Breeze.ContextProvider.EF6;
using Breeze.WebApi2;
using FormularioCadastroTOTVS.DAL;
using FormularioCadastroTOTVS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace FormularioCadastroTOTVS.Controllers
{
    [BreezeController]
    public class BreezeApiController : ApiController
    {
        private readonly EFContextProvider<FormularioContext> _contextProvider = new EFContextProvider<FormularioContext>();

        [HttpGet]
        public IQueryable<Usuario> Usuario()
        {
            return _contextProvider.Context.Usuarios;
        }

        [HttpGet]
        public object Metadata()
        {
            return _contextProvider.Metadata(); 
        }
    }
}