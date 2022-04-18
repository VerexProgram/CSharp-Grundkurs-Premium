using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsole.Grundkurs.Klassen
{
    public class Hubschrauber : Luftfahrzeug
    {
        public new string? Modelname { get; set; }
        public new int Id { get; set; }

        public override void Starten()
        {
            Console.WriteLine($"Der Hubschrauber {Modelname} mit der Nr. {Id} startet");
        }
    }
}
