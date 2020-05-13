using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PasDiet
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    ///     enum Umur

    public partial class App : Application { 
    
        public App() : base() {
            CreateDb();
        }
        private void CreateDb()
        {
            {
                var makanan = new List<string>();
                var minuman = new List<string>();

                makanan.Add("Telor acak");
                makanan.Add("Roti");
                makanan.Add("Ikan Sarden");
                makanan.Add("Pisang");
                makanan.Add("Tumis tahu tempe");
                makanan.Add("Ayam panggang");

                minuman.Add("Jus jeruk");

                var PaketA = new Menu("Paket A", makanan, minuman, Umur.Dewasa, RentangHarga.MenengahKebawah);
                Database.Insert(PaketA);
            }

            {
                var makanan = new List<string>();
                var minuman = new List<string>();

                makanan.Add("Telor dadar");
                makanan.Add("Apel");
                makanan.Add("Ikan sarden");
                makanan.Add("Kuaci");
                makanan.Add("Tumis tempe");
                makanan.Add("Ayam bakar");

                minuman.Add("Jus tomat");

                var PaketB = new Menu("Paket B", makanan, minuman, Umur.Dewasa, RentangHarga.MenengahKebawah);
                Database.Insert(PaketB);
            }


            {
                var makanan = new List<string>();
                var minuman = new List<string>();

                makanan.Add("Oatmeal + peanutbutter");
                makanan.Add("Ikan salmon");
                makanan.Add("Sop sawi tahu");

                minuman.Add("Smootjie buah");
                minuman.Add("Yogurt");
                minuman.Add("Jus buah naga");

                var PaketC = new Menu("Paket C", makanan, minuman, Umur.Dewasa, RentangHarga.MenengahKeatas);
                Database.Insert(PaketC);
            }


            {
                var makanan = new List<string>();
                var minuman = new List<string>();

                makanan.Add("Oatmeal + pisang");
                makanan.Add("Ikan salmon");
                makanan.Add("Sop sawi tahu");
                makanan.Add("Sop daging sapi");

                minuman.Add("Yogurt");
                minuman.Add("Jus buah delima");

                var PaketD = new Menu("Paket D", makanan, minuman, Umur.Dewasa, RentangHarga.MenengahKeatas);
                Database.Insert(PaketD);
            }


            {
                var makanan = new List<string>();
                var minuman = new List<string>();

                makanan.Add("Kentang rebus");
                makanan.Add("Roti bakar");
                makanan.Add("Tempe goreng");
                makanan.Add("Cah kangkung");

                minuman.Add("Susu rendah lemak");

                var PaketE = new Menu("Paket E", makanan, minuman, Umur.Remaja, RentangHarga.MenengahKebawah);
                Database.Insert(PaketE);
            }


            {
                var makanan = new List<string>();
                var minuman = new List<string>();

                makanan.Add("Kentang rebus");
                makanan.Add("Roti bakar");
                makanan.Add("Tempe goreng");
                makanan.Add("Cah kangkung");

                minuman.Add("Susu rendah lemak");

                var PaketF = new Menu("Paket F", makanan, minuman, Umur.Remaja, RentangHarga.MenengahKebawah);
                Database.Insert(PaketF);
            }


            {
                var makanan = new List<string>();
                var minuman = new List<string>();

                makanan.Add("Kentang rebus");
                makanan.Add("Ayam panggang");
                makanan.Add("Salmon");
                makanan.Add("Cah kangkung");

                minuman.Add("Susu rendah lemak");
                minuman.Add("Jus tomat");

                var PaketG = new Menu("Paket G", makanan, minuman, Umur.Remaja, RentangHarga.MenengahKeatas);
                Database.Insert(PaketG);
            }


            {
                var makanan = new List<string>();
                var minuman = new List<string>();

                makanan.Add("Kentang rebus");
                makanan.Add("Ayam panggang");
                makanan.Add("Salmon");
                makanan.Add("Sop sapo tahu");

                minuman.Add("Susu rendah lemak");
                minuman.Add("Jus buah naga");

                var PaketH = new Menu("Paket H", makanan, minuman, Umur.Remaja, RentangHarga.MenengahKeatas);
                Database.Insert(PaketH);
            }


            {
                var makanan = new List<string>();
                var minuman = new List<string>();

                makanan.Add("Bubur");
                makanan.Add("Telor ceplok");
                makanan.Add("Salmon");
                makanan.Add("Brokoli");

                minuman.Add("Susu rendah lemak");
                minuman.Add("Jus apel");

                var PaketI = new Menu("Paket I", makanan, minuman, Umur.Anak, RentangHarga.MenengahKeatas);
                Database.Insert(PaketI);
            }

            {
                var makanan = new List<string>();
                var minuman = new List<string>();

                makanan.Add("Nasi goreng");
                makanan.Add("Telor rebus");
                makanan.Add("Ikan bandeng");
                makanan.Add("Sop sawi");

                minuman.Add("Jus wortel");

                var PaketJ = new Menu("Paket J", makanan, minuman, Umur.Anak, RentangHarga.MenengahKeatas);
                Database.Insert(PaketJ);
            }

            {
                var makanan = new List<string>();
                var minuman = new List<string>();

                makanan.Add("Nasi kucing");
                makanan.Add("Telor ceplok");
                makanan.Add("Ikan bandeng");
                makanan.Add("Orak arik");

                minuman.Add("Jus pisang");

                var PaketK = new Menu("Paket K", makanan, minuman, Umur.Anak, RentangHarga.MenengahKebawah);
                Database.Insert(PaketK);
            }

            {
                var makanan = new List<string>();
                var minuman = new List<string>();

                makanan.Add("Roti bakar");
                makanan.Add("Telor ceplok");
                makanan.Add("Pisang");
                makanan.Add("Cah kangkung");

                minuman.Add("Jus Apel");

                var PaketL = new Menu("Paket L", makanan, minuman, Umur.Anak, RentangHarga.MenengahKebawah);
                Database.Insert(PaketL);
            }

        }
    }
    
}
