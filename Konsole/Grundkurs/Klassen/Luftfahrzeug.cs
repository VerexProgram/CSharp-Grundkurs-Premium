using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Konsole.Grundkurs.Klassen
{
    public abstract class Luftfahrzeug
    {
        public string? Modelname { get; set; }
        public int Id { get; set; }
        public abstract void Starten();
    }
}

