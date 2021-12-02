using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimNedir
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Kalıtım miras alma nedir
             * Kalıtım yolu ile oluşturulmuş olduğumuz nesnelerimiz
             * birbirlerinden türetilebilir ve türeyen nesne türetilen nesnenin tüm özelliklerini kullanabilir
             * c# programlama diline başlarken tip dönüşümlerinde tüm nesneleri tanıyan her türden nesneyi kabul eden
             * object tipinden bahsetmiştik
             * Object tipi framework içerisindeki tüm nesnelerin atası olan bir tip olduğu için
             *(tüm nesneler object nesnesinden kalıtıldığı için)türetilen tip kendisinden türeyen tüm tipleri tanır
             *tam bir uyumluluk sağlar.
             *Ogrenci O1 = new Ogrenci();
             *Nesne örneği alınan öğrenci nesnesi aslında object tipinden üretilmiş bir nesnedir
            // */
            //TemelTip T1 = new TemelTip();
            //T1.TemelTipMetot1();

            //Egitmen E1 = new Egitmen();
            //Console.WriteLine("Egitmen nesnesi örneklendi");
            //E1.TemelTipMetot1();

            //özel tipler boxing ve unboxing
            //Bizim object nesnemiz nedir?
            ////Temel tip
            //TemelTip T2;
            ///hangi nesnelerde temeltip object görevi görür
            ///personel eğitmen öğrenci
            ///temeltip nesnesinin türedikleri için temel tip nesnesi bu nesnelerde object gibi davranır.
            //T2 = E1;//Eğitmen nesnesi temeltip nesnesine atadık.
            //E1 = (Egitmen)T2;

            //Personel P1 = new Personel();
            //T2 = P1;//personel nesnesini temeltip nesnesine atadık.

            //P1 = (Personel)T2;//Unboxing

            //Ogrenci O1 = new Ogrenci();
            //T2 = O1;//Ogrenci nesnesini temeltip nesnesine atadık.
            //O1 = (Ogrenci)T2;//unboxing

            //object O3 = T2;

            //object O1 = E1;
            //E1 = (Egitmen)O1;

            //Personel P1 = new Personel();
            //P1.TemelTipMetot1();

            //Ogrenci O1 = new Ogrenci();
            //O1.TemelTipMetot1();

            //object obj1 = O1;
            //O1 = (Ogrenci)obj1;

            //obj1 = P1;
            //P1 = (Personel)obj1;

            //türemiş olan tipler türeyemesin
            //object => temeltip => personel => X 
            //                   => Ogrenci  => X
            //                   => Egitmen  => X

            //Hangi nesnemizin kalıtılmasını istemiyoruz
            // Sealed Class Egitmen

            //Egitmen E1 = new Egitmen();

            //public : uygulamamızın içerisinde veya dışarısında ulaşılabilir
            //private sadece tanımlandığı class içinde erişilebilir
            //protected : normal kullanımda private olarak davranır kalıtım yolu ile başka bir class içerisinde public olarak kullanılır

            TemelTip T1 = new TemelTip();

            Ogrenci O1 = new Ogrenci();
            O1.TemelTipMetot1();

            Console.ReadKey();
        }
    }
}
