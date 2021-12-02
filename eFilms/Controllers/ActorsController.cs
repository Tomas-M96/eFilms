using eFilms.Data;
using eFilms.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eFilms.Controllers
{
    public class ActorsController : Controller
    {
        //readonly Db context
        private readonly ApplicationDbContext context;

        //Constructor for the controller
        public ActorsController(ApplicationDbContext _context)
        {
            context = _context;
        }

        //Function for the index page
        //Synchronous
        public IActionResult Index()
        {
            //Gets a list of the data from the actors table
            List<Actor> data = context.Actors.ToList();
            //Returns the view
            return View(data);
        }
    }
}
