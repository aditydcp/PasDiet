using System;
using System.Collections.Generic;
using System.Text;
using LiteDB;
using System.Linq;
using System.Windows;

namespace PasDiet
{
    static class Database
    {
        public static string DBAdress = @"DaftarMenu.db";
        private static ILiteCollection<Menu> col;

        public static void Insert(Menu menu)
        {
            using (var db = new LiteDatabase(DBAdress))
            {
                col = db.GetCollection<Menu>("MenuMenu");
                col.Insert(menu);
            }
        }
        /**public static void Update(Menu menu)
        {
            using (var db = new LiteDatabase(DBAdress))
            {
                col = db.GetCollection<Menu>("MenuMenu");
                col.EnsureIndex(x => x.NamaMenu, true);
                col.Update(menu);
            }

        }

        public static void Delete(Menu menu)
        {
            using (var db = new LiteDatabase(DBAdress))
            {
                col = db.GetCollection<Menu>("MenuMenu");
                col.EnsureIndex(x => x.NamaMenu, true);
                col.Delete(menu.Id);
            }

        }**/

        public static List<Menu> Quary(Umur umur, RentangHarga rentangHarga)
        {
            using (var db = new LiteDatabase(DBAdress))
            {
                col = db.GetCollection<Menu>("MenuMenu");
                var ret = col.Find(x => (x.UmurPengguna == umur));
                return ret.ToList();
            }

        }
    }
}