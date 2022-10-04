using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Common.Web_Scrap.Interface
{
    public interface ICarBrandAndModel
    {
        List<string> GetBrands();
        List<string> GetModels();
    }
}
