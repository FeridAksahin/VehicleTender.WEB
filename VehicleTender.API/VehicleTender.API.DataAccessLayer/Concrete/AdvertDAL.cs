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
        public async Task<List<CarListVM>> GetAllCarInAdverts()
        {
            var value = "select c.Id,c.Brand,c.Model,c.Year,c.GearType,ai.KM from AdvertInfo ai\r\ninner join CarDetailInfo cdi on ai.CarDetailInfoId=cdi.Id\r\ninner join car c on c.Id=cdi.CarId";

            using (SqlConnection db = new SqlConnection("data source=.;database=VehicleTender;Integrated Security=true;"))
            {
                var result = await db.QueryAsync<CarListVM>(value);
                return result.ToList();
            }
        }

        public async Task<CarListVM> GetAdvertById(int id)
        {
            var value = $"select c.Id,c.Brand,c.Model,c.BodyType,c.Year,c.FuelType,c.GearType,c.Version,ai.KM,c.Color,ht.HardwareName from AdvertInfo ai\r\ninner join CarDetailInfo cdi on ai.CarDetailInfoId=cdi.Id\r\ninner join car c on c.Id=cdi.CarId\r\ninner join Hardware h on h.CarId=c.Id\r\ninner join HardwareType ht on ht.Id=h.HardwareTypeId\r\nwhere c.Id={id}";
            using (SqlConnection db = new SqlConnection("data source=.;database=VehicleTender;Integrated Security=true;"))
            {
                var result = await db.QueryAsync<CarListVM>(value,id);
                return result.FirstOrDefault();

            }
        }
    }
}
