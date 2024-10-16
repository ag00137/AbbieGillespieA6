using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AbbieGillespieA6.Model
{
    public class Book
    {
        [JsonPropertyName("Title")]
        public string? Title { get; set; }

        [JsonPropertyName("Author")]
        public string? Author { get; set; }

        [JsonPropertyName("PageLength")]
        public int PageLength { get; set; }

        [JsonPropertyName("Genre")]
        public string? Genre { get; set; }

        [JsonPropertyName("YearPublished")]
        public int YearPublished { get; set; }

        [JsonPropertyName("MSRP")]
        public double MSRP { get; set; }

        public Book()
        {
            
        }
    }
}
