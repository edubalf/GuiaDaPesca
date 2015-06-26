using AutoMapper;
using GuiaDaPesca.Domain.Interfaces.Repositories;
using GuiaDaPesca.Domain.Model;
using GuiaDaPesca.Site.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuiaDaPesca.Site.Controllers
{
    public class PeixeController : Controller
    {
        // GET: Peixe
        public ActionResult Index()
        {
            List<PeixeViewModel> peixesViewModel;
            List<Peixe> peixes = new PeixeRepository().BuscarPadrao();

            peixesViewModel = Mapper.Map<List<PeixeViewModel>>(peixes);

            return View(peixesViewModel);
        }

        public ActionResult Novo()
        {
            return View();
        }
    }
}