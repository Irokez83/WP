using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WishApp.Models;

namespace WishApp.Controllers
{
    public class PreferencesController : Controller
    {
        private WishAppContext db = new WishAppContext();

        // GET: Preferences
        public async Task<ActionResult> Index()
        {
            var preferences = db.Preferences.Include(p => p.User).OrderBy(o => o.User.Email); ;
            return View(await preferences.ToListAsync());
        }

        // GET: Preferences/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Preference preference = await db.Preferences.FindAsync(id);
            if (preference == null)
            {
                return HttpNotFound();
            }
            return View(preference);
        }

        // GET: Preferences/Create
        public ActionResult Create()
        {
            ViewBag.UserId = new SelectList(db.Users, "UserId", "Email");
            return View();
        }

        // POST: Preferences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "PreferenceId,Occasions,UserPreference,Flowers,UserId")] Preference preference)
        {
            if (ModelState.IsValid)
            {
                db.Preferences.Add(preference);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.UserId = new SelectList(db.Users, "UserId", "Email", preference.UserId);
            return View(preference);
        }

        // GET: Preferences/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Preference preference = await db.Preferences.FindAsync(id);
            if (preference == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserId = new SelectList(db.Users, "UserId", "Email", preference.UserId);
            return View(preference);
        }

        // POST: Preferences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "PreferenceId,Occasions,UserPreference,Flowers,UserId")] Preference preference)
        {
            if (ModelState.IsValid)
            {
                db.Entry(preference).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.UserId = new SelectList(db.Users, "UserId", "Email", preference.UserId);
            return View(preference);
        }

        // GET: Preferences/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Preference preference = await db.Preferences.FindAsync(id);
            if (preference == null)
            {
                return HttpNotFound();
            }
            return View(preference);
        }

        // POST: Preferences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Preference preference = await db.Preferences.FindAsync(id);
            db.Preferences.Remove(preference);
            await db.SaveChangesAsync();
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
