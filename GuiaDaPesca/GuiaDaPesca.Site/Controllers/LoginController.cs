using AutoMapper;
using GuiaDaPesca.Domain.Model;
using GuiaDaPesca.Site.ViewModels;
using System.Web.Mvc;

namespace GuiaDaPesca.Site.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Salvar(UsuarioViewModel usuarioViewModel)
        {
            

            return RedirectToAction("Index", "GuiaDaPesca");
        }
    }
}