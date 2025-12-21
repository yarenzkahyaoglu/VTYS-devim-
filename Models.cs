using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B241210094_VTYS
{
    // ================================================
    // MARKA
    // ================================================
    public class Marka
    {
        public int MarkaID { get; set; }
        public string MarkaAdi { get; set; }

        public override string ToString()
        {
            return MarkaAdi;
        }
    }

    // ================================================
    // MODEL
    // ================================================
    public class Model
    {
        public int ModelID { get; set; }
        public string ModelAdi { get; set; }

        public override string ToString()
        {
            return ModelAdi;
        }
    }

    // ================================================
    // PARÇA KATEGORİ
    // ================================================
    public class ParcaKategori
    {
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }

        public override string ToString()
        {
            return KategoriAdi;
        }
    }

    // ================================================
    // PARÇA ITEM
    // ================================================
    public class ParcaItem
    {
        public int ParcaID { get; set; }
        public string ParcaAdi { get; set; }
        public int Stok { get; set; }

        public string Display => $"{ParcaAdi} (Stok: {Stok})";

        public override string ToString()
        {
            return Display;
        }
    }

    // ================================================
    // ARAÇ ITEM
    // ================================================
    public class AracItem
    {
        public int AracID { get; set; }
        public string SaseNo { get; set; }
        public string ModelAdi { get; set; }

        // ✅ DOĞRU DISPLAY
        public string Display => $"{AracID} - {SaseNo} ({ModelAdi})";

        public override string ToString()
        {
            return Display;
        }
    }
    // ================================================
    // DEPARTMAN
    // ================================================
    public class Departman
    {
        public int DepartmanID { get; set; }
        public string DepartmanAdi { get; set; }

        public override string ToString()
        {
            return DepartmanAdi;
        }
    }

    // ================================================
    // ÇALIŞAN ITEM (Üretim Personeli)
    // ================================================
    public class CalisanItem
    {
        public int CalisanID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Pozisyon { get; set; }
        public string UzmanlikAlani { get; set; }

        public string Display => $"{Ad} {Soyad} - {Pozisyon}";

        public override string ToString()
        {
            return Display;
        }
    }

    // ================================================
    // MÜHENDİS ITEM
    // ================================================
    public class MuhendisItem
    {
        public int CalisanID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Pozisyon { get; set; }
        public int YetkiSeviyesi { get; set; }

        public string Display => $"{Ad} {Soyad} - Yetki: {YetkiSeviyesi}";

        public override string ToString()
        {
            return Display;
        }
    }

    // ================================================
    // MÜŞTERİ ITEM
    // ================================================
    public class MusteriItem
    {
        public int MusteriID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }

        public string Display => $"{Ad} {Soyad} - {Telefon}";

        public override string ToString()
        {
            return Display;
        }
    }
}
