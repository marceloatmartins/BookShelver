using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BookShelver.DataAccess;
using BookShelver.Models;

namespace BookShelver.Controllers
{
    public class LivrosController : Controller
    {
        private LivroContext db = new LivroContext();

        // GET: Livros
        public ActionResult Index()
        {
            
            return View();
        }

        public PartialViewResult Listar(Livro livro, int pagina=1, int registros=5)
        {
            var livros = db.Livros.Include(l => l.Genero);

            // montagem do filtro aqui
            if (!String.IsNullOrWhiteSpace(livro.Title))
            {
                livros = livros.Where(l => l.Title.Contains(livro.Title));
            }

            if (!String.IsNullOrWhiteSpace(livro.Author))
            {
                livros = livros.Where(l => l.Author.Contains(livro.Author));
            }

            if (livro.YearEdition != 0)
            {
                livros = livros.Where(l => l.YearEdition == livro.YearEdition);
            }

            if (livro.Value != decimal.Zero)
            {
                livros = livros.Where(l => l.Value == livro.Value);
            }

            var livrosPaginados = livros.OrderBy(l => l.Title).Skip((pagina-1)*registros).Take(registros);

            return PartialView("_Listar", livrosPaginados.ToList()); // tem que passar o nome da view como parametro, neste caso "_Listar"
        }

        // GET: Livros/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Livro livro = db.Livros.Find(id);
            if (livro == null)
            {
                return HttpNotFound();
            }
            return View(livro);
        }

        // GET: Livros/Create
        public ActionResult Create()
        {
            ViewBag.GeneroId = new SelectList(db.Generos, "Id", "Name");
            return View();
        }

        // POST: Livros/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,YearEdition,Value,Author,GeneroId")] Livro livro)
        {
            if (ModelState.IsValid)
            {
                db.Livros.Add(livro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GeneroId = new SelectList(db.Generos, "Id", "Name", livro.GeneroId);
            return View(livro);
        }

        // GET: Livros/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Livro livro = db.Livros.Find(id);
            if (livro == null)
            {
                return HttpNotFound();
            }
            ViewBag.GeneroId = new SelectList(db.Generos, "Id", "Name", livro.GeneroId);
            return View(livro);
        }

        // POST: Livros/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,YearEdition,Value,Author,GeneroId")] Livro livro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(livro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GeneroId = new SelectList(db.Generos, "Id", "Name", livro.GeneroId);
            return View(livro);
        }

        // GET: Livros/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Livro livro = db.Livros.Find(id);
            if (livro == null)
            {
                return HttpNotFound();
            }
            return View(livro);
        }

        // POST: Livros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Livro livro = db.Livros.Find(id);
            db.Livros.Remove(livro);
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
