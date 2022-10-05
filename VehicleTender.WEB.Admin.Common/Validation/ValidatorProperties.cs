using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.WEB.Admin.Common.Validation
{
    public class ValidatorProperties
    {
        public static List<(bool, Exception)> GetValidatorResult(object model)
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
                    foreach ((bool, Exception) error in getValidator.Validate(propertyValue, firstAttibuteValue, secondAttibuteValue, property.Name, property, model))
                    {
                        isError = true;
                        errorList.Add(error);
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
