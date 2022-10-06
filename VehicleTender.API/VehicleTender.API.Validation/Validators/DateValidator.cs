using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VehicleTender.API.Validation.Validators.Base;

namespace VehicleTender.API.Validation.Validators
{
    public record DateValidator<T>() : Validator, IValidator<T>
    {
        public List<(bool, Exception)> Validate(T value, int? value2, int? value3, string value4, PropertyInfo? info, object? model)
        {
            var errorList = new List<(bool, Exception)>();
            if (!DateTime.TryParse(value.ToString(), out DateTime temp))
            {
                throw new ArgumentException("T must be property System.DateTime.");
            }
            string tValue = value.ToString();
            if (DateTime.Parse(tValue).Year < value2)
            {
                errorList.Add((false, new Exception($"Time is too old. Wrong Date! Year Must Bigger Than > {value2}") { Source = value4 }));
            }
            else if (DateTime.Parse(tValue).Year > value2)
            {
                errorList.Add((false, new Exception($"Time is too much. Wrong Date! Year Must Smaller Than > {value2}") { Source = value4 }));
            }
            return errorList;
        }
    }
}
