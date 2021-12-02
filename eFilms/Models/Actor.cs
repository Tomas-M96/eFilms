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
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }
        [Display(Name = "Actors Picture")]
        public string ProfilePictureURL { get; set; }

        //Relationships
        public List<FilmActors> FilmActors { get; set; }
    }
}
