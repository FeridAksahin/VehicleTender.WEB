using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleTender.API.Common.Web_Scrap.Interface;

namespace VehicleTender.API.Common.Web_Scrap.Concrete
{
    public class ProvinceAndDistrict : IProvinceAndDistrict
    {
        public List<string> GetProvinces() //iller
        {
            var web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://tr.wikipedia.org/wiki/T%C3%BCrkiye%27nin_illeri");
            var nodes = doc.DocumentNode.SelectNodes("/html/body/div[1]/div/div[4]/main/div/div[2]/div[1]/table[2]/tbody/tr/td[1]/table/tbody/tr/td[1]/a");
            var iller = new List<string>();
            foreach (var node in nodes)
            {
                iller.Add(node.InnerText);
            }
            return iller;
        }
        public List<string> GetDistricts(string request) //ilçeler -- aldığı request e göre (il'e yani) seçilen il'in tüm ilçelerini getirme metodu
        {
            var web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://www.bilgiadres.com/turkiyenin-il-ve-ilceleri-listesi/"); //linkinden
            var nodes = doc.DocumentNode.SelectNodes("/html/body/div/div[2]/div[1]/article/div[2]/h6[2]/table/tbody/tr/td"); //ilçe isimlerini almak

            var ilKod_il_ilceKod_ilceAdlariniCek = new List<string>();
            foreach (var node in nodes)
            {
                ilKod_il_ilceKod_ilceAdlariniCek.Add(node.InnerText); //secili nodeun inner textini yani text kısmını listeye ekleme
            }
            List<string> ilceler = new List<string>();
            for (int i = 0; i < ilKod_il_ilceKod_ilceAdlariniCek.Count; i++)
            {
                if (request == ilKod_il_ilceKod_ilceAdlariniCek[i])//eğer il ismi listede bulunursa
                {
                    ilceler.Add(ilKod_il_ilceKod_ilceAdlariniCek[i + 2]);/*onun +2. indexinde o ilin ilçesi vardır. Zaten, ilKod_il_ilceKod_ilceAdlariniCek isminden anlasıldığı
                    üzere web sitesinden çekilen verilerin türü sırayladır. Yani il bulunduysa +2. indexinde ilceKod - ilceAdlari yani ilce adı bulunmaktadır. */
                }
            }
            return ilceler;
        }
    }

}
 
