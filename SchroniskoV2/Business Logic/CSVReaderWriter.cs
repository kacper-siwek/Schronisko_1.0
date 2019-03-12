using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace SchroniskoV2.Business_Logic
{
    /// <summary>
    /// Klasa została stworzona do zapisywania i odczytywania stanu schroniska.
    /// 
    /// Metoda WriteAllAnimals przyjmuje pojedyńczy parametr isExiting. Jeśli isExiting == false to znaczy, że użytkownik chce tylko zobaczyć stan schronisk i 
    /// stworzony plik zostaje otworzony dla wglądu przez użytkownika. Jeśli isExiting == true to znaczy, że aplikacja jest zamykana, a więc plik nie zostanie otworzony.
    /// 
    /// //todo - zdefiniowana przez użytkownika ścieżka zapisu.
    /// </summary>
    internal static class CSVReaderWriter
    {
        internal static void SaveShelterStatus(bool isExiting)
        {
            var animals = ShelterManager.ListAnimals();

            using (var csv = new StreamWriter(@"C:\Users\Kacper\Documents\Moje\Programowanie\C#\Schronisko\Schronisko_1.0\eksport.csv"))
            {
                var firstLine = string.Format("ID;Imie;Typ;Data rejestracji");
                csv.WriteLine(firstLine);
                csv.Flush();

                foreach (Animal animal in animals)
                {
                    var line = string.Format("{0};{1};{2};{3}",
                                              animal.AnimalId,
                                              animal.Name,
                                              animal.Type,
                                              animal.DateOfAdmission);
                    csv.WriteLine(line);
                    csv.Flush();
                }
            }

            // otwieranie pliku
            if (!isExiting)
                Process.Start(@"C:\Users\Kacper\Documents\Moje\Programowanie\C#\Schronisko\Schronisko_1.0\eksport.csv");
        }

        internal static void LoadShelterStatus()
        {
            using (var reader = new StreamReader(@"C:\Users\Kacper\Documents\Moje\Programowanie\C#\Schronisko\Schronisko_1.0\eksport.csv"))
            {
                var line = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    var values = line.Split(';');

                    int Id = Int32.Parse(values[0]);
                    string name = values[1];
                    string type = values[2];
                    DateTime DateOfAdmission = DateTime.ParseExact(values[3], "dd.MM.yyyy HH:mm:ss",
                                                                   System.Globalization.CultureInfo.InvariantCulture);

                    ShelterManager.Add(Id, name, type, DateOfAdmission);
                }
            }
        }
    }
}
