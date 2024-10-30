using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FormularioCadastroTOTVS.DAL;
using FormularioCadastroTOTVS.Models;

namespace FormularioCadastroTOTVS.Controllers
{
    public class HomeController : Controller
    {
        private FormularioContext db = new FormularioContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nome,Sobrenome,Email,DataNascimento,Senha,SenhaConfirmacao")] Usuario usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Usuarios.Add(usuario);
                    db.SaveChanges();
                    TempData["Mensagem"] = "Usuário cadastrado com sucesso!";
                    return RedirectToAction("Create");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(usuario);
        }

        public ActionResult CreateDynamic()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateDynamic([Bind(Include = "ID,Nome,Sobrenome,Email,DataNascimento,Senha,SenhaConfirmacao")] Usuario usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Usuarios.Add(usuario);
                    db.SaveChanges();
                    return Json(new { success = true, message = "Usuário cadastrado com sucesso!" });
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(usuario);
        }

        public JsonResult GetUsers()
        {
            var users = db.Usuarios.ToList();
            return Json(users, JsonRequestBehavior.AllowGet);
        }
    }
}