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
            var PaketA = new Menu("Paket A", "Burger", "Soda", Umur.Remaja, RentangHarga.MenengahKeatas);
            Database.Insert(PaketA);

        }
    }
    
}
