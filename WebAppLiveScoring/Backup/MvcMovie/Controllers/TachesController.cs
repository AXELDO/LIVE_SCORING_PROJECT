using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class TachesController : Controller
    {
        private readonly TacheContext _context;

        public TachesController(TacheContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Tache.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Tache tache)
        {
            _context.Add(tache);
            _context.SaveChanges();
            return RedirectToAction("Index", "Taches");
        }


        public IActionResult Edit(int id)
        {
            return View(GetTacheFromId(id));
        }

        [HttpPost]
        public IActionResult Edit(Tache tache)
        {
           _context.Update(tache);
           _context.SaveChanges();
            return RedirectToAction("Index", "Taches");
        }


        public IActionResult Details(int id)
        {
            return View(GetTacheFromId(id));
        }

        public IActionResult Delete(int id)
        {
            return View(GetTacheFromId(id));
        }

        [HttpPost]
        public IActionResult Delete(Tache tache)
        {
            _context.Remove(tache);
            _context.SaveChanges();
            return RedirectToAction("Index", "Taches");
        }


        /// <summary>
        /// Comprende le fonctionnement des methodes asynchrones
        /// Return Tache object from Id field
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private async Task<Tache> GetTacheFromId(int id)
        {
            return await _context.Tache.FindAsync(id);
        }
    }
}