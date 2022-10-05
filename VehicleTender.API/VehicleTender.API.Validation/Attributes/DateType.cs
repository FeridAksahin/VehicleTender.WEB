using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Validation.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class DateType : Attribute
    {
        public DateType()
        {

        }
        public int MinimumYear { get; set; }

    }
}
