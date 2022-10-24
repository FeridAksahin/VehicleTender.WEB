using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleTender.API.DTO.AdminDTO.Models.Tender;
using VehicleTender.API.Entity.Context;
 

namespace VehicleTender.API.DataAccessLayer.Concrete
{
    public class TenderDal
    {
        
        public List<GetTenderDTO> GetAllTenderForAdminUI()
        {
            using(SqlConnection conn = new SqlConnection("data source=.;database=VehicleTender;Integrated Security=true;"))
            {
                var procedure = "[sp_GetTender]";
                var results = conn.Query<GetTenderDTO>(procedure, commandType: CommandType.StoredProcedure).ToList();
                return results;
            }
      
        }
    }
}
