using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiKartOdevi
{
    public class Bankamatik : Kart
    {

        public HesapTuru HesapTuru { get; set; }
        public double Bakiye { get; set; }

        public void HavaleGonder(string iban, double tutar)
        {
            Console.WriteLine("{0} kartı {1} TL tutarında havale gönderildi.", this.kartAdi, tutar);
        }

        public void LimitTanimla(double tutar)
        {
            Console.WriteLine("{0} kartının limiti {1} TL olarak tanımlandı.", this.kartAdi, tutar);
        }
    }
    public enum HesapTuru { TL, USD, EURO, AUX };
}
