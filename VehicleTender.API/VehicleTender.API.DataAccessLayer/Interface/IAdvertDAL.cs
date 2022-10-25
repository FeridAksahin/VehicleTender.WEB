using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleTender.API.DTO.EndUserDTO.VM.Advert;

namespace VehicleTender.API.DataAccessLayer.Interface
{
    public interface IAdvertDAL
    {
        public Task<List<CarListVM>> GetAllCarInAdverts();
        public Task<CarListVM> GetAdvertById(int id);
    }
}
