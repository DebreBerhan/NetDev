using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AmharicAcademy.Models
{
    public class AmharicReading
    {
        public int ID { get; set; }
        public string readingTitle { get; set; }
        public string AmharicReadingString { get; set; }
        public string EnglishReadingString { get; set; }
    }


    public class ReadningContext : DbContext
    {
        public DbSet<AmharicReading> AmReadingContext { get; set; }
    }
}