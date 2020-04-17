using Xamarin.Forms;
using System.IO;
using SQLite;
using System;
using ZamarinKurs.Persistence;
using ZamarinKurs.Droid.Persistence;

[assembly: Dependency(typeof(SQLiteDb))]

namespace ZamarinKurs.Droid.Persistence
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "MySQLite.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}