using CoreProject03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject03.Repository
{
    public class RepositoryBand : IRepositoryBand
    {

        public List<Band> listMusic = new List<Band>()
        {
            new Band{Title= "Dope Music volume 1", Origin="Linha de cintra",Biography="de africa para europa",Gender="Rap"},
            new Band{Title= "Nkatanga", Origin="Moçambique",Biography="string string sting ",Gender="Jazz"},
            new Band{Title= "The moon", Origin="String string",Biography="bla bla bla",Gender="R&B"}
        };

        public Band Band(string id)
        {
            return listMusic.First(X=>X.Title ==id);
        }

        public List<Band> Bands()
        {
            return listMusic;
        }
    }
}
