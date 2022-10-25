using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleTender.API.DTO.AdminDTO.Models.Tender;
using VehicleTender.API.DTO.EndUserDTO.VM.Tender;
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
        public List<TenderListVM> GetAllTenderForEndUserUI()
        {
            using (SqlConnection conn = new SqlConnection("data source=.;database=VehicleTender;Integrated Security=true;"))
            {
                var procedure = "[sp_GetTenderForEndUserUI]";
                var results = conn.Query<TenderListVM>(procedure, commandType: CommandType.StoredProcedure).ToList();
                return results;
            }

        }
       
        public async Task<List<DTO.EndUserDTO.VM.Tender.TenderCar>> GetTenderCar(int id)
        {
            using (SqlConnection conn = new SqlConnection("data source=.;database=VehicleTender;Integrated Security=true;"))
            {
                var query = "select CategoryID,CategoryName from Categories where CategorID =@id";
                using (var multiSelect = await conn.QueryMultipleAsync(query, new { id = id }))
                {
                    var cat = await multiSelect.ReadSingleOrDefaultAsync<DTO.EndUserDTO.VM.Tender.TenderCar>();
                  
                        var list = (await multiSelect.ReadAsync<DTO.EndUserDTO.VM.Tender.TenderCar>()).ToList();


                    return list;
                }
            }
         
        }
    }
} 
