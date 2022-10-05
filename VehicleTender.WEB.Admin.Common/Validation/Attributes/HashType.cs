using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.WEB.Admin.Common.Validation.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class HashType : Attribute
    {
        public HashType()
        {

        }
    }
}
