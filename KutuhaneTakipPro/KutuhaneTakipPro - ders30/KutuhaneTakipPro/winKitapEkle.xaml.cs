using KutuhaneTakipPro.classlar;
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
using System.Windows.Shapes;

namespace KutuhaneTakipPro
{
    /// <summary>
    /// Interaction logic for winKitapEkle.xaml
    /// </summary>
    public partial class winKitapEkle : Window
    {
        public winKitapEkle()
        {
            InitializeComponent();
        }

        private void txt_BaskiSayisi_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if(!char.IsDigit(e.Text,e.Text.Length-1))
            {
                e.Handled = true;
            }
        }

        private void txt_SayfaSayisi_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void txt_StokAdedi_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void btn_KitapEleKApat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow gk = (MainWindow)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            gk.Opacity = 1;

        }

        private void btn_KitapEkeBilgi_Click(object sender, RoutedEventArgs e)
        {
            
                bonus.showPopup(popup_Bilgi);
            
            
        }

        private void ekle_ekran_header_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }
    }
}
