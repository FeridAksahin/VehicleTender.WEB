using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Common.Web_Scrap.Interface
{
    public interface IProvinceAndDistrict
    {
        List<string> GetProvinces();
        List<string> GetDistricts(string request);
    }
}
