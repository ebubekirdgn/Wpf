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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KutuhaneTakipPro.UKontroller
{
    /// <summary>
    /// Interaction logic for ucKitapListesi.xaml
    /// </summary>
    public partial class ucKitapListesi : UserControl
    {
        public ucKitapListesi()
        {
            InitializeComponent();
        }
        MainWindow gk = (MainWindow)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);

        private void btn_KitapEkle_Click(object sender, RoutedEventArgs e)
        {

            winKitapEkle ekle = new winKitapEkle();
            ekle.Owner = gk;
            gk.Opacity = 0.3;
            ekle.ShowDialog();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            DBislemci.GridDoldur(dtg_KitapListesi);
        }
    }
}
