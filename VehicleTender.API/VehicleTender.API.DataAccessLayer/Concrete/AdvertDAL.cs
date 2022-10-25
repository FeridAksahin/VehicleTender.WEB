using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleTender.API.DataAccessLayer.Interface;
using VehicleTender.API.DTO.EndUserDTO.VM.Advert;
using VehicleTender.API.Entity.Context;

namespace VehicleTender.API.DataAccessLayer.Concrete
{
    public class AdvertDAL : IAdvertDAL
    {
        private readonly VehicleTenderContext _context;

        public AdvertDAL(VehicleTenderContext context)
        {
            _context = context;
        }
        public async Task<List<CarListVM>> GetAllCarAdverts()
        {
            var value = "select ai.KM,c.Brand,c.Model,c.Year,cf.CarFeatureName from AdvertInfo ai JOIN CarDetailInfo cdi on ai.CarDetailInfoId=cdi.Id JOIN Car c on c.Id=cdi.Id JOIN CarFeatureValue cfv on cfv.CarId=c.Id JOIN CarFeature cf ON cfv.CarFeatureId=cf.Id";
            using (SqlConnection db = new SqlConnection("data source=.;database=VehicleTender;Integrated Security=true;"))
            {
                var result = await db.QueryAsync<CarListVM>(value);
                return result.ToList();
            }
        }
    }
}
