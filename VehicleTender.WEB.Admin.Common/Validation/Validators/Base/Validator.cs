using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.WEB.Admin.Common.Validation.Validators.Base
{
    public record Validator
    {
        public HttpContext httpContext => new HttpContextAccessor().HttpContext;
        public bool IsEncrypted(string value)
        {
            return value.IndexOf("encß") == 0;
        }
        public bool IsHashed(string value)
        {
            return value.IndexOf("hasß") == 0;
        }
        public bool IsGetMethod()
        {
            return httpContext.Request.Method == "GET";
        }
    }
}
