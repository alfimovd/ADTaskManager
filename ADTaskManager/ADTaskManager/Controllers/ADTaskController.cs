using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ADTaskManager.Model;
using ADTaskManager.DB;

namespace ADTaskManager.App_Start
{
    public class ADTaskController : Controller
    {
        private Db db = new Db();

        // GET: /ADTask/
        public ActionResult Index()
        {
            return View(db.ADTasks.ToList());
        }

        // GET: /ADTask/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ADTask adtask = db.ADTasks.Find(id);
            if (adtask == null)
            {
                return HttpNotFound();
            }
            return View(adtask);
        }

        // GET: /ADTask/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /ADTask/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Description,Performers,Status,PlannedLabor,ActualLabor,RegistrationDate,ExecutionDate,ParentId,Title")] ADTask adtask)
        {
            if (ModelState.IsValid)
            {
                db.ADTasks.Add(adtask);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(adtask);
        }

        // GET: /ADTask/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ADTask adtask = db.ADTasks.Find(id);
            if (adtask == null)
            {
                return HttpNotFound();
            }
            return View(adtask);
        }

        // POST: /ADTask/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Description,Performers,Status,PlannedLabor,ActualLabor,RegistrationDate,ExecutionDate,ParentId,Title")] ADTask adtask)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adtask).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(adtask);
        }

        // GET: /ADTask/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ADTask adtask = db.ADTasks.Find(id);
            if (adtask == null)
            {
                return HttpNotFound();
            }
            return View(adtask);
        }

        // POST: /ADTask/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ADTask adtask = db.ADTasks.Find(id);
            db.ADTasks.Remove(adtask);
            db.SaveChanges();
            return RedirectToAction("Index");
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
