using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Prestito
    {
        public string Isbn { get; set; }
        public Dictionary<string, DateTime> Prestiti { get; set; }
        public Prestito(string isbn, Dictionary<string, DateTime> dict)
        {
            Isbn = isbn;
            Prestiti = dict;
        }
    }
}
