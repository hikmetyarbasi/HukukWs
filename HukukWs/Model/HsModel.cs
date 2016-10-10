using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HukukWs.Model
{
    [Serializable]
    public class Calismalar
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Tarih { get; set; }
        [DataMember]
        public string BaslangicSaati { get; set; }
        [DataMember]
        public string BitisSaati { get; set; }
        [DataMember]
        public int OnayDurumuID { get; set; }
        [DataMember]
        public int KullaniciID { get; set; }
        [DataMember]
        public int ProjeID { get; set; }
        [DataMember]
        public string Aciklama { get; set; }
        [DataMember]
        public decimal FaturalananSaat { get; set; }
        [DataMember]
        public decimal FaturalanmayanSaat { get; set; }
        [DataMember]
        public decimal SilenenSaat { get; set; }
    }
    [Serializable]
    public class IpModel
    {
        [DataMember]
        public string Ip { get; set; }
        [DataMember]
        public string DbName { get; set; }
        [DataMember]
        public string SirketKodu { get; set; }
    }
    [Serializable]
    public class GetMattersResponse
    {
        [DataMember]
        public List<Matter> Matters { get; set; }
        [DataMember]
        public Statu Statu { get; set; }
        [DataMember]
        public string Operation { get; set; }
        [DataMember]
        public string Message { get; set; }
    }
    [Serializable]
    public class Matter
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public int MusteriID { get; set; }
        [DataMember]
        public string ProjeKodu { get; set; }
        [DataMember]
        public string ProjeAdi { get; set; }
        [DataMember]
        public int ProjeTipiID { get; set; }
        [DataMember]
        public string Notlar { get; set; }
        [DataMember]
        public string KapanmisProje { get; set; }
        [DataMember]
        public string VeriGirisDili { get; set; }
        [DataMember]
        public string ProjeBaslangic { get; set; }
        [DataMember]
        public string ProjeBitis { get; set; }
        [DataMember]
        public string DevirKaydiVar { get; set; }
        [DataMember]
        public string DevirTarihi { get; set; }
        [DataMember]
        public double DevirTutari { get; set; }
        [DataMember]
        public int DevirTutariBirimiID { get; set; }
        [DataMember]
        public double DevredenSure { get; set; }
        [DataMember]
        public string OzelDovizKuruVar { get; set; }
        [DataMember]
        public double OzelDovizKuru1 { get; set; }
        [DataMember]
        public double OzelDovizKuru2 { get; set; }
    }
    public class GetKullanicilarResponse
    {
        public List<Kullanicilar> Kullanicilar { get; set; }
        [DataMember]
        public Statu Statu { get; set; }
        [DataMember]
        public string Operation { get; set; }
        [DataMember]
        public string Message { get; set; }
    }
    [Serializable]
    public class Kullanicilar
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string KullaniciKodu { get; set; }
        [DataMember]
        public string Sifre { get; set; }
        [DataMember]
        public string CalisanAdi { get; set; }
        [DataMember]
        public string CalisanSoyadi { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public int GorevID { get; set; }
        [DataMember]
        public string SaatUcretli { get; set; }
        [DataMember]
        public string Bloke { get; set; }
        [DataMember]
        public string IseGirisTarihi { get; set; }
        [DataMember]
        public string IstenCikisTarihi { get; set; }
        [DataMember]
        public string Sistemde { get; set; }
        [DataMember]
        public string YetkiDizisi { get; set; }
    }
    [Serializable]
    public class HsResponse<T>
    {
        [DataMember]
        public Statu Statu { get; set; }
        [DataMember]
        public string Operation { get; set; }
        [DataMember]
        public string Message { get; set; }
        public List<T> genericList { get; set; }
    }
    public enum Statu
    {
        success = 0,
        fail = 1
    }
}