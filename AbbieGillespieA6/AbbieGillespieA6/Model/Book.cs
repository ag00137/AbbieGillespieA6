using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AbbieGillespieA6.Model
{
    /// <summary>
    /// Creates a book object.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [JsonPropertyName("Title")]
        public string? Title { get; set; }

        /// <summary>
        /// Gets or sets the author.
        /// </summary>
        [JsonPropertyName("Author")]
        public string? Author { get; set; }

        /// <summary>
        /// Gets or sets the length of the page.
        /// </summary>
        [JsonPropertyName("Page Length")]
        public int PageLength { get; set; }

        /// <summary>
        /// Gets or sets the genre.
        /// </summary>
        [JsonPropertyName("Genre")]
        public string? Genre { get; set; }

        /// <summary>
        /// Gets or sets the year published.
        /// </summary>
        [JsonPropertyName("Year Published")]
        public int YearPublished { get; set; }

        /// <summary>
        /// Gets or sets the MSRP.
        /// </summary>
        [JsonPropertyName("MSRP")]
        public double MSRP { get; set; }
    }
}
