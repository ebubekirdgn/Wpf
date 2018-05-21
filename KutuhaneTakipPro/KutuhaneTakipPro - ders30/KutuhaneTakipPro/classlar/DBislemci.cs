using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace KutuhaneTakipPro.classlar
{
    public class DBislemci
    {


        //datagrid doldurma metodumuz
        public static bool GridDoldur(DataGrid grd)
        {
            sbyte i = 0;
            SQLiteConnection con = new SQLiteConnection(DBbaglanti.DBadres);
            SQLiteCommand com = new SQLiteCommand("Select  tbl_Yazarlar.AdiSoyadi,  tbl_KitapListesi.Barkod,  tbl_KitapListesi.ID,  tbl_KitapListesi.KitapTuru,  tbl_KitapListesi.KitapKonusu,  tbl_KitapListesi.BaskiYeri,  tbl_KitapListesi.BaskiSayisi,  tbl_KitapListesi.BaskiTarihi,  tbl_KitapListesi.TeminTuru,  tbl_KitapListesi.TeminTarihi,  tbl_KitapListesi.SayfaSayisi,  tbl_KitapListesi.Resim,  tbl_KitapListesi.KitapAdi,  tbl_KitapListesi.EmanetDurumu,  tbl_Uyeler.AdSoyad,  tbl_Uyeler.ID As ID1 From  tbl_KitapListesi Inner Join  tbl_YayinEvleri    On tbl_YayinEvleri.ID = tbl_KitapListesi.YayınEviID Inner Join  tbl_Yazarlar    On tbl_Yazarlar.ID = tbl_KitapListesi.YazarAdiID Inner Join  tbl_Uyeler    On tbl_Uyeler.ID = tbl_KitapListesi.EkleyenID", con);
            try
            {
                SQLiteDataAdapter adp = new SQLiteDataAdapter(com);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                grd.ItemsSource = null;
                grd.ItemsSource = dt.DefaultView;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                
            }
            finally
            {
                con.Dispose();
            }

            if (i > 0) return true; else return false;

        }


    }
}
