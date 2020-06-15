using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.WebAPI.Services
{
    public interface IRecommender
    {
        List<Model.Models.Artikli> GetSlicneArtikle(int artikalID);
    }
}
