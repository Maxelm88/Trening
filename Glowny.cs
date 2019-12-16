using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trening
{
    public partial class Glowny : Form
    {
        public Glowny()
        {
            InitializeComponent();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void maciejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaciejForm formMaciej = new MaciejForm(); //make new biznes contact form
            formMaciej.MdiParent = this;
            formMaciej.Show(); //show the new form
        }

        private void ewelinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EwelinaForm formEwelina = new EwelinaForm(); //make new biznes contact form
            formEwelina.MdiParent = this;
            formEwelina.Show(); //show the new form
        }
    }
}
