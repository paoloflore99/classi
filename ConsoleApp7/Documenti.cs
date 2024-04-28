using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Documenti
    {
        public string Codice {  get; set; }
        public string Titolo { get; set; }
        public int Anno { get; set; }
        public string Settore { get; set; }
        public int Scaffale { get; set; }
        public string AutoreNome { get; set; }
        public string AutoreCognome { get; set; }
        public Documenti() { }
    }
}
