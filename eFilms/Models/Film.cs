using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using eFilms.Data.Enums;

namespace eFilms.Models
{
    public class Film
    {
        //Attributes
        [Key]
        public int FilmId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FilmCoverURL { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Price { get; set; }
        public FilmCategory FilmCategory { get; set; }

        //Relationships
        public List<FilmActors> FilmActors { get; set; }

        public List<StoreFilms> StoreFilms { get; set; }

        [ForeignKey("DirectorId")]
        public int DirectorId { get; set; }
        public Director Director { get; set; }

    }
}
