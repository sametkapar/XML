using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace xmlNedirNasilKullanilir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama

            //xml (Extensible Markup Language) genişletilebilir işaretleme dili olarak tanımlanabilir.
            //Html gibi etiketler kullanılarak oluşturulur. Ancak xml'de etiketleri biz belirleriz.
            //Amacı veri depolamak veya farklı platformlar arasında veri transferi sağlamaktır.
            //RSS,Ajax,Web servisleri oluşturukabilir.
            //XML ile tanımlama yaparken herhangi bir standart yoktur. Ancak bazı kurallara uyulması gerekir.
            //En önemli kural XML dosyasının başında Xml tanımlayıcısının oluşturulması gerekir.
            //<?xml version="1.0" encoding="UTF-8"?>

            #endregion

            #region XML Verilerini okuyalım

            //XDocument dokuman = XDocument.Load("../../Kisiler.xml");
            //XElement rootelement = dokuman.Root;
            //foreach (XElement item in rootelement.Elements())
            //{
            //    int id = Convert.ToInt32(item.Attribute("id").Value);
            //    string isim = item.Element("adi").Value;
            //    string soyisim = item.Element("soyadi").Value;
            //    Console.WriteLine($"{id}) {isim} {soyisim}");
            //}
            #endregion

            #region Merkez Bankası Döviz Kurlarını Okuyalım

            //XDocument kurlar = XDocument.Load("https://www.tcmb.gov.tr/kurlar/today.xml");
            //XElement rootElement = kurlar.Root;
            //foreach (XElement kur in rootElement.Elements())
            //{
            //    string kod = kur.Attribute("Kod").Value;
            //    string isim = kur.Element("Isim").Value;
            //    int unit = int.Parse(kur.Element("Unit").Value);
            //    double ForexSelling = 0;
            //    if (!string.IsNullOrEmpty(kur.Element("ForexSelling").Value))
            //    {
            //       ForexSelling = Convert.ToDouble(kur.Element("ForexSelling").Value.Replace('.', ','));
            //    }
            //    double satis = ForexSelling / unit;
            //    Console.WriteLine($"{kod} - {isim} = {satis} TL");

            //}

            #endregion

            #region Xml verilerini ekleme

            //Console.Write("ID = \t");
            //string id = Console.ReadLine();

            //Console.Write("Isim = \t");
            //string isim = Console.ReadLine();

            //Console.Write("Soyisim = \t");
            //string soyisim = Console.ReadLine();

            //string path = "../../Kisiler.xml";

            //string guid = Guid.NewGuid().ToString(); // RANDOM ID oluşturucu

            //XDocument dokuman = XDocument.Load(path);
            //XElement rootElement = dokuman.Root;

            //XElement yeniEleman = new XElement("kisi");

            //XAttribute idAttribute = new XAttribute("id", id);
            //XElement isimElement = new XElement("adi", isim);
            //XElement soyisimElement = new XElement("soyadi",soyisim);

            //yeniEleman.Add(idAttribute, isimElement, soyisimElement);

            //rootElement.Add(yeniEleman);

            //dokuman.Save(path); //try cath finally eklenip kontrol edilebilir.



            #endregion

            #region Verileri Güncelleme

            //string path = "../../Kisiler.xml";

            //XDocument dokuman = XDocument.Load(path);
            //XElement rootElement = dokuman.Root;
            //foreach (XElement item in rootElement.Elements())
            //{
            //    Console.WriteLine($"{item.Attribute("id").Value} ) {item.Element("adi").Value} {item.Element("soyadi").Value}");
            //}
            //Console.WriteLine("Güncellemek iştediğiniz kişinin id numarasını yazınız");
            //string id = Console.ReadLine();

            //Console.Write("Isim = \t");
            //string isim = Console.ReadLine();

            //Console.Write("Soyisim = \t");
            //string soyisim = Console.ReadLine();

            //foreach (XElement item in rootElement.Elements())
            //{
            //    if(item.Attribute("id").Value == id)
            //    {
            //        item.Element("adi").Value = isim;
            //        item.Element("soyadi").Value = soyisim;
            //        break;
            //    }
            //}
            //dokuman.Save(path);

            #endregion

            #region Veri Silme
            ////masaüstü uygulama olarak personeller ekle sil güncelle listede winformda.(ÖDEV)
            //string path = "../../Kisiler.xml";
            //XDocument xDoc = XDocument.Load(path);
            //XElement rootElement = xDoc.Root;
            //foreach (XElement item in rootElement.Elements())
            //{
            //    if (item.Attribute("id").Value == "1")
            //    {
            //        //item.RemoveAll(); hepsini siler
            //        item.Remove();
            //    }
            //}
            //xDoc.Save(path);
            #endregion
        }
    }
}
