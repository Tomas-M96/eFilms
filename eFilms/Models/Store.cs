using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eFilms.Models
{
    public class Store
    {
        //Attributes
        [Key]
        public int StoreId { get; set; }

        [Display(Name = "Store Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
        public string StoreLogoURL { get; set; }

        //Relationships
        public List<StoreFilms> StoreFilms { get; set; }

    }
}
