using AutoMapper;
using GuiaDaPesca.Domain.Interfaces.Repositories;
using GuiaDaPesca.Domain.Model;
using GuiaDaPesca.Site.ViewModels;
using Newtonsoft.Json;
using System;
using System.Web;
using System.Web.Mvc;

namespace GuiaDaPesca.Site.Controllers
{
    public class LoginController : Controller
    {
        #region Controllers

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
        public ActionResult Novo(UsuarioViewModel usuarioViewModel)
        {
            Usuario usuario;
            UsuarioRepository usuarioRepository = new UsuarioRepository();
            HttpCookie cookie = new HttpCookie("GuiaDaPescaUsuario");

            if (ModelState.IsValid)
            {
                try
                {
                    usuario = new Usuario(usuarioViewModel.Email,
                        usuarioViewModel.Senha,
                        usuarioViewModel.SenhaConfirmacao);

                    usuarioRepository.Adicionar(usuario);

                    usuarioViewModel = Mapper.Map<Usuario, UsuarioViewModel>(usuario);

                    cookie.Value = JsonConvert.SerializeObject(usuarioViewModel);
                    cookie.Expires = new DateTime(DateTime.Now.Year + 10, 1, 1);

                    Response.Cookies.Add(cookie);

                    return RedirectToAction("Index", "GuiaDaPesca");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, ex);
                }
            }

            return View(usuarioViewModel);
        }

        public ActionResult Logout()
        {
            HttpCookie cookie = new HttpCookie("GuiaDaPescaUsuario");

            cookie.Value = null;
            cookie.Expires = DateTime.Now;

            Response.Cookies.Add(cookie);

            return RedirectToAction("Index", "GuiaDaPesca");
        }

        public ActionResult Login(UsuarioViewModel usuarioViewModel)
        {
            UsuarioRepository usuarioRepository = new UsuarioRepository();
            Usuario usuario = usuarioRepository.Obter(usuarioViewModel.Email);
            HttpCookie cookie = new HttpCookie("GuiaDaPescaUsuario");

            if (usuario == null)
            {
                ViewBag.Mensagem = "Usuario não localizado.";
            }
            else
            {
                if (usuario.Senha == usuarioViewModel.Senha)
                {
                    usuarioViewModel = Mapper.Map<Usuario, UsuarioViewModel>(usuario);

                    cookie.Value = JsonConvert.SerializeObject(usuarioViewModel);
                    cookie.Expires = new DateTime(DateTime.Now.Year + 10, 1, 1);

                    Response.Cookies.Add(cookie);
                }
                else
                {
                    ViewBag.Mensagem = "A senha não pertence a esse usuario";
                }
            }

            return RedirectToAction("Index", "GuiaDaPesca");
        }

        #endregion

        #region Methods

        public Usuario ObterUsuarioLogado()
        {
            Usuario usuario = null;
            var cookie = Request.Cookies["GuiaDaPescaUsuario"];

            if (cookie != null)
            {
                usuario = (Usuario)JsonConvert.DeserializeObject(cookie.Value.ToString());
            }

            return usuario;
        }

        #endregion
    }
}