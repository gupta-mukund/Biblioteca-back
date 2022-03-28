using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Biblioteca
{
    public class User
    {
        
        [JsonProperty("first_name")]
        public string Nome { get; set; }

        [JsonProperty("last_name")]
        public string Cognome { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("role")]
        public string Ruolo { get; set; }

        [JsonProperty("city")]
        public string Citta { get; set; }

        [JsonProperty("code")]
        public string CodiceFiscale { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("birth_date")]
        public string DataNascita { get; set; }

        [JsonProperty("Prestiti")]
        public int Prestiti { get; set; } = 0;
        public string GetFullName()
        {
            return $"{Nome} {Cognome}";
        }
        public void AddPrestito()
        {
            if (Prestiti < 3)
            {
                Prestiti++;
            }
        }
        public int NumeroPrestiti()
        {
            return Prestiti;
        }
        public void RemovePrestito()
        {
            if (Prestiti > 0)
            {
                Prestiti--;
            }
        }
        
    }
}
