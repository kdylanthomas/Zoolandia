using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Animals;
using Zoolandia.Habitats;

namespace Zoolandia
{
    class Program
    {
        static void Main(string[] args)
        {
            Arctic arcticHabitat = new Arctic();
            Rainforest rainforestHabitat = new Rainforest();

            arcticHabitat.inhabitants = new List<Animal>();

            Penguin larry = new Penguin();
            larry.species = new EudyptesChrysolophus();
            larry.name = "Larry";

            Penguin betty = new Penguin();
            betty.species = new EudyptesChrysolophus();
            betty.name = "Betty";

            arcticHabitat.inhabitants.Add(larry);
            arcticHabitat.inhabitants.Add(betty);

            foreach (Animal a in arcticHabitat.inhabitants)
            {
                Console.WriteLine(a.name);
                Console.WriteLine("{0} the {1} in the genus {2}. To find out more visit {3}.",
                a.name,
                a.species.commonName,
                a.species.genus.scientificName,
                a.species.url);
             
               
            }

            Console.ReadLine();

        }
    }
}
