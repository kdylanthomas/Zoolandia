using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
    class Lontra : Genus
    {
        private string _continent;

        public string continent
        {
            get
            {
                return _continent;
            }
            set
            {
                if (value != "")
                {
                    _continent = value;
                }
            }
        }

        private void init()
        {
            this.url = "https://en.wikipedia.org/wiki/Lontra";
            this.trait = "Powerful webbed feet";
            this.commonName = "Otter";
            this.scientificName = "Lontra";
        }

        public Lontra()
        {
            this.init();
        }

        public Lontra(string continent)
        {
            this.init();
            this.continent = continent;
        }
    }
}
