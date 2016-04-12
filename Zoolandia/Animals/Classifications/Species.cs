using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
    class Species : TaxonomyTerm
    {
        private Genus _genus; // define _genus as being the type Genus defined in Genus.cs

        public Genus genus
        {
            get
            {
                return _genus;
            }
            set
            {
                _genus = value;
            }
        }
    }
}
