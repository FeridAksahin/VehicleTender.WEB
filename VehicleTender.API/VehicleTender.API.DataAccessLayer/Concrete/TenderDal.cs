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
            var value = $"select c.Id as CarId,c.Brand,c.Model,u.[Name],c.CreatedDate from Car c  join CarDetailInfo cd on cd.CarId=c.Id  join [User] u on u.Id=cd.UserId  join TenderVehicleDetail tvd on cd.Id=tvd.CarDetailInfoId  join TenderVehicleSales tvs on tvd.TenderVehicleSalesId = tvs.Id  where tvs.Id={id}";

            using (SqlConnection db = new SqlConnection("data source=.;database=VehicleTender;Integrated Security=true;"))
            {
                var result = await db.QueryAsync<DTO.EndUserDTO.VM.Tender.TenderCar>(value);
                return result.ToList();
            }
        }

    
    }
} 
