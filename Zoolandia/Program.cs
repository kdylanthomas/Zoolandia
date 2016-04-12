using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Animals;

namespace Zoolandia
{
    class Program
    {
        static void Main(string[] args)
        {
            MacaroniPenguin larry = new MacaroniPenguin();
            larry.species = new EudyptesChrysolophus();

            Console.WriteLine("{0} the {1} in the genus {2}. To find out more visit {3}.",
            larry.name,
            larry.species.commonName,
            larry.species.genus.scientificName,
            larry.species.url);

            Console.ReadLine();
        }
    }
}
