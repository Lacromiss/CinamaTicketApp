using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Film: BaseEntity
    {
        public string MovieName { get; set; }
        public string MovieAge { get; set; }
        public string MovieImg { get; set; }
        public List<FilmLanguage> FilmLanguages { get; set; }

    }
}
