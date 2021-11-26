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
        public string FullName { get; set; }
        public string Bio { get; set; }
        public string ProfilePictureURL { get; set; }

        //Relationships
        public List<Film> Films { get; set; }

    }
}
