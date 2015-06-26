using AutoMapper;
using GuiaDaPesca.Domain.Interfaces.Repositories;
using GuiaDaPesca.Domain.Model;
using GuiaDaPesca.Infra.Context;
using GuiaDaPesca.Site.ViewModels;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GuiaDaPesca.Site.Controllers
{
    public class GuiaDaPescaController : Controller
    {
        // GET: GuiaDaPesca
        public ActionResult Index()
        {
            //new Inicializar().IniciarDB();

            return View();
        }

        #region Methods

        public string BuscarLocaisDePesca()
        {
            var a = new LocalDePescaRepository().BuscarPadrao();
            List<LocalDePescaViewModel> locaisDePescaViewModel = Mapper.Map<List<LocalDePescaViewModel>>(a);

            return JsonConvert.SerializeObject(locaisDePescaViewModel);
        }



        #endregion
    }
}