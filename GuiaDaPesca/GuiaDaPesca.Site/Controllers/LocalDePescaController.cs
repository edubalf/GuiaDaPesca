using AutoMapper;
using GuiaDaPesca.Domain.Interfaces.Repositories;
using GuiaDaPesca.Domain.Model;
using GuiaDaPesca.Site.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GuiaDaPesca.Site.Controllers
{
    public class LocalDePescaController : Controller
    {
        public ActionResult Novo()
        {
            List<TipoLocalDePescaViewModel> tiposLocalDePescaViewModel = Mapper.Map<List<TipoLocalDePesca>, List<TipoLocalDePescaViewModel>>(new TipoLocalDePescaRepository().BuscarPadrao());
            List<SelectListItem> itens = new List<SelectListItem>();

            foreach (var item in tiposLocalDePescaViewModel)
            {
                itens.Add(new SelectListItem() { Text = item.Comentario.Descricao, Value = item.Id.ToString() });
            }

            ViewBag.tiposLocalDePescaViewModel = new SelectList(itens, "Text", "Value");

            return View();
        }

        [HttpPost]
        public ActionResult Novo(LocalDePescaViewModel localDePescaViewModel)
        {


            return View();
        }
    }
}