using CoreProject03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject03.Repository
{
    public interface IRepositoryBand
    {

          List<Band> Bands();

          Band Band(string id);
    }
}
