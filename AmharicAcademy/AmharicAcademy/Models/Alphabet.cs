using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AmharicAcademy.Models
{
    public class Alphabet
    {
        public int ID { get; set; }
        public string AmharicChar { get; set; }
        public string EnglishString { get; set; }
    }


    public class AlphabetContext : DbContext
    {
        public DbSet<Alphabet> AmAlphabets { get; set; }
    }
}