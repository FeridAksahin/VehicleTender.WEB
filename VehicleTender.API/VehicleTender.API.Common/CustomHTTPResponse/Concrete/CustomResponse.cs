using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleTender.API.Common.CustomHTTPResponse.Interface;

namespace VehicleTender.API.Common.CustomHTTPResponse.Concrete
{
    public class CustomResponse : IDisposable, ICustomResponse
    {
        public CustomResponseModel ResponseForGetRequest(string responseData, int responseStatuCode) 
        {
            CustomResponseModel customResponse;
            using (customResponse = new CustomResponseModel())
            {
                customResponse.GetResponseStatusWhatDoYouWant_CustomStatuOrDefinedStatus.GetHttpStatusCodes(responseStatuCode);
                customResponse.ResponseDataString = responseData;
            }
            return customResponse;
        }
        public CustomResponseModel ResponseForGetRequest(string responseData, int responseStatuCode, string whatDoYouWantToSendResponse) 
        {
            CustomResponseModel customResponse;
            using (customResponse = new CustomResponseModel())
            {
                customResponse.GetResponseStatusWhatDoYouWant_CustomStatuOrDefinedStatus.MakeCustomStatuCode(responseStatuCode, whatDoYouWantToSendResponse);
                customResponse.ResponseDataString = responseData;
            }
            return customResponse;
        }
        public StatusGenerator ResponseForDeleteOrPutOrPostRequest(int responseStatuCode)
        {
            StatusGenerator statusGenerator;
            using (statusGenerator = new StatusGenerator())
            {
                statusGenerator.GetHttpStatusCodes(responseStatuCode);
            }
            return statusGenerator;
        }
        public StatusGenerator ResponseForDeleteOrPutOrPostRequest(int responseStatuCode, string whatDoYouWantToSendResponse)
        {
            StatusGenerator statusGenerator;
            using (statusGenerator = new StatusGenerator())
            {
                statusGenerator.MakeCustomStatuCode(responseStatuCode, whatDoYouWantToSendResponse);
            }
            return statusGenerator;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
