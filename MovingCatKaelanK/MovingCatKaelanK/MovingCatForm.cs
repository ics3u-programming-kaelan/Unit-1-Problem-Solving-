using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingCatKaelanK
{
    public partial class frmMovingCat : Form
    {
        public frmMovingCat()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MniSeattleUprising_Click(object sender, EventArgs e)
        {
            this.picChangedPic.Image = Properties.Resources.seattleUprising;
        }

        private void MniOttawaRedblacks_Click(object sender, EventArgs e)
        {
            this.picChangedPic.Image = Properties.Resources.ottawaRedblacks;
        }

        private void MniTorontoRaptors_Click(object sender, EventArgs e)
        {
            this.picChangedPic.Image = Properties.Resources.torontoRaptors;
        }
    }
}
