using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Validation.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class StringType : Attribute
    {
        public StringType()
        {

        }
        public int Max { get; set; }
        public int Min { get; set; }
    }

}
