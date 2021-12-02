using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eFilms.Models
{
    public class Director
    {
        //Attributes
        [Key]
        public int DirectorId { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }
        [Display(Name = "Directors Picture")]
        public string ProfilePictureURL { get; set; }

        //Relationships
        public List<Film> Films { get; set; }

    }
}
