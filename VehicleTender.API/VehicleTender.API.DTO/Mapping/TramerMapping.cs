using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleTender.API.DTO.EndUserDTO.VM.Vehicle;

namespace VehicleTender.API.Common.Mapping
{
    public class TramerMapping
    {
        public List<TramerDTO> TramerMap(PostingSalesVM vm)
        {

            List<TramerDTO> list = new List<TramerDTO>()
            {
                new TramerDTO() { TramerNameID=1,TramerTypeID=TramerTypeId(vm.SagArkaCamurluk) },
                new TramerDTO() { TramerNameID=2,TramerTypeID=TramerTypeId(vm.ArkaKaput) },
                new TramerDTO() { TramerNameID=3,TramerTypeID=TramerTypeId(vm.SolArkaCamurluk) },
                new TramerDTO() { TramerNameID=4,TramerTypeID=TramerTypeId(vm.SagArkaKapı) },
                new TramerDTO() { TramerNameID=5,TramerTypeID=TramerTypeId(vm.SagOnKapı) },
                new TramerDTO() { TramerNameID=6,TramerTypeID=TramerTypeId(vm.Tavan) },
                new TramerDTO() { TramerNameID=7,TramerTypeID=TramerTypeId(vm.SolArkaKapı) },
                new TramerDTO() { TramerNameID=8,TramerTypeID=TramerTypeId(vm.SolOnKapı) },
                new TramerDTO() { TramerNameID=9,TramerTypeID=TramerTypeId(vm.SagOnCamurluk) },
                new TramerDTO() { TramerNameID=10,TramerTypeID=TramerTypeId(vm.MotorKaputu) },
                new TramerDTO() { TramerNameID=11,TramerTypeID=TramerTypeId(vm.SolOnCamurluk) },
                new TramerDTO() { TramerNameID=12,TramerTypeID=TramerTypeId(vm.OnTampon) },
                new TramerDTO() { TramerNameID=13,TramerTypeID=TramerTypeId(vm.ArkaTampon) }
            };         
            return list;
        }
        public int TramerTypeId(string str)
        {
            if (str == "orginal")
            {
                return 1;
            }
            else if (str == "boyali")
            {
                return 2;
            }
            else if(str == "degisen")
            {
                return 3;
            }
            return 0;
        }
    }
}
