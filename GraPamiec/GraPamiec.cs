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
        public Karta karta1;
        public Karta karta2;

        public GraPamiec()
        {
            InitializeComponent();
            UzupelnijPanel();
            panelGry.Enabled = false;
            timerPodglad.Start();
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

            if (karta1 == null)
            {
                karta1 = karta;
                karta1.Odkryj();
                karta1.Enabled = false;
            }
            else
            {
                karta2 = karta;
                karta2.Odkryj();
                karta2.Enabled = false;

                if (karta1.Id == karta2.Id)
                {
                    karta1 = null;
                    karta2 = null;
                }
                else
                {
                    panelGry.Enabled = false;
                    timerZakrywacz.Start();
                }
            }

        }

        private void timerPodglad_Tick(object sender, EventArgs e)
        {
            foreach (var kontrolka in panelGry.Controls)
            {
                var karta = (Karta)kontrolka;
                karta.Zakryj();
            }

            timerPodglad.Stop();

            panelGry.Enabled = true;
        }

        private void timerZakrywacz_Tick(object sender, EventArgs e)
        {
            karta1.Enabled = true;
            karta2.Enabled = true;

            karta1.Zakryj();
            karta2.Zakryj();

            karta1 = null;
            karta2 = null;

            timerZakrywacz.Stop();

            panelGry.Enabled = true;
        }
    }
}