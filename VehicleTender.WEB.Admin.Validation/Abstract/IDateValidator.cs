using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Validation.Validators.Abstract
{
    public interface IDateValidator<T>
    {
        List<(bool, Exception)> Validate(T value, int? value2, string value4);
    }
}
