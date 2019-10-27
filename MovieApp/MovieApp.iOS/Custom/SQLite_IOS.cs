using System;
using System.IO;
using MovieApp.Custom;
using SQLite.Net;
using SQLite.Net.Platform.XamarinIOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(MovieApp.iOS.Custom.SQLite_IOS))]
namespace MovieApp.iOS.Custom
{
    public class SQLite_IOS:ISQLite
    {
        public SQLite_IOS()
        {
        }

        public SQLiteConnection GetConnection()
        {
                                                         // this is where the database is being held
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentPath, "..", "Library");
            var dbPath = Path.Combine(libraryPath, "myDatabase.db3");

            return new SQLiteConnection(new SQLitePlatformIOS(), dbPath);
        }
    }
}
