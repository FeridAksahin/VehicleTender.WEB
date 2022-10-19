using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VehicleTender.API.Validation.Validators.Abstract;
using VehicleTender.API.Validation.Validators.Base;

namespace VehicleTender.API.Validation.Validators.Concrete
{
    public record StringValidator<T>() : Validator, IStringValidator<T>
    {
        public List<(bool, Exception)> Validate(T value, int? max, int? min, string source)
        {
            var errorList = new List<(bool, Exception)>();
            if (!typeof(T).IsValueType && typeof(T) != typeof(string))
            {
                throw new ArgumentException("T must be a value type or System.String.");
            }
            string stringValue = value.ToString();
            if (!IsEncrypted(stringValue))
            {
                List<string> invalidChars = new List<string>() { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "<", ">", "£", "$", "½", "{", "[", "]", "}", "|", "'", "+", "/", "=", "?", "_" };

                if (stringValue.Length > max)
                {
                    errorList.Add((false, new Exception($"String is too Long. Text Must Shorter Than < {max}") { Source = source }));
                }
                else if (stringValue.Length < min)
                {
                    errorList.Add((false, new Exception($"String is too Short. Text Must Longer Than >= {min}") { Source = source }));
                }
                //if (!!stringValue.Equals(stringValue.ToLower()))
                //{
                //    errorList.Add((false, new Exception("Requres at least one uppercase") { Source = source }));
                //}
                foreach (string invalidChar in invalidChars)
                {
                    if (stringValue.Contains(invalidChar))
                    {
                        Exception exception = new Exception("String contains invalid character: " + invalidChar) { Source = source };
                        errorList.Add((false, exception));
                        break;
                    }
                }
                if (errorList.Count == 0)
                {
                    //todo 
                }
            }
            return errorList;
        }
    }
}
