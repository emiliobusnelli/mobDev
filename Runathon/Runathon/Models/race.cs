using System;
namespace Runathon.Models
{
    public class race
    {
        public int id { get; set; }
        public string race_name { get; set; }
    }

    public class RaceCollection
    {
        public race[] races { get; set; }
    }
}