﻿using System;
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
        public string NamaMenu;
        public string Makanan;
        public string Minuman;
        public Umur UmurPengguna;
        public RentangHarga RentangHargaPengguna;
        public Menu(string NamaMenu, string Makanan, string Minuman, Umur UmurPengguna, RentangHarga RentangHargaPengguna)
        {
            this.NamaMenu = NamaMenu;
            this.Makanan = Makanan;
            this.Minuman = Minuman;
            this.UmurPengguna = UmurPengguna;
            this.RentangHargaPengguna = RentangHargaPengguna;
        }
    }
}