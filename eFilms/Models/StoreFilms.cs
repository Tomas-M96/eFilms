using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eFilms.Models
{
    public class StoreFilms
    {
        public int StoreId { get; set; }
        public Store Store { get; set; }

        public int FilmId { get; set; }
        public Film Film { get; set; }
    }
}
