using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleTender.API.Validation.Validators.Abstract;
using VehicleTender.API.Validation.Validators.Base;
using VehicleTender.API.Validation.Validators.Concrete;

namespace VehicleTender.API.Validation
{
    public static class ValidatorFactory<T>
    {
        static Dictionary<string, IValidator<T>> validators = new();
        static Dictionary<string, IDateValidator<T>> dateValidator = new();
        static Dictionary<string, IEmailValidator<T>> emailValidator = new();
        static Dictionary<string, IStringValidator<T>> stringValidator = new();

        public static IValidator<T> GetValidator(Type attribute)
        {
            if (validators.Count == 0)
            {
                validators.Add("Default", new DefaultValidator<T>());
            }
            return validators.ContainsKey(attribute.Name) ? validators[attribute.Name] : validators["Default"];
        }

        public static IDateValidator<T> GetDateValidator(Type attribute)
        {
            if (attribute.Name.Contains("Date"))
            {
                if (dateValidator.Count==0)
                {
                    dateValidator.Add("DateType", new DateValidator<T>());
                    
                }
                return dateValidator["DateType"];
            }
            return null;
        }
        public static IEmailValidator<T> GetEmailValidator(Type attribute)
        {
            if (attribute.Name.Contains("Email"))
            {
                if (emailValidator.Count==0)
                {
                    emailValidator.Add("EmailType", new EmailValidator<T>());
                    
                }
                return emailValidator["EmailType"];
            }
            return null;
        }
        public static IStringValidator<T> GetStringValidator(Type attribute)
        {
            if (attribute.Name.Contains("String"))
            {
                if (stringValidator.Count==0)
                {
                    stringValidator.Add("StringType", new StringValidator<T>());
                    
                }
                return stringValidator["StringType"];
            }
            return null;
        }
    }
}
