using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
    class Pan : Genus
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
            this.url = "https://en.wikipedia.org/wiki/Chimpanzee";
            this.trait = "No tail";
            this.commonName = "Chimpanzee";
            this.scientificName = "Pan";
        }

        public Pan()
        {
            this.init();
        }

        public Pan(string continent)
        {
            this.init();
            this.continent = continent;
        }
    }
}
