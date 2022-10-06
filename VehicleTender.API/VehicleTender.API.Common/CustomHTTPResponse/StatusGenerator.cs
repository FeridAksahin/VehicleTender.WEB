using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleTender.API.Common.Enums.HttpStatusCode;

namespace VehicleTender.API.Common.CustomHTTPResponse
{
    public class StatusGenerator : IDisposable
    {
        public string GetHttpStatusCodes(int desiredStatusCode)
        {
            List<int> GetHttpStatusCodeInSystem = new List<int>();

            foreach (HttpStatusCode httpStatusCode in (HttpStatusCode[])Enum.GetValues(typeof(HttpStatusCode)))
            {
                GetHttpStatusCodeInSystem.Add(Convert.ToInt32(httpStatusCode));
            }
            bool CheckingIfThereIsSuchAStatusCode = GetHttpStatusCodeInSystem.Contains(desiredStatusCode);

            if (CheckingIfThereIsSuchAStatusCode)
            {
                var web = new HtmlWeb();
                HtmlDocument doc = web.Load("https://umbraco.com/knowledge-base/http-status-codes/");
                var nodes = doc.DocumentNode.SelectNodes("/html/body/div[1]/main/div/section[5]/div/div/div/div/table/tbody/tr/td");

                var HttpStatusList = new List<string>();
                foreach (var node in nodes)
                {
                    HttpStatusList.Add(node.InnerText);
                }
                var TargetRequestCodeIndexInHttpStatusList = HttpStatusList.IndexOf(desiredStatusCode.ToString());
                var ResponseCodeDescription = HttpStatusList[TargetRequestCodeIndexInHttpStatusList + 1];
                return ResponseCodeDescription;
            }
            else
                return null;
        }
        public string MakeCustomStatuCode(int desiredStatusCode, string codeDescription)
        {
            List<int> GetHttpStatusCodeInSystem = new List<int>();

            foreach (HttpStatusCode httpStatusCode in (HttpStatusCode[])Enum.GetValues(typeof(HttpStatusCode)))
            {
                GetHttpStatusCodeInSystem.Add(Convert.ToInt32(httpStatusCode));
            }
            bool CheckingIfThereIsSuchAStatusCode = GetHttpStatusCodeInSystem.Contains(desiredStatusCode);
            return CheckingIfThereIsSuchAStatusCode == true ? codeDescription : null;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
