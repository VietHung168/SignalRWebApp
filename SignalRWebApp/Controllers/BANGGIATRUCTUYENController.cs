using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using SignalRWebApp.Models;
using SignalRWebApp.SqlServerNotifier;

namespace SignalRWebApp.Controllers
{
    public class BANGGIATRUCTUYENController : Controller
    {
        private BANGGIATRUCTUYENcontext db = new BANGGIATRUCTUYENcontext();

        public async Task<ActionResult> Index()
        {
            var collection = db.BANGGIATRUCTUYENs;
            ViewBag.NotifierEntity = db.GetNotifierEntity<BANGGIATRUCTUYEN>(collection).ToJson();
            return View(await collection.ToListAsync());
        }

        public async Task<ActionResult> IndexPartial()
        {
            var collection = db.BANGGIATRUCTUYENs;
            ViewBag.NotifierEntity = db.GetNotifierEntity<BANGGIATRUCTUYEN>(collection).ToJson();
            return PartialView(await collection.ToListAsync());
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
