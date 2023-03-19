using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiKartOdevi
{
    public class Silver:Kart
    {

        public bool KisitlamaVarMi { get; set; }
        public DateTime KisitlamaTarihi { get; set; }
        public DateTime SonKullanimTarihi { get; set; }
        public bool EkKartMi { get; set; }

        public void EftGonder(string iban, decimal tutar)
        {
            if (tutar <= 0)
            {
                Console.WriteLine("Geçersiz tutar!");
                return;
            }

            if (Bakiye < tutar)
            {
                Console.WriteLine("Yetersiz bakiye!");
                return;
            }

            Bakiye -= tutar;
            Console.WriteLine("{0} TL tutarındaki EFT {1} IBAN numarasına gönderildi.", tutar, iban);
        }

        public void BorcOde(decimal tutar)
        {
            if (tutar <= 0)
            {
                Console.WriteLine("Geçersiz tutar!");
                return;
            }

            if (Bakiye < tutar)
            {
                Console.WriteLine("Yetersiz bakiye!");
                return;
            }

            Bakiye -= tutar;
            Console.WriteLine("{0} TL tutarındaki borcunuz ödendi.", tutar);
        }

        public void TaksitYap(decimal tutar, int taksitSayisi)
        {
            decimal toplamTutar = tutar * taksitSayisi;
            if (Bakiye >= toplamTutar)
            {
                Bakiye -= toplamTutar;      
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye");
            }
        }
    }
}
