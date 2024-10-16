using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbieGillespieA6.Model
{
    public class Object
    {
        public string? Title { get; set; }

        public string? Author { get; set; }

        public int PageLength { get; set; }

        public string? Genre { get; set; }

        public int YearPublished { get; set; }

        public double MSRP { get; set; }
    }
}
