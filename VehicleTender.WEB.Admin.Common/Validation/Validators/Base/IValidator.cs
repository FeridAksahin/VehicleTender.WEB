using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.WEB.Admin.Common.Validation.Validators.Base
{
    public interface IValidator<T>
    {
        List<(bool, Exception)> Validate(T value, int? value2, int? value3, string value4, PropertyInfo? info, object? model);
    }
}
