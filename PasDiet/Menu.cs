using System;
using System.Collections.Generic;
using System.Text;

namespace PasDiet
{
    enum Umur
    {
        Anak,
        Remaja,
        Dewasa
    }
    enum RentangHarga
    {
        MenengahKeatas,
        MenengahKebawah
    }
    class Menu
    {
        public int Id { set; get; }
        public string NamaMenu { set; get; }
        public List<string> Makanan { set; get; }
        public List<string> Minuman { set; get; }
        public Umur UmurPengguna { set; get; }
        public RentangHarga RentangHargaPengguna { set; get; }
        public Menu() { }
        public Menu(string NamaMenu, List<string> Makanan, List<string> Minuman, Umur UmurPengguna, RentangHarga RentangHargaPengguna)
        {
            this.NamaMenu = NamaMenu;
            this.Makanan = Makanan;
            this.Minuman = Minuman;
            this.UmurPengguna = UmurPengguna;
            this.RentangHargaPengguna = RentangHargaPengguna;
        }
    }
}
