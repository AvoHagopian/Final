using System;

namespace final.Models
{
    public class Hero
    {
        public int ID { get; set; }
        public int GodID { get; set; }
        public int CountryID { get; set; }
        public string GodName { get; set; }
        public string CountryName {get; set; }
        public string name { get; set; }
        public int victories { get; set; }
        public int losses { get; set; }
        public string weapon {get; set; }
    }
}