using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using VehicleTender.API.BusinessLayer.Validation.Attributes;
using VehicleTender.API.BusinessLayer.Validation.Base;

namespace VehicleTender.API.BusinessLayer.Validation.Validators
{
    public record EmailValidator<T>() : Validator, IValidator<T>
    {
        public List<(bool, Exception)> Validate(T value, int? validateType, int? value3, string source, PropertyInfo? info, object? model)
        {
            var errorList = new List<(bool, Exception)>();
            if (!typeof(T).IsValueType && typeof(T) != typeof(String))
            {
                throw new ArgumentException("T must be a value type or System.String.");
            }
            string emailValue = value.ToString();
            if (validateType != null)
            {
                switch ((EmailValidateType)validateType)
                {
                    case EmailValidateType.Outlook:
                        {
                            Regex mailRegex = new Regex(@"^([\w\.\-]+)@(outlook)\.(com)$");
                            if (!mailRegex.Match(emailValue).Success)
                            {
                                errorList.Add((false, new Exception("Email is not gmail!") { Source = source }));
                            }
                            break;
                        }
                    case EmailValidateType.Hotmail:
                        {
                            Regex mailRegex = new Regex(@"^([\w\.\-]+)@(hotmail)\.(com)$");
                            if (!mailRegex.Match(emailValue).Success)
                            {
                                errorList.Add((false, new Exception("Email is not gmail!") { Source = source }));
                            }
                            break;
                        }
                    case EmailValidateType.Gmail:
                        {
                            Regex mailRegex = new Regex(@"^([\w\.\-]+)@(gmail)\.(com)$");
                            if (!mailRegex.Match(emailValue).Success)
                            {
                                errorList.Add((false, new Exception("Email is not gmail!") { Source = source }));
                            }
                            break;
                        }
                    case EmailValidateType.Government:
                        {
                            Regex mailRegex = new Regex(@"^([\w\.\-]+)@(gov)\.(tr)$");
                            if (!mailRegex.Match(emailValue).Success)
                            {
                                errorList.Add((false, new Exception("Email is not governments mail!") { Source = source }));
                            }
                            break;
                        }
                    case EmailValidateType.Education:
                        {
                            Regex mailRegex = new Regex(@"^([\w\.\-]+)@(edu)\.(tr)$");
                            if (!mailRegex.Match(emailValue).Success)
                            {
                                errorList.Add((false, new Exception("Email is not educational mail!") { Source = source }));
                            }
                            break;
                        }
                    case EmailValidateType.Syntax:
                        {
                            Regex mailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                            if (!mailRegex.Match(emailValue).Success)
                            {
                                errorList.Add((false, new Exception("Email is not correct") { Source = source }));
                            }
                            break;
                        }
                }
            }           
            return errorList;           
        }
    }
}
