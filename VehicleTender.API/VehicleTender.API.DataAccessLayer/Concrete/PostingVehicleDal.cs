using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using VehicleTender.API.Common.Mapping;
using VehicleTender.API.DTO.AdminDTO.Models.Tender;
using VehicleTender.API.DTO.EndUserDTO.VM.Vehicle;

namespace VehicleTender.API.DataAccessLayer.Concrete
{
    public class PostingVehicleDal
    {
        public bool AddPostingvehicle(PostingSalesVM vm)
        {
            var sorgu = "insert into Car(Brand,Car.Year,Model,Car.Description,BodyType,Color,FuelType,GearType) values(@Brand,@Year,@Model,@Description,@BodyType,@Color,@FuelType,@GearType)";
            var parameters = new DynamicParameters();
            parameters.Add("Brand", vm.BrandName);
            parameters.Add("Year", vm.Year);
            parameters.Add("Model", vm.ModelName);
            parameters.Add("Description", vm.Description);
            parameters.Add("BodyType", vm.BodyTypeName);
            parameters.Add("Color", vm.ColorName);
            parameters.Add("FuelType", vm.FuelTypeName);
            parameters.Add("GearType", vm.GearTypeName);
            var sorgu1 = "insert into AdvertInfo(Description,TotalTramerPrice) values(@Description,@TotalTramerPrice) ";
            var parameters1=new DynamicParameters();
            parameters1.Add("Description", vm.Description);
            parameters1.Add("TotalTramerPrice", vm.TramerTutarı);
            var sorgu2 = "insert into CarDetailInfo(AdvertInfoId,UserId,NotaryId,CarId,CommissionId) values(@AdvertId,@UserId,@NotaryId,@CarId,@ComissionId)";
            var parameters2 = new DynamicParameters();
            parameters2.Add("UserId", 1);
            parameters2.Add("NotaryId", 1);
            parameters2.Add("ComissionId", 1);
            var sorgu3 = "insert into Picture(AdvertInfoId,PicturePath) values(@AdvertId,@PicturePath)";
            TramerMapping tramerMapping = new TramerMapping();
            List<TramerDTO> tramer= tramerMapping.TramerMap(vm);
            var sorgu4 = "insert into TramerValue(TramerPartId,CarId,TramerSituationValueId) values(@TramerPartId,@CarId,@TramerTypeId)";
            var sorgu5 = "select Id from Car where Description=@Desc ";
            var parameters5=new DynamicParameters();
            parameters5.Add("Desc", vm.Description);
            var sorgu6 = "select Id from AdvertInfo where Description=@Desc ";
            var parameters6 = new DynamicParameters();
            parameters6.Add("Desc", vm.Description);
            using (SqlConnection conn = new SqlConnection("server=DESKTOP-A6E9IGN\\SQLEXPRESS;database=VehicleTender;uid=sa;password=123"))
            {
                conn.Open();
                using(var tran = conn.BeginTransaction())
                {
                    try
                    {
                        conn.Execute(sorgu, parameters,transaction:tran);
                        conn.Execute(sorgu1, parameters1, transaction: tran);
                        int carId =conn.QuerySingleOrDefault<int>(sorgu5, parameters5,transaction:tran);
                        int advertId = conn.QuerySingleOrDefault<int>(sorgu6, parameters6, transaction: tran);
                        parameters2.Add("CarId", carId);
                        parameters2.Add("AdvertId", advertId);
                        conn.Execute(sorgu2, parameters2, transaction:tran);
                        foreach (string item in vm.ImagePath)
                        {
                            var parameters3 = new DynamicParameters();
                            parameters3.Add("AdvertId", advertId);
                            parameters3.Add("PicturePath", item);
                            conn.Execute(sorgu3,parameters3,transaction:tran);
                        }
                        foreach (var item in tramer)
                        {
                            var parameters4=new DynamicParameters();
                            parameters4.Add("TramerPartId", item.TramerNameID);
                            parameters4.Add("TramerTypeId", item.TramerTypeID);
                            parameters4.Add("CarId", carId);
                            int donendeger = conn.Execute(sorgu4, parameters4, transaction: tran);
                        }
                        tran.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        return false;
                    }
                }
            }

        }
    }
}

