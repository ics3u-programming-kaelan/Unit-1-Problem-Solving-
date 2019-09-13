using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsTeamsKaelanK
{
    public partial class frmSportsTeams : Form
    {
        public frmSportsTeams()
        {
            InitializeComponent();
        }

        private void MniBasketball_Click(object sender, EventArgs e)
        {
            this.lblSportName = "Toronto";
        }

        private void MniFootball_Click(object sender, EventArgs e)
        {

        }

        private void MniSoccer_Click(object sender, EventArgs e)
        {

        }

        private void MniPaintball_Click(object sender, EventArgs e)
        {

        }
    }
}
