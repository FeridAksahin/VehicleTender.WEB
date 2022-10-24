using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleTender.API.Common.CustomHTTPResponse;
using VehicleTender.API.DTO.AdminDTO.Models.Admin;

namespace VehicleTender.API.DataAccessLayer.Concrete
{
    public class UserDal
    {
        StatusGenerator statusGenerator = new StatusGenerator();    
        public List<GetAdminDTO> GetAllAdmin()
        {
            List<GetAdminDTO> g = new List<GetAdminDTO>();
            return g;
        }
        public string AddAdmin(AddAdminDTO newAdmin)
        {
            return statusGenerator.GetHttpStatusCodes(200); 
        }
    }
}
