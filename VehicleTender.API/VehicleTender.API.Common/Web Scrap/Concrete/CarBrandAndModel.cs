using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleTender.API.Common.Web_Scrap.Interface;

namespace VehicleTender.API.Common.Web_Scrap.Concrete
{
    public class CarBrandAndModel : ICarBrandAndModel
    {
        public List<string> GetBrands()
        {
            var web = new HtmlWeb();
            HtmlDocument document = web.Load("https://www.fordikinciel.com/markalar");
            var nodes = document.DocumentNode.SelectNodes("/html/body/form/article/div[2]/div[2]/div/ul/li/a");
            var brands = new List<string>();
            foreach (var i in nodes)
            {
                brands.Add(i.InnerText);
            }
            return brands;

        }

        public List<string> GetModels()
        {
            //seçilen markanın tüm modellerini getirme işlemi için web scrap metodu -- yapım aşamasında
            throw new NotImplementedException();
        }
    }
}
