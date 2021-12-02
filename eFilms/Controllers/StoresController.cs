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
    public class StoresController : Controller
    {
        //readonly Db context
        private readonly ApplicationDbContext context;

        //Constructor for the controller
        public StoresController(ApplicationDbContext _context)
        {
            context = _context;
        }

        //async
        public async Task<IActionResult> Index()
        {
            List<Store> data = await context.Stores.ToListAsync();
            return View(data);
        }
    }
}
