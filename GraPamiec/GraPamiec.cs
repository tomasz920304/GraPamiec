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

        public void UzupelnijPanel()
        {
            var karta = new Karta(Guid.Empty, ObrazkiRepozytorium.PobierzObrazki()[0]);

            karta.Location = new Point(0, 0);

            karta.Zakryj();

            panelGry.Controls.Add(karta);
        }
    }
}