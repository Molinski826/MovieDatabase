using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    public class Movie
    {
        public string Title { get; set; }
        public string Category {  get; set; }
        public int Year { get; set; }
        public int Length { get; set; }

        public Movie (string title, string category, int year, int length)
        {
            Title = title;
            Category = category;
            Year = year;
            Length = length;
        }
       
    }
}
