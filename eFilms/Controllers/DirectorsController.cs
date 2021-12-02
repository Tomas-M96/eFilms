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
    public class DirectorsController : Controller
    {
        //readonly Db context
        private readonly ApplicationDbContext context;

        //Constructor for the controller
        public DirectorsController(ApplicationDbContext _context)
        {
            context = _context;
        }

        //Asynchronous function for the index
        public async Task<IActionResult> Index()
        {
            List<Director> data = await context.Directors.ToListAsync();
            return View();
        }
    }
}
