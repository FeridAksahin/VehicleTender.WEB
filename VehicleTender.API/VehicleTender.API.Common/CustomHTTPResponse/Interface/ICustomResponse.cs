using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Common.CustomHTTPResponse.Interface
{
    public interface ICustomResponse
    {
        CustomResponseModel<T> ResponseForGetRequest<T>(T responseData, int responseStatuCode) where T : class;
        CustomResponseModel<T> ResponseForGetRequest<T>(List<T> responseData, int responseStatuCode) where T : class;
        CustomResponseModel<T> ResponseForGetRequest<T>(T responseData, int responseStatuCode, string whatDoYouWantToSendResponse) where T : class;
        CustomResponseModel<T> ResponseForGetRequest<T>(List<T> responseData, int responseStatuCode, string whatDoYouWantToSendResponse) where T : class;
        StatusGenerator ResponseForDeleteOrPutOrPostRequest(int responseStatuCode);
        StatusGenerator ResponseForDeleteOrPutOrPostRequest(int responseStatuCode, string whatDoYouWantToSendResponse);

    }
}
