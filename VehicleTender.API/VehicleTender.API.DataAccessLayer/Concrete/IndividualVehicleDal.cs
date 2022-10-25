using Dapper;
using Microsoft.Data.SqlClient;
using VehicleTender.API.DTO.EndUserDTO.VM.Advert;

namespace VehicleTender.API.DataAccessLayer.Concrete
{
    public class IndividualVehicleDal
    {
        public async Task<List<CarListVM>> GetAllIndividualCars()
        {
            var value = "select c.Id as CarId, c.Brand, c.Model, c.FuelType, c.GearType, c.Version, c.BodyType, c.Color,c.Year, c.Description, ai.KM, ai.Description, ai.Price, ai.Title, ht.HardwareName from Car c inner join CarDetailInfo cdi on cdi.CarId = c.Id inner join AdvertInfo ai on ai.CarDetailInfoId = cdi.Id inner join Hardware h on h.CarId = c.Id inner join HardwareType ht on ht.Id = h.HardwareTypeId group by c.Brand, c.Model, c.FuelType, c.GearType, c.Version, c.BodyType,c.Color, c.Year,c.Description, ai.KM, ai.Description, ai.Price, ai.Title, ht.HardwareName, c.Id";

            using (SqlConnection db = new SqlConnection("data source=.;database=VehicleTender;Integrated Security=true;"))
            {
                var result = await db.QueryAsync<CarListVM>(value);
                return result.ToList();
            }
        }
        public async Task<CarListVM> GetCarByID(int id)
        {
            var value = "select c.Id as CarId, c.Brand, c.Model, c.FuelType, c.GearType, c.Version, c.BodyType, c.Color,c.Year, c.Description, ai.KM, ai.Description, ai.Price, ai.Title, ht.HardwareName from Car c inner join CarDetailInfo cdi on cdi.CarId = c.Id inner join AdvertInfo ai on ai.CarDetailInfoId = cdi.Id inner join IndividualVehicleSales ivs on ivs.CarDetailInfoId = cdi.Id inner join Hardware h on h.CarId = c.Id inner join HardwareType ht on ht.Id = h.HardwareTypeId where c.Id = 1 group by c.Brand, c.Model, c.FuelType, c.GearType, c.Version, c.BodyType,c.Color, c.Year,c.Description, ai.KM, ai.Description, ai.Price, ai.Title, ht.HardwareName, c.Id";

            using (SqlConnection db = new SqlConnection("data source=.;database=VehicleTender;Integrated Security=true;"))
            {
                var result = await db.QueryFirstOrDefaultAsync<CarListVM>(value, new { id });
                return result;
            }
        }
        
    }
}
