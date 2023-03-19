using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiKartOdevi
{

    
    public class Kart
    {
    
        public string bankaAdi { get; set; }
        public string kartAdi { get; set; }
        public string _kartTuru { get; set; }
        public int Cvv { get; set; }
        public decimal Bakiye { get; set; }


        public virtual void ParaCek(decimal tutar)
        {
            if (Bakiye >= tutar)
            {
                Bakiye -= tutar;
                Console.WriteLine("{0} Tl Para Çekildi.{1} Tl Bakiye Durumu", tutar, Bakiye);
            }
          
        }

        public virtual void ParaYatir(decimal tutar)
        {
            Bakiye += tutar;
            Console.WriteLine("{0} Tl Para Yatırıldı. Güncel Bakiye: {1} TL", tutar, Bakiye);
        }

    }

    public enum _kartTuru 
    {
        Visa,Master
    }
  
}
