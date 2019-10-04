/*
 * Created by: Kaelan K
 * Created on: 14-09-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - Moving Cat
 * This program changes the picture when the menu item is clicked
*/
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

        // closes form
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // changes picture to seattle uprising
        private void MniSeattleUprising_Click(object sender, EventArgs e)
        {
            this.picChangedPic.Image = Properties.Resources.seattleUprising;
        }

        // changes picture to ottawa redblacks
        private void MniOttawaRedblacks_Click(object sender, EventArgs e)
        {
            this.picChangedPic.Image = Properties.Resources.ottawaRedblacks;
        }

        // changes picture to toronto raptors
        private void MniTorontoRaptors_Click(object sender, EventArgs e)
        {
            this.picChangedPic.Image = Properties.Resources.torontoRaptors;
        }
    }
}
