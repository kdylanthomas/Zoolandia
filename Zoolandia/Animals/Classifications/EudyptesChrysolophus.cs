using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
    class EudyptesChrysolophus : Species
    {
        public EudyptesChrysolophus()
        {
            this.url = "https://en.wikipedia.org/wiki/Macaroni_penguin";
            this.genus = new Eudyptes();
            this.scientificName = "Eudyptes Chrysolophus";
            this.commonName = "Macaroni Penguin";
        }
    }
}
