using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    class Catalogue : Title
    {
        public string type;
        public string name;
        public string duration;
        public double? rating;
        public List<string> genre;
        public List<Episode> episode;
    }
}
