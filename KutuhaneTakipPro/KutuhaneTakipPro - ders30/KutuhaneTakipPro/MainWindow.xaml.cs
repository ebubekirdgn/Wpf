
using KutuhaneTakipPro.classlar;
using KutuhaneTakipPro.UKontroller;
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

namespace KutuhaneTakipPro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth;
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }

        private void btn_kapat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //ana pencereyi sürükleme
        private void brd_Sagust_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

       //pencere yüklenirken
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            uc_cagir.Uc_Ekle(Content_icerik, new ucKitapListesi());


        }

        //simge durumu
        private void btn_SimgeDurumu_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        //tam ekran butonu
        private void btn_TamEkran_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;

            }
            else
            {
                this.WindowState = WindowState.Normal;


            }
        }


        //hamburger menu
        private void btn_hamburgermenu_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (btn_AnaEkleButton.Width != 60)
            {
                GridLength grd = new GridLength(80, GridUnitType.Pixel);
                grdClmn_menu.Width = grd;

                lbl_menu1.Visibility = Visibility.Hidden;
                lbl_menu2.Visibility = Visibility.Hidden;
                lbl_menu3.Visibility = Visibility.Hidden;
                lbl_menu4.Visibility = Visibility.Hidden;
                lbl_menu5.Visibility = Visibility.Hidden;
                lbl_menu6.Visibility = Visibility.Hidden;

                lbl_logoyazi.Width = 0;
                btn_AnaEkleButton.Width = 60;
                menu_altlabel_border.Visibility = Visibility.Hidden;
                menu_altpencere_resim.Visibility = Visibility.Hidden;
            }
            else
            {
                GridLength grd = new GridLength(220, GridUnitType.Pixel);
                grdClmn_menu.Width = grd;

                lbl_menu1.Visibility = Visibility.Visible;
                lbl_menu2.Visibility = Visibility.Visible;
                lbl_menu3.Visibility = Visibility.Visible;
                lbl_menu4.Visibility = Visibility.Visible;
                lbl_menu5.Visibility = Visibility.Visible;
                lbl_menu6.Visibility = Visibility.Visible;

                lbl_logoyazi.Width = 150;
                btn_AnaEkleButton.Width = 100;
                menu_altlabel_border.Visibility = Visibility.Visible;
                menu_altpencere_resim.Visibility = Visibility.Visible;
            }
        }

        //büyük ekle butonu
        private void btn_AnaEkleButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }


        //Ana Menü Butonları - ToggleButton
        #region menubutonlar

        int btn_secim = 1;

        
        private void menubuton_Hakkinda_Click(object sender, RoutedEventArgs e)
        {
            btn_secim = 1;
            secimdurumu();
        }

        private void menubuton_Ayarlar_Click(object sender, RoutedEventArgs e)
        {
            btn_secim = 2;
            secimdurumu();
        }

        private void menubuton_ZamaniDolanlar_Click(object sender, RoutedEventArgs e)
        {
            btn_secim = 3;
            secimdurumu();
        }

        private void menubuton_Emnaetlistesi_Click(object sender, RoutedEventArgs e)
        {
            btn_secim = 4;
            secimdurumu();
        }

        private void menubuton_okuyuculistesi_Click(object sender, RoutedEventArgs e)
        {
            btn_secim = 5;
            secimdurumu();
        }

        private void menubuton_kitaplistesi_Click(object sender, RoutedEventArgs e)
        {
            btn_secim = 6;
            secimdurumu();
            uc_cagir.Uc_Ekle(Content_icerik, new ucKitapListesi());
        }

        // checked status - seçim durumu
        void secimdurumu()
        {
            
            if (btn_secim == 1)
            {
                menubuton_Hakkinda.IsChecked = true;
            }
            else
            {
                menubuton_Hakkinda.IsChecked = false;
            }
            if (btn_secim == 2)
            {
                menubuton_Ayarlar.IsChecked = true;
            }
            else
            {
                menubuton_Ayarlar.IsChecked = false;
            }
            if (btn_secim == 3)
            {
                menubuton_ZamaniDolanlar.IsChecked = true;
            }
            else
            {
                menubuton_ZamaniDolanlar.IsChecked = false;
            }
            if (btn_secim == 4)
            {
                menubuton_Emnaetlistesi.IsChecked = true;
            }
            else
            {
                menubuton_Emnaetlistesi.IsChecked = false;
            }
            if (btn_secim == 5)
            {
                menubuton_okuyuculistesi.IsChecked = true;
            }
            else
            {
                menubuton_okuyuculistesi.IsChecked = false;
            }
            if (btn_secim == 6)
            {
                menubuton_kitaplistesi.IsChecked = true;
            }
            else
            {
                menubuton_kitaplistesi.IsChecked = false;
            }
        }

        #endregion

    }
}
