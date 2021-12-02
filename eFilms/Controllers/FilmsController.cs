using eFilms.Data;
using eFilms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eFilms.Controllers
{
    public class FilmsController : Controller
    {
        //readonly Db context
        private readonly ApplicationDbContext context;

        //Constructor for the controller
        public FilmsController(ApplicationDbContext _context)
        {
            context = _context;
        }

        //async
        public async Task<IActionResult> Index()
        {
            List<Film> data = await context.Films.Include(n => n.StoreFilms).OrderBy(n => n.Name).ToListAsync();
            return View(data);
        }
    }
}
