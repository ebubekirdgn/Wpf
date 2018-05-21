using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuhaneTakipPro.classlar
{
    public class DBbaglanti
    {
        public static string DBadres = @"Data Source=" + Environment.CurrentDirectory + "\\DB\\kitap.db;Version=3;New=False;Compress=True;Read Only=False;";

        public static string BagDurum;
        public static void BagTest()
        {
            using (SQLiteConnection conn = new SQLiteConnection(DBadres))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    try
                    {
                        conn.Open();
                        BagDurum = "VeriTabanına Baglanıldı ...";

                    }
                    catch (Exception)
                    {

                        BagDurum = "VeriTabanı Baglantı Hatası ...";
                    }
                }
                else { BagDurum = "VeriTabanına Baglanıldı ..."; }
            }
        }
    }
}
