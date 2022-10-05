using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.BusinessLayer.Validation.Attributes
{
    public enum EmailValidateType
    {
        Education = 1,
        Government = 2,
        Gmail = 3,
        Hotmail = 4,
        Outlook= 5,
        Syntax=6,
    }
    [AttributeUsage(AttributeTargets.All)]
    public class EmailType:System.Attribute
    {
        public EmailType()
        {

        }
        public EmailValidateType EmailValidateType { get; set; }
    }
}
