using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Konsole.Grundkurs.Klassen;
using Konsole.Grundkurs.Collections.Arrays;
using Konsole.Grundkurs.Variablen;

namespace Konsole
{
    /// <summary>
    /// Willkommen beim Premium Grundkurs CSharp
    /// 
    /// Die einzelnen Bereiche sind voneinander unabhängig und können jeweils von der Program.cs Datei aufgerufen werden.
    /// Dies wird durch einerseits durch die Ordnerstruktur gewährleistet und zum zweiten, durch die usind Direktiven. Den Aufruf der namespaces. Dem nutzen der Libraries bzw. Frameworks.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Variablen variablen = new Variablen();

            Console.WriteLine(variablen.Wort);

            Console.ReadKey();
        }
    }
}