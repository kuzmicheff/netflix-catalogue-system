using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    class Title
    {
        public string type;
        public string name;
        public string duration;
        public double? rating;
        public List<string> genre;
        public List<Episode> episode;

        public Title(string type, string name, string duration, double rating, List<string> genre, List<Episode> episode)
        {
            this.type = type;
            this.name = name;
            this.duration = duration;
            this.rating = rating;
            this.genre = genre;
            this.episode = episode;
        }

        public Title()
        {
            type = null;
            name = null;
            duration = null;
            rating = null;
            genre = null;
            episode = null;
        }
    }
}
