using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia
{
    class Zoo 
    {
        public string name = "Dylan's Zoo";

        // the zoo contains habitats; it does not contain animals, 
        // because animals are contained in habitats
        public List<Habitat> habitats = new List<Habitat>();
        
        // zoo also needs to contain other buildings, employees, etc. -- in lists
    }
}
