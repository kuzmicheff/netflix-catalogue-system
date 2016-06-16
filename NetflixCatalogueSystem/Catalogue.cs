using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    class Catalogue
    {
        public string type;
        public string name;
        public string duration;
        public decimal rating;
        public List<string> genre;
        public List<Episode> episode;
    }
}
