/*
 * Created by: Kaelan K
 * Created on: 16-09-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - Teams Cities and Names
 * This program displays the team city and the team name
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

namespace SportsTeamsKaelanK
{
    public partial class frmSportsTeams : Form
    {
        public frmSportsTeams()
        {
            InitializeComponent();
        }

        // when clicked changes labels to toronto and raptors
        private void MniBasketball_Click(object sender, EventArgs e)
        {
            this.lblSportName.Text = "Toronto";
            this.lblTeamName.Text = "Raptors";
            
        }

        // when clicked changes labels to ottawa and redblacks
        private void MniFootball_Click(object sender, EventArgs e)
        {
            this.lblSportName.Text = "Ottawa";
            this.lblTeamName.Text = "Redblacks";
        }

        // when clicked changes labels to manchester and united
        private void MniSoccer_Click(object sender, EventArgs e)
        {
            this.lblSportName.Text = "Manchester";
            this.lblTeamName.Text = "United";
        }

        // when clicked changes labels to seattle and uprising
        private void MniPaintball_Click(object sender, EventArgs e)
        {
            this.lblSportName.Text = "Seattle";
            this.lblTeamName.Text = "Uprising";
               
        }

    }
}
