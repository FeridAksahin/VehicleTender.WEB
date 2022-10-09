using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Common.CustomHTTPResponse.Interface
{
    public interface ICustomResponse
    {
        CustomResponseModel ResponseForGetRequest(string responseData, int responseStatuCode, string whatDoYouWantToSendResponse);
        CustomResponseModel ResponseForGetRequest(string responseData, int responseStatuCode);
        StatusGenerator ResponseForDeleteOrPutOrPostRequest(int responseStatuCode);
        StatusGenerator ResponseForDeleteOrPutOrPostRequest(int responseStatuCode, string whatDoYouWantToSendResponse);

    }
}
