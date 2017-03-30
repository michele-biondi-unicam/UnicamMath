using System;
using System.Globalization;

namespace UnicamMath
{
    class Program
    {
        static void Main(string[] args)
        {
            double cateto1;
            double cateto2;
            double ipotenusa = 0;
            double angolo1 = 90;
            double angolo2 = 0;
            double angolo3 = 0;

            Console.WriteLine("Questo programma calcola l'ipotenusa e gli angoli interni fornendo la lunghezza di due cateti");

            // Chiedo all'utente la lunghezza del primo cateto finchè non viene inserito un valore accettabile.
            while(true){
                Console.Write("Inserisci la lunghezza del primo cateto: ");
                string cateto1Testuale = Console.ReadLine();
                try{
                    cateto1 = double.Parse(cateto1Testuale, CultureInfo.CurrentCulture); // Interpreta il metodo di rappresentazione dei numeri in base al thread corrente.
                } catch(Exception ex) {
                    Console.WriteLine("Non ho capito. Ritenta.");
                    continue;
                }
                break;
            }

            // Chiedo all'utente la lunghezza del secondo cateto finchè non viene inserito un valore accettabile.
            while(true){
                Console.Write("Inserisci la lunghezza del secondo cateto: ");
                string cateto2Testuale = Console.ReadLine();
                try{
                    cateto2 = double.Parse(cateto2Testuale, CultureInfo.CurrentCulture); // Interpreta il metodo di rappresentazione dei numeri in base al thread corrente.
                } catch(Exception ex) {
                    Console.WriteLine("Non ho capito. Ritenta.");
                    continue;
                }
                break;
            }

            

            //TO DO

            Console.WriteLine($"L'ipotenusa misura {ipotenusa}");
            Console.WriteLine($"I tre angoli interni misurano {angolo1} gradi, {angolo2} gradi e {angolo3} gradi.");

            Console.ReadKey();
        }
    }
}
