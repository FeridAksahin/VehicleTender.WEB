using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VehicleTender.API.BusinessLayer.Validation.Base;

namespace VehicleTender.API.BusinessLayer.Validation
{
    public record HashValidator<T>() : Validator, IValidator<T>
    {
        public List<(bool, Exception)> Validate(T value, int? value2, int? value3, string value4, PropertyInfo? info, object? model)
        {
            throw new NotImplementedException();
        }
    }
}
