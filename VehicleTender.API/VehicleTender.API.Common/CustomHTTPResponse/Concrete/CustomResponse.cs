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
        public CustomResponseModel<T> ResponseForGetRequest<T>(T responseData, int responseStatuCode) where T : class
        {
            CustomResponseModel<T> customResponse;
            using (customResponse = new CustomResponseModel<T>())
            {
                customResponse.GetResponseStatusWhatDoYouWant_CustomStatuOrDefinedStatus.GetHttpStatusCodes(responseStatuCode);
                customResponse.ResponseData = responseData;
            }
            return customResponse;
        }
        public CustomResponseModel<T> ResponseForGetRequest<T>(List<T> responseData, int responseStatuCode) where T : class
        {
            CustomResponseModel<T> customResponse;
            using (customResponse = new CustomResponseModel<T>())
            {
                customResponse.GetResponseStatusWhatDoYouWant_CustomStatuOrDefinedStatus.GetHttpStatusCodes(responseStatuCode);
                customResponse.ListResponseData = responseData;
            }
            return customResponse;
        }
        public CustomResponseModel<T> ResponseForGetRequest<T>(T responseData, int responseStatuCode, string whatDoYouWantToSendResponse) where T : class
        {
            CustomResponseModel<T> customResponse;
            using (customResponse = new CustomResponseModel<T>())
            {
                customResponse.GetResponseStatusWhatDoYouWant_CustomStatuOrDefinedStatus.MakeCustomStatuCode(responseStatuCode, whatDoYouWantToSendResponse);
                customResponse.ResponseData = responseData;
            }
            return customResponse;
        }
        public CustomResponseModel<T> ResponseForGetRequest<T>(List<T> responseData, int responseStatuCode, string whatDoYouWantToSendResponse) where T : class
        {
            CustomResponseModel<T> customResponse;
            using (customResponse = new CustomResponseModel<T>())
            {
                customResponse.GetResponseStatusWhatDoYouWant_CustomStatuOrDefinedStatus.MakeCustomStatuCode(responseStatuCode, whatDoYouWantToSendResponse);
                customResponse.ListResponseData = responseData;
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
