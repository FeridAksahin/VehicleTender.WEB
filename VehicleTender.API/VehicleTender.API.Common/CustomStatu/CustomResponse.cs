using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace VehicleTender.API.Common.CustomStatu
{
    public class CustomResponse<T> where T : class
    {
        public T Data { get; private set; }
        public int StatusCode { get; private set; }
        public Error ErrorDto { get; private set; }
        //[JsonIgnore]
        public bool IsSuccesfull { get; private set; }

        public static CustomResponse<T> Succes(T data, int statusCode)
        {
            return new CustomResponse<T> { Data = data, StatusCode = statusCode, IsSuccesfull = true };
        }
        public static CustomResponse<T> Succes(int statusCode)
        {
            return new CustomResponse<T> { Data = default, StatusCode = statusCode, IsSuccesfull = true };
        }
        public static CustomResponse<T> Fail(Error errorDto, int statusCode)
        {
            return new CustomResponse<T> { ErrorDto = errorDto, StatusCode = statusCode, IsSuccesfull = false };
        }
        public static CustomResponse<T> Fail(string errorMessage, int statusCode, bool isShow)
        {
            var errorDto = new Error(errorMessage, isShow);
            return new CustomResponse<T> { ErrorDto = errorDto, StatusCode = statusCode, IsSuccesfull = false };


        }
    }
}
