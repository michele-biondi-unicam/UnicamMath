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

            cateto1 = ChiediCatetoAllUtente("Inserisci la lunghezza del primo cateto: ");
            cateto2 = ChiediCatetoAllUtente("Inserisci la lunghezza del secondo cateto: ");

            // Calcolo l'ipotenusa con il teorema di Pitagora. Riferimento: https://it.wikipedia.org/wiki/Teorema_di_Pitagora.
            ipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));

            // Calcolo gli angoli attraverso le formule trigonometriche (arcocoseno del coseno dell'angolo).
            angolo2 = RadiantiAGradi(Math.Acos(cateto1/ipotenusa));
            angolo3 = RadiantiAGradi(Math.Acos(cateto2/ipotenusa));

            Console.WriteLine($"L'ipotenusa misura {ipotenusa.ToString("N2")}"); // Stampa due cifre decimali al massimo.

            Console.WriteLine($"I tre angoli interni misurano {angolo1.ToString("N2")} gradi, {angolo2.ToString("N2")} gradi e {angolo3.ToString("N2")} gradi.");

            Console.ReadKey();
        }

        // Funzione che converte gli angoli in radianti in angoli in gradi.
        private static double RadiantiAGradi(double radianti){
            return (radianti * 180) / Math.PI;
        }

        // Metodo che richiede cateti all'utenti
        private static double ChiediCatetoAllUtente(string messaggio) {
            while(true){
                
                Console.Write(messaggio);
                
                string cateto1Testuale = Console.ReadLine();
                if(double.TryParse(cateto1Testuale, out double cateto))
                    return cateto;
                else{
                    Console.WriteLine("Non ho capito. Ritenta.");
                    continue; // Chiede di nuovo
                }
            }
        }
    
    
    
    
    }

}
