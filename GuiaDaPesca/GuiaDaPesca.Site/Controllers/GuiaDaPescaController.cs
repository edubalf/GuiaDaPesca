using GuiaDaPesca.Infra.Context;
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
    }
}