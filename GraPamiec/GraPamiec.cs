using GraPamiec.Klasy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraPamiec
{
    public partial class GraPamiec : Form
    {
        public GraPamiec()
        {
            InitializeComponent();
            UzupelnijPanel();            
        }

        public List<Karta> GenerujKarty()
        {
            var obrazki = ObrazkiRepozytorium.PobierzObrazki();

            var karty = new List<Karta>();

            foreach (var obrazek in obrazki)
            {
                var id = Guid.NewGuid();

                var karta1 = new Karta(id, obrazek);
                karty.Add(karta1);

                var karta2 = new Karta(id, obrazek);
                karty.Add(karta2);
            }

            return karty;
        }

        public void UzupelnijPanel()
        {
            var karty = GenerujKarty();
            var kolumny = 4;
            var wiersze = 4;
            Random generator = new Random();

            for (int x = 0; x < kolumny; x++)
            {
                for (int y = 0; y < wiersze; y++)
                {
                    var indeksKarty = generator.Next(0, karty.Count - 1);
                    var karta = karty[indeksKarty];
                    karta.Location = new Point(x * karta.Width, y * karta.Height);
                    karta.Click += KartaClicked;
                    panelGry.Controls.Add(karta);
                    karty.Remove(karta);
                }
            }
        }

        private void KartaClicked(object sender, EventArgs e)
        {
            var karta = (Karta)sender;
            MessageBox.Show(karta.Id.ToString());
            karta.Zakryj();
        }
    }
}