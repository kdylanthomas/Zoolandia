using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
    class PanPaniscus : Species
    {
        public PanPaniscus()
        {
            this.url = "https://en.wikipedia.org/wiki/Bonobo";
            this.genus = new Pan();
            this.scientificName = "Pan Paniscus";
            this.commonName = "Bonobo";
        }
    }
}
