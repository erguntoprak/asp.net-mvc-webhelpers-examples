using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebHelpers.Models
{
    public class Ogrenci
    {
        public static List<Ogrenci> Ogrenciler { get; set; }
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Bolum { get; set; }
        public string Fakulte { get; set; }
        public int Sinif { get; set; }
        public string Numara { get; set; }
        public string TC { get; set; }
        protected Ogrenci()
        {
            
        }
        public static void FakeVeriOlustur(int count)
        {
            if (Ogrenciler == null)
            {
                Ogrenciler = GetirFakeVerileri(count);
            }
        }

        private static List<Ogrenci> GetirFakeVerileri(int count)
        {
            List<Ogrenci> Ogrenciler = new List<Ogrenci>();
            for (int i = 0; i < count; i++)
            {
                Ogrenciler.Add(new Ogrenci {
                    Id = FakeData.NumberData.GetNumber(1, 100),
                    Adi = FakeData.NameData.GetFemaleFirstName(),
                    Bolum = FakeData.NameData.GetCompanyName(),
                    Numara = FakeData.PhoneNumberData.GetPhoneNumber(),
                    Fakulte = FakeData.NameData.GetFullName(),
                    Sinif = FakeData.NumberData.GetNumber(1, 4),
                    TC =FakeData.PhoneNumberData.GetUsPhoneNumber()
                   
                });
            }
            return Ogrenciler;
        }
    }
}