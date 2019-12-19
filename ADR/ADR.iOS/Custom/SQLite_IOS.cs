//using System;
//using Xamarin.Forms;
//using ADR.iOS.Custom;
//using ADR.Custom;
//using SQLite;
//using System.IO;
//using SQLite.Net.Platform.XamarinIOS;

//[assembly: Dependency(typeof(SQLite_IOS))]
//namespace ADR.iOS.Custom
//{
//    public class SQLite_IOS : ISQLite
//    {
//        public SQLite_IOS()
//        {
//        }

//        public SQLiteConnection GetConnection()
//        {
//            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
//            var libraryPath = Path.Combine(documentPath, "..", "Library");
//            var dbPath = Path.Combine(libraryPath, "adrDatabase.db3");

//            return new SQLiteConnection(new SQLitePlatformIOS(), dbPath);
//        }
//    }
//}

using System;
using Xamarin.Forms;
using ADR.iOS;

//[assembly: Dependency(typeof(ADR.iOS.))]


//using System;
//using System.IO;
//using ADR.Custom;
//using SQLite.Net;
//using SQLite.Net.Platform.XamarinIOS;
//using Xamarin.Forms;

//[assembly: Dependency(typeof(ADR.iOS.Custom.SQLite_IOS))]
//namespace ADR.iOS.Custom
//{
//    public class SQLite_IOS : ISQLite
//    {
//        public SQLite_IOS()
//        {
//        }

//        public SQLiteConnection GetConnection()
//        {
//            // this is where the database is being held
//            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
//            var libraryPath = Path.Combine(documentPath, "..", "Library");
//            var dbPath = Path.Combine(libraryPath, "myDatabase.db3");

//            return new SQLiteConnection(new SQLitePlatformIOS(), dbPath);
//        }
//    }
//}