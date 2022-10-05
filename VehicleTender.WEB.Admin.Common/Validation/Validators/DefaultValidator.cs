using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VehicleTender.WEB.Admin.Common.Validation.Validators.Base;

namespace VehicleTender.WEB.Admin.Common.Validation.Validators
{
    public record DefaultValidator<T>() : Validator, IValidator<T>
    {
        public List<(bool, Exception)> Validate(T value, int? value2, int? value3, string value4, PropertyInfo? info, object? model)
        {
            return new List<(bool, Exception)>();
        }
    }
}
