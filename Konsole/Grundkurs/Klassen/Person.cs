using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Konsole.Grundkurs.Klassen
{
    public class Person
    {
        //Eigenschaften
        public string? VorName { get; set; }
        public string? NachName { get; set; }
        public int Alter { get; set; }
        public int Id { get; set; }

        //Konstruktor

        // öffentliche Methoden ohne Rückgabewert
        public void Sitzt()
        {
            Console.WriteLine($"{VorName} {NachName} setzt sich hin.");
        }
        public void Steht()
        {
            Console.WriteLine($"{VorName} {NachName} steht.");
        }
        public void Spricht()
        {
            Console.WriteLine($"{VorName} {NachName} spricht.");
        }
        
        // öffentliche Methoden mit Parameter
        public string Sitzt(string _vorname, string _nachname)
        {
            return $"{_vorname} {_nachname} setzt sich hin.";
        }
        public string Steht(string _vorname, string _nachname)
        {
            return $"{_vorname} {_nachname} steht.";
        }
        public string Spricht(string _vorname, string _nachname)
        {
            return $"{_vorname} {_nachname} spricht.";
        }

        //statische Methoden


        //Generische Methoden
        static void MachtDieHausaufgaben()
        {

        }
    }
}


