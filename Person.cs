using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

public class Person
{
	//Eigenschaften
	public string VorName { get; set; }
	public string NachName { get; set; } 
	public int Alter { get; set; }
	public int Id { get; set; }

	//Konstruktor
	public Person()
	{

	}

	// öffentliche Methoden ohne Rückgabewert
	public void Sitzt();
	public void Steht();
	public void Spricht();
	
	//statische Methoden


	//Generische Methoden
}
