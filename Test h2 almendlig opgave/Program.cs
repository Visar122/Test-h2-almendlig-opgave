
using Test_h2_almendlig_opgave;

namespace Testh2almendligopgave
{
	public class program
	{
		static void Main(string[] args)
		{
			// Erklærer variablen "amount" af typen int og tildere den samtidig værdin 2 
			 // Må ikke ændres i iopgavens løsning.
	         Class1 amount1= new Class1();	
			 amount1.Add2();

			Console.WriteLine($"Nuværende værdi af amount {amount1.amount}");
			Console.ReadLine();
		}
	
		// Opgaven 
		// Du skal ændre  i programmet så kaldet til Console.WriteLine på linie 14 resultater i værdien 4 på grun af kaldt til metoden Add2
		// Dum må godt lave ekstra kode,altså flere linjer i fx. metoden Add2. Siger ikke om det vil være en løsning
	}
}