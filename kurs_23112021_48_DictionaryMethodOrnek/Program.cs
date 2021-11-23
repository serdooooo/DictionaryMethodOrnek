using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs_23112021_48_DictionaryMethodOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            //ContainsKey : Koleksiyon içindeki Key'lerde aranan değer varsa TRUE yoksa FALSE döndürür
            //ContainsValue : 
            Dictionary<string, int> kisilerVeDTarihleri = new Dictionary<string, int>();
            kisilerVeDTarihleri.Add("Betül", 1990);
            kisilerVeDTarihleri.Add("Ali", 1950);
            kisilerVeDTarihleri.Add("Veli", 1987);
            kisilerVeDTarihleri.Add("Lale", 2000);
            kisilerVeDTarihleri.Add("Gül", 2000);
            kisilerVeDTarihleri.Add("Ayşe", 2000);
            tekrar:
            Console.WriteLine("İsminiz: ");
            string ad = Console.ReadLine();
            bool varMi = kisilerVeDTarihleri.ContainsKey(ad);

            if (varMi)
            {
                int dYili = kisilerVeDTarihleri[ad];
                int yas = DateTime.Now.Year - dYili;
                Console.WriteLine("Yaşı: "+yas);
            }
            else
            {
                Console.WriteLine("Bu değer koleksiyonda yoktur. Ekelememiz için aşağıdaki bilgileri doldurunuz.");
                Console.WriteLine(ad+"isimli kişinin doğum yılını giriniz: ");
                int dogumYili = Convert.ToInt32(Console.ReadLine());
                kisilerVeDTarihleri.Add(ad, dogumYili);
                
               Console.WriteLine("Yeni kullanıcı eklendi");
                Console.WriteLine("Yeni kullanıcı eklemek ister misin? e/h");
                string devam = Console.ReadLine();
                if (devam=="e")
                {
                    goto tekrar;
                }
                else
                {
                    Listele(kisilerVeDTarihleri);
                }
               
            }
            Console.ReadKey();
        }

        static void Listele(Dictionary<string, int> liste)
        {
            Console.Clear();
            Console.WriteLine("Koleksiyonda " + liste.Count + " adet kayıt mevcuttur.");

            //dictionary deki değerleri yazdırdık
            foreach (KeyValuePair<string, int> item in liste)
            {
                Console.WriteLine(item.Key + "-" + item.Value);
            }
            foreach (var item in liste.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (var item in liste.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
