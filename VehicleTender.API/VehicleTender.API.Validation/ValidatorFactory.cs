using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleTender.API.Validation.Validators;
using VehicleTender.API.Validation.Validators.Base;

namespace VehicleTender.API.Validation
{
    public static class ValidatorFactory<T>
    {
        static Dictionary<string, IValidator<T>> validators = new();

        public static IValidator<T> GetValidator(Type attribute)
        {
            if (validators.Count == 0)
            {
                validators.Add("DateType", new DateValidator<T>());
                validators.Add("Default", new DefaultValidator<T>());
                validators.Add("EmailType", new EmailValidator<T>());
                validators.Add("StringType", new StringValidator<T>());
            }
            return validators.ContainsKey(attribute.Name) ? validators[attribute.Name] : validators["Default"];
        }
    }
}
