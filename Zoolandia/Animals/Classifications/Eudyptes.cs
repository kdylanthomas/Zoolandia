using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
    class Eudyptes : Genus
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
            this.url = "https://en.wikipedia.org/wiki/Crested_penguin";
            this.trait = "Yellow crest";
            this.commonName = "Crested Penguin";
            this.scientificName = "Eudyptes";
        }

        public Eudyptes()
        {
            this.init();
        }

        public Eudyptes(string continent)
        {
            this.init();
            this.continent = continent;
        }
    }
}
