using System;
using MovieApp.Models;
using SQLite.Net;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Custom
{
    public class Database
    {
        SQLiteConnection database;
        static object locker = new object();
        
        public Database()
        {
            // Get ConnectionString
            database = DependencyService.Get<ISQLite>().GetConnection();

            // Create Database
            database.CreateTable<Movie>();
        }

        public void SaveMovie(Movie movie)
        {
            //locking
            lock (locker)
            {
                // referance database
                database.Insert(movie);
            }
        }

        public List<Movie> MovieList()
        {
            // resturn a list from a query - use List 
            var result = database.Query<Movie>("Select * from [Movie]");

            // using system.linq - use IEnumerable
            //var result = (from db in database.Table<Movie>() select db);

            return result;
        }

    }
}
