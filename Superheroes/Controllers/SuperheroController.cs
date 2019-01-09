using Superheroes.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Superheroes.Controllers
{
    public class SuperheroController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Superhero
        public ActionResult Index()
        {
            return View(db.Superheroes.ToList());
        }

        // GET: Superhero/Details/5
        public ActionResult Details(int id)
        {
            Superhero superhero = db.Superheroes.Where(s => s.ID == id).FirstOrDefault();
            return View(superhero);
        }

        // GET: Superhero/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Superhero/Create
        [HttpPost]
        public ActionResult Create(Superhero superhero)
        {
            try
            {
                // TODO: Add insert logic here
                db.Superheroes.Add(superhero);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View("Index");
            }
        }

        // GET: Superhero/Edit/5
        public ActionResult Edit(int id)
        {
            Superhero superhero = db.Superheroes.Where(s => s.ID == id).FirstOrDefault();
            return View(superhero);
        }

        // POST: Superhero/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Superhero superhero)
        {
            try
            {
                // TODO: Add update logic here
                Superhero superheroFromDb = db.Superheroes.Where(s => s.ID == id).FirstOrDefault();
                superheroFromDb.Name = superhero.Name;
                superheroFromDb.alterEgo = superhero.alterEgo;
                superheroFromDb.primaryAbility = superhero.primaryAbility;
                superheroFromDb.secondaryAbility = superhero.secondaryAbility;
                superheroFromDb.catchphrase = superhero.catchphrase;

                db.SaveChanges();
                return RedirectToAction("Details", new { id = superhero.ID });
            }
            catch
            {
                return View();
            }
        }

        // GET: Superhero/Delete/5
        public ActionResult Delete(int id)
        {
            Superhero superhero = db.Superheroes.Where(s => s.ID == id).FirstOrDefault();
            return View(superhero);
        }

        // POST: Superhero/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Superhero superhero)
        {
            try
            {
                // TODO: Add delete logic here
                Superhero superheroFromDb = db.Superheroes.Where(s => s.ID == id).FirstOrDefault();
                db.Superheroes.Remove(superheroFromDb);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
