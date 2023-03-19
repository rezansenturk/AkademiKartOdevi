using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiKartOdevi
{
    public class Gold:Kart
    {
        public bool IndirimOzelligiVarMi { get; set; }
        public bool KampanyaTanimliMi { get; set; }
        public DateTime KampanyaBaslangicTarihi { get; set; }
        public DateTime KampanyaBitisTarihi { get; set; }
        public int KazanilanPuan { get; set; }
        public bool EkKartMi { get; set; }
        public DateTime SonKullanimTarihi { get; set; }


        public void KampanyaTanimla(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            KampanyaBaslangicTarihi = baslangicTarihi;
            KampanyaBitisTarihi = bitisTarihi;
            KampanyaTanimliMi = true;
        }



        public void KampanyaBitir()
        {
            KampanyaTanimliMi = false;
        }


        public void BorcOde(decimal tutar)
        {
            if (Bakiye >= tutar)
            {
                Bakiye -= tutar;
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye");
            }
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
    }
}
