using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Biblioteca
{
    public class Libro
    {
        

        public void CalculateRating()
        {
            Rating = (int)Math.Round(MediaVoti / 100d, 0);
        }

        [JsonProperty("isbn")]
        public string Isbn { get; set; }

        [JsonProperty("title")]
        public string Titolo { get; set; }

        [JsonProperty("authors")]
        public string Autori { get; set; }

        [JsonProperty("subtitle")]
        public string Sottotitolo { get; set; }

        [JsonProperty("categories")]
        public string Categorie { get; set; }

        [JsonProperty("thumbnail")]
        public string Immagine { get; set; }

        [JsonProperty("description")]
        public string Descrizione { get; set; }

        [JsonProperty("published_year")]
        public string Anno { get; set; }

        [JsonProperty("average_rating")]
        public float MediaVoti { get; set; }

        [JsonProperty("num_pages")]
        public string Pagine { get; set; }

        [JsonProperty("ratings_count")]
        public int QuantitaVoti { get; set; }

        [JsonProperty("qta")]
        public int Quantita { get; set; }
        public int Rating { get; set; }
        
        public List<User> Users = new List<User>();


    }
}
