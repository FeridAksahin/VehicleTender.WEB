using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Validation
{
    public class ValidatorProperties
    {
        public static List<(bool, Exception)> GetValidatorResult<T>(object model)
        {
            var errorList = new List<(bool, Exception)>();
            bool isError = false;
            PropertyInfo[] properties = model.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo property in properties)
            {
                for (int i = 0; i < property.GetCustomAttributes(true).Length; i++)
                {
                    Type type = property.GetCustomAttributes(true)[i].GetType();
                    var getValidator = ValidatorFactory<string>.GetValidator(type);
                    var getDateValidator = ValidatorFactory<string>.GetDateValidator(type);
                    var getEmailValidator = ValidatorFactory<string>.GetEmailValidator(type);
                    var getStringValidator = ValidatorFactory<string>.GetStringValidator(type);
                    string propertyValue = property.GetValue(model).ToString();
                    int? firstAttibuteValue = null;
                    int? secondAttibuteValue = null;
                    if (property.GetCustomAttributesData()[i].NamedArguments.Count > 0)
                    {
                        firstAttibuteValue = (int)property.GetCustomAttributesData()[i].NamedArguments[0].TypedValue.Value;
                        if (property.GetCustomAttributesData()[i].NamedArguments.Count > 1)
                        {
                            secondAttibuteValue = (int)property.GetCustomAttributesData()[i].NamedArguments[1].TypedValue.Value;
                        }
                    }
                    isError = false;
                    if (DateTime.TryParse(propertyValue, out DateTime temp))
                    {
                        foreach ((bool, Exception) error in getDateValidator.Validate(propertyValue, firstAttibuteValue, property.Name))
                        {
                            isError = true;
                            errorList.Add(error);
                        }
                    }
                    else if (!typeof(T).IsValueType && typeof(T) != typeof(string))
                    {
                        if (type.Name.Contains("Email"))
                        {
                            foreach ((bool, Exception) error in getEmailValidator.Validate(propertyValue, firstAttibuteValue, property.Name))
                            {
                                isError = true;
                                errorList.Add(error);
                            }
                        }
                        else if (type.Name.Contains("String"))
                        {

                            foreach ((bool, Exception) error in getStringValidator.Validate(propertyValue, firstAttibuteValue, secondAttibuteValue, property.Name))
                            {
                                isError = true;
                                errorList.Add(error);
                            }
                        }
                    }
                    else
                    {
                        foreach ((bool, Exception) error in getValidator.Validate(propertyValue, firstAttibuteValue, secondAttibuteValue, property.Name, property, model))
                        {
                            isError = true;
                            errorList.Add(error);
                        }
                    }
                    if (isError)
                    {
                        break;
                    }
                }
            }
            return errorList;

        }
    }
}
