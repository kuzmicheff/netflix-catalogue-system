using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    class Movie : Title
    {
        public override string ToString()
        {
            string movie = String.Format("{0}: {1}", name, duration);
            return movie;
        }
    }
}
