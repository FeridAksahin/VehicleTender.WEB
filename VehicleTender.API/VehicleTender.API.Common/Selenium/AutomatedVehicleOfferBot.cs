using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Common.Selenium
{
    public class AutomatedVehicleOfferBot //bireysel araç satışta girilen araca otomatik teklif vermesi için programlanan selenium botudur
    {//şuanlık 2 paremetre var, fakat bunları aracın yılı, vites tipi, yakıt tipi,kilometresi, donanım vs gibi detaylı paremetre girişleriyle bot teklif vermek üzere yapılcaktır
        public List<string> BotThatAutomaticallyBidTheEnteredCar(string brand, string model) 
        {//şuanlık demo versionu oldugundan sadece gönderilen aracın marka ve modeline göre bot teklif vermektedir 
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            var options = new ChromeOptions();
            options.AddArgument("--window-position=-32000,-32000"); //selenium botunun arka planda çalışması için. yoksa sitede otomatik açılır ve ilgili işlemler görünür

            var drive = new ChromeDriver(service, options); 

            //  string brand = "Audi";
            //   string model = "A8";
            drive.Navigate().GoToUrl("https://www.arabam.com/ikinci-el/otomobil/" + brand + "-" + model); //ilgili urlde paremetre olarak gönderilen marka model gönderilir
            IReadOnlyCollection<IWebElement> getOffers = drive.FindElements(By.CssSelector(".db.no-wrap.listing-price")); //css classı bu olanlar, araçların fiyatlarıdır. yani sayfadaki fiyatları bot çekmeye programlandı
            List<string> carOffers = new List<string>();
            foreach (IWebElement item in getOffers)
            {
                carOffers.Add(item.Text); //çekilen tüm fiyatları listeye atama işlemi.
            }//listeye atamak yerine en yüksek fiyat direk alınabilir, fakat teklif fiyat listesinden endusera random bi sayı döndürme olabilir diye şuanlık listede tüm fiyatlar

            return carOffers; //bazı araçların fiyatı çok pahalı olabilir diye direk string listesi alındı
        }

    }
}
