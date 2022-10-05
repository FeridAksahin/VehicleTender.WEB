using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.BusinessLayer.Validation.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class DateType:System.Attribute
    {
        public DateType()
        {

        }
        public int MinimumYear { get; set; }

    }
}
