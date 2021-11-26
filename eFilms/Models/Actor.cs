using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eFilms.Models
{
    public class Actor
    {
        //Attributes
        [Key]
        public int ActorId { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        public string ProfilePictureURL { get; set; }

        //Relationships
        public List<FilmActors> FilmActors { get; set; }
    }
}
