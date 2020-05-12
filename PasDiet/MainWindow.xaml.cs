using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PasDiet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void OnCari(object sender, RoutedEventArgs e)
        {
            if (UmurPengguna.SelectedIndex == -1 || RentangPengguna.SelectedIndex == -1)
            {
                MessageBox.Show("Silahkan masukkan Umur atau Rentang Harga");
            } else
            {
                var daftar = Database.Quary((Umur)UmurPengguna.SelectedIndex, (RentangHarga)RentangPengguna.SelectedItem);
                foreach(var menu in daftar)
                {
                    DaftarPaket.Items.Add(menu.NamaMenu);
                }
                
            }

        }
    }
}
