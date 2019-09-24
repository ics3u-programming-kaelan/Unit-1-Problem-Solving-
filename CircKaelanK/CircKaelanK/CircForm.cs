/*
 * Created by: Kaelan K
 * Created on: 19-09-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #11 - Circumference of a circle
 * This program takes the users radius and calculates the circumference
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

namespace CircKaelanK
{
    public partial class frmCirc : Form
    {
        public frmCirc()
        {
            InitializeComponent();

            // hiding labels
            this.lblCirc.Hide();
            this.lblCircAns.Hide();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtRadius_TextChanged(object sender, EventArgs e)
        {

        }

        // calculate the circumference with radius
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // defining var
            double radius, circ;

            // converting txtbox to double
            radius = double.Parse(txtRadius.Text);

            // calculating the circumference
            circ = 3.14 * Math.Pow(radius, 2);

            // converting double back to text
            this.lblCircAns.Text = Convert.ToString(circ + " cm");

            // showing labels again
            this.lblCirc.Show();
            this.lblCircAns.Show();

        }
    }
}
