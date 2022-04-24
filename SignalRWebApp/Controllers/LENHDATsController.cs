using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SignalRWebApp.Models;
using SignalRWebApp.SqlServerNotifier;

namespace SignalRWebApp.Controllers
{
    public class LENHDATsController : Controller
    {
        private LENHDATcontext db = new LENHDATcontext();

        // GET: LENHDATs
        public async Task<ActionResult> Index()
        {
            return View(await db.LENHDATs.ToListAsync());
        }

        // GET: LENHDATs/Details/5
     /*   public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LENHDAT lENHDAT = await db.LENHDATs.FindAsync(id);
            if (lENHDAT == null)
            {
                return HttpNotFound();
            }
            return View(lENHDAT);
        }
        */
        // GET: LENHDATs/Create
        public ActionResult Create()
        {
          
            //return View(await collection.ToListAsync());
            return View();
        }

        // POST: LENHDATs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "MACP,NGAYDAT,LOAIGD,LOAILENH,SOLUONG,GIADAT,TRANGTHAI")] LENHDAT lENHDAT)
        {
            if (ModelState.IsValid)
            {
                lENHDAT.NGAYDAT = DateTime.Now;
                lENHDAT.LOAILENH = "LO";
                db.LENHDATs.Add(lENHDAT);

                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(lENHDAT);
        }
/*
        // GET: LENHDATs/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LENHDAT lENHDAT = await db.LENHDATs.FindAsync(id);
            if (lENHDAT == null)
            {
                return HttpNotFound();
            }
            return View(lENHDAT);
        }

        // POST: LENHDATs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,MACP,NGAYDAT,LOAIGD,LOAILENH,SOLUONG,GIADAT,TRANGTHAI")] LENHDAT lENHDAT)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lENHDAT).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(lENHDAT);
        }

        // GET: LENHDATs/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LENHDAT lENHDAT = await db.LENHDATs.FindAsync(id);
            if (lENHDAT == null)
            {
                return HttpNotFound();
            }
            return View(lENHDAT);
        }

        // POST: LENHDATs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            LENHDAT lENHDAT = await db.LENHDATs.FindAsync(id);
            db.LENHDATs.Remove(lENHDAT);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        */
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
