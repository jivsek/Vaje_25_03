using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vozilo;

namespace Vozilo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vozilo vozilo1 = new Vozilo(50, 5);
            Console.WriteLine($"Preostali kilometri: {vozilo1.PreostaliKilometri}");

            try
            {
                // Test 1
                double[] poti = new double[] { 200, 0, 100, 60, 0, 100 };
                bool lahkoPrevozi = vozilo1.LahkoPrevozi(poti);
                Console.WriteLine(lahkoPrevozi ? "Vozilo lahko opravi pot." : "Vozilo ne more opraviti poti.");
                Console.WriteLine($"Preostali kilometri vozila: {vozilo1.PreostaliKilometri}km");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Napaka: {ex.Message}");
            }

            try
            {
                // Test 2
                vozilo1.Crpalka();
                double[] poti = new double[] { 200, 0, 0, 100, 60, 0, 100 };
                bool lahkoPrevozi = vozilo1.LahkoPrevozi(poti);
                Console.WriteLine(lahkoPrevozi ? "Vozilo lahko opravi pot." : "Vozilo ne more opraviti poti.");
                Console.WriteLine($"Preostali kilometri vozila: {vozilo1.PreostaliKilometri}km");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Napaka: {ex.Message}");
            }

            try
            {
                // Test 3
                vozilo1.Crpalka();
                double[] poti = new double[] { 200, 0, 100, 60, 0, 100, 500, 250, 300 };
                bool lahkoPrevozi = vozilo1.LahkoPrevozi(poti);
                Console.WriteLine(lahkoPrevozi ? "Vozilo lahko opravi pot." : "Vozilo ne more opraviti poti.");
                Console.WriteLine($"Preostali kilometri vozila: {vozilo1.PreostaliKilometri}km");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Napaka: {ex.Message}");
            }
        }
    }
}