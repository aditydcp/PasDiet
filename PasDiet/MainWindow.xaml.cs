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
        private int idx;
        private List<Menu> daftar;
        public MainWindow()
        {
            InitializeComponent();
            DaftarPaket.SelectionChanged += new SelectionChangedEventHandler(DaftarPaketChanged);

        }
        private void OnCari(object sender, RoutedEventArgs e)
        {
            if (UmurPengguna.SelectedIndex == -1 || RentangPengguna.SelectedIndex == -1)
            {
                MessageBox.Show("Silahkan masukkan Umur atau Rentang Harga");
            }
            else
            {
                DaftarPaket.Items.Clear();
                IsiMakanan.Items.Clear();
                IsiMinuman.Items.Clear();
                daftar = Database.Quary((Umur)UmurPengguna.SelectedIndex, (RentangHarga)RentangPengguna.SelectedItem);
                
                foreach(var item in daftar)
                {
                    DaftarPaket.Items.Add(item.NamaMenu);
                }
                


            }

        }
        void DaftarPaketChanged(object sender, SelectionChangedEventArgs e)
        {
            idx = DaftarPaket.SelectedIndex;
            var menu = daftar[idx];
            IsiMakanan.Items.Clear();
            IsiMinuman.Items.Clear();
            foreach (var item in menu.Makanan)
            {
                IsiMakanan.Items.Add(item);
            }
            foreach (var item in menu.Minuman)
            {
                IsiMinuman.Items.Add(item);
            }
        }
    }
}
