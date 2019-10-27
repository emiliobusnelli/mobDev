using System;
using SQLite.Net.Attributes;

namespace MovieApp.Models
{
    public class Movie
    {
        // Properties
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Title { get; set; }
        public string Rating { get; set; }
    }
}
