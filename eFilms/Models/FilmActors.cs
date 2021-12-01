using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eFilms.Models
{
    public class FilmActors
    {
        public int FilmId { get; set; }
        public Film Film { get; set; }

        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
