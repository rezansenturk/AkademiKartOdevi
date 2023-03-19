using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiKartOdevi
{
    public class Platinum : Kart
    {
        public bool ClubUyeligiVarMi { get; set; }
        public DateTime UyelikBaslangicTarihi { get; set; }
        public DateTime UyelikBitisTarihi { get; set; }
        public int KazanilanPuan { get; set; }
        public DateTime SonKullanimTarihi { get; set; }
        public bool EkKartMi { get; set; }

        public void UyeligiBitir()
        {
            ClubUyeligiVarMi = false;
        }

        public void UyeligiYenile(DateTime yeniBitisTarihi)
        {
            UyelikBitisTarihi = yeniBitisTarihi;
        }

        public void HavaleGonder(string iban, decimal tutar)
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
            Console.WriteLine("{0} TL tutarındaki havale {1} IBAN numarasına gönderildi.", tutar, iban);
        }

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
    }
}
