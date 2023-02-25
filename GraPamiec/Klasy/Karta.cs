using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GraPamiec.Klasy
{
    public class Karta : Label
    {
        public Guid Id;
        public Image Obrazek;

        public Karta(Guid id, Image obrazek) : base()
        {
            Id = id;
            Obrazek = obrazek;
            Width = 150;
            Height = 150;
            BackgroundImage = obrazek;
            BackgroundImageLayout = ImageLayout.Stretch;
            BorderStyle = BorderStyle.FixedSingle;
        }

        public void Zakryj()
        {
            BackgroundImage = ObrazkiRepozytorium.PobierzLogo();
        }

        public void Odkryj()
        {
            BackgroundImage = Obrazek;
        }
    }
}