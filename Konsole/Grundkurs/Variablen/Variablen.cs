using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsole.Grundkurs.Variablen
{
    /// <summary>
    /// Hinweis: Die Variablen, die grün unterstrichen sind, werden lediglich nicht aufgerufen. Um diese Aufrufbar zu machen, wurde der modifizierer public verwendet. Somit kann er in der Datei Program.cs aufgerufen und verwendet werden.
    /// </summary>
    public class Variablen
    {
        public string Wort = "Hallo Welt";
        public byte kleineZahla = byte.MinValue;
        public byte kleineZahlb = byte.MaxValue;
        public sbyte kleineZahlc = sbyte.MinValue;
        public sbyte kleineZahld = sbyte.MaxValue;
        public int Zahla = int.MinValue;
        public int Zahlb = int.MaxValue;
        public long längereZahla = long.MinValue;
        public long längereZahlb = long.MaxValue;
        public double kommaZahla = double.MinValue;
        public double kommaZahlb = double.MaxValue;
        public decimal kommaZahlc = decimal.MinValue;
        public decimal kommaZahld = decimal.MaxValue;

    }
}
