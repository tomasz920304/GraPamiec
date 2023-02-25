using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraPamiec.Klasy
{
    public class ObrazkiRepozytorium
    {
        public static Image PobierzLogo()
        {
            var logoSciezka = $"{AppDomain.CurrentDomain.BaseDirectory}\\Dane\\logo.jpg";
            var logo = Image.FromFile(logoSciezka);
            return logo;
        }

        public static List<Image> PobierzObrazki()
        {
            var folderObrazkiSciezka = $"{AppDomain.CurrentDomain.BaseDirectory}\\Dane\\Obrazki";
            var obrazkiSciezka = Directory.GetFiles(folderObrazkiSciezka);

            var obrazki = new List<Image>();

            foreach (var obrazekSciezka in obrazkiSciezka)
            {
                var obrazek = Image.FromFile(obrazekSciezka);
                obrazki.Add(obrazek);
            }

            return obrazki;
        }
    }
}