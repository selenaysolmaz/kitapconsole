using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitapcons
{
    class Program
    {
        static void Main(string[] args)
        {
            int iSiparisMik;
            float fIndirimMik, fOdenecekMik;
            int iFiyat = 100;
            Console.WriteLine("kac adet kitap alınacak? :  ");
            iSiparisMik = Convert.ToInt32(Console.ReadLine());

            if (iSiparisMik < 20)
            {
                fIndirimMik = 0;
                fOdenecekMik = (iFiyat - fIndirimMik) * iSiparisMik;
                Console.WriteLine("indirim yapılmadı : ");
                Console.WriteLine("toplam tutar : " + fOdenecekMik);
            }
            if (iSiparisMik >= 20 && iSiparisMik <= 50)
            {
                fIndirimMik = iFiyat * 5 / 100;
                fOdenecekMik = (iFiyat - fIndirimMik) * iSiparisMik;
                Console.WriteLine("indirim miktarı : " + fIndirimMik);
                Console.WriteLine("toplam tutar : " + fOdenecekMik);
            }
            if (iSiparisMik > 50 && iSiparisMik <= 100)
            {
                fIndirimMik = iFiyat * 10 / 100;
                fOdenecekMik = (iFiyat - fIndirimMik) * iSiparisMik;
                Console.WriteLine("indirim miktarı : " + fIndirimMik);
                Console.WriteLine("toplam tutar : " + fOdenecekMik);
            }
            if (iSiparisMik > 100 && iSiparisMik <= 200)
            {
                fIndirimMik = iFiyat * 25 / 100;
                fOdenecekMik = (iFiyat - fIndirimMik) * iSiparisMik;
                Console.WriteLine("indirim miktarı : " + fIndirimMik);
                Console.WriteLine("toplam tutar : " + fOdenecekMik);
            }

            Console.ReadKey();
        }
    }
}
