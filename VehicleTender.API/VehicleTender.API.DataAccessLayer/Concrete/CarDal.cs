using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleTender.API.DTO.AdminDTO.Models.Car;
using VehicleTender.API.DTO.EndUserDTO.VM.Vehicle;

namespace VehicleTender.API.DataAccessLayer.Concrete
{
   
    public class CarDal
    {
        public async Task<int> Create(AddCarDTO carAddDto)
        {

            try
            {
                string sqlQuery = @"INSERT INTO Car ( [Brand], [Year], [Model], [IsActive], [ModifiedDate], [CreatedBy], [CreatedDate], [ModifiedBy], [Description], [BodyType], [Color], [FuelType], [GearType], [Version]) 
                values(@Brand,@Year,@Model,@IsActive,@ModifiedDate,@CreatedBy,@CreatedDate,@ModifiedBy,  @Description, @BodyType, @Color, @FuelType, @GearType,@Version)";



                /*
                var parameters = new DynamicParameters();
                parameters.Add("Brand", carAddDto.CarBrand);
                parameters.Add("Year", carAddDto.Year);
                parameters.Add("Model", carAddDto.Model);
                parameters.Add("IsActive", carAddDto.IsActive);
                parameters.Add("ModifiedDate", carAddDto.ModifiedDate);
                parameters.Add("CreatedBy", carAddDto.CreatedBy);
                parameters.Add("CreatedDate", carAddDto.CreatedDate);
                parameters.Add("ModifiedBy", carAddDto.ModifiedBy);
                parameters.Add("Description", carAddDto.Description);
                parameters.Add("BodyType", carAddDto.BodyType);
                parameters.Add("Color", carAddDto.Color);
                parameters.Add("FuelType", carAddDto.FuelType);
                parameters.Add("GearType", carAddDto.GearType);
                parameters.Add("Version", carAddDto.Version);

                */
                /*
                using (SqlConnection connection = new SqlConnection("data source=.;database=VehicleTender;Integrated Security=true;"))
                {
                    return (await connection.ExecuteAsync(sqlQuery, parameters));
                }*/
                return 3;
            }
            catch (Exception)
            {

                throw;
            }
           

        }

        public async Task GetAll()
        {
           
        }

        public async Task GetById()
        {
           
        }

        public async Task GetByUser()
        {
           
           
        }

        public async Task Update()
        {
            
        }

        public async Task Delete(Guid id)
        {
            

        }
    }
}
