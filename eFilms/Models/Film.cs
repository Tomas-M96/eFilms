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

        [Display(Name = "Film Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Film Cover")]
        public string FilmCoverURL { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Price")]
        public double Price { get; set; }

        [Display(Name = "Genre")]
        public FilmCategory FilmCategory { get; set; }

        //Relationships
        public List<FilmActors> FilmActors { get; set; }

        public List<StoreFilms> StoreFilms { get; set; }

        [ForeignKey("DirectorId")]
        public int DirectorId { get; set; }
        public Director Director { get; set; }

    }
}
