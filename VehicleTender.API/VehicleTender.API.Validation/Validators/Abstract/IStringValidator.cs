using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Validation.Validators.Abstract
{
    public interface IStringValidator<T>
    {
        List<(bool, Exception)> Validate(T value, int? value2, int? value3, string value4);
    }
}
