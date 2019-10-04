/*
 * Created by: Kaelan Khan
 * Created on: 17-09-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 - 
 * This program takes a users input of length and width to calculate the perimeter and the area.
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

namespace AreaPerFormKaelanK
{
    
    public partial class frmAreaPer : Form
    {
        public frmAreaPer()
        {
            InitializeComponent();

            // hiding labels
            this.lblAreaAns.Hide();
            this.lblPerAns.Hide();
            this.lblAns1.Hide();
            this.lblAns2.Hide();

        }

        private void LblLength_Click(object sender, EventArgs e)
        {

        }

        private void LblPerAns_Click(object sender, EventArgs e)
        {

        }

        private void LblAreaAns_Click(object sender, EventArgs e)
        {

        }

        private void LblAns1_Click(object sender, EventArgs e)
        {
            
        }

        private void LblAns2_Click(object sender, EventArgs e)
        {

        }

        // calculates the area and perimeter with users input
        private void BtnCalculate_Click(object sender, EventArgs e)
        {

            // setting variables
            double length, width, area, perimeter;

            length = double.Parse(txtLength.Text);

            width = double.Parse(txtWidth.Text);

            area = length * width;

            perimeter = length * 2 + width * 2;

            // showing labels
            this.lblAreaAns.Show();
            this.lblPerAns.Show();
            this.lblAns1.Show();
            this.lblAns2.Show();

            // converting to string
            this.lblAns1.Text = Convert.ToString(perimeter + " m");
            this.lblAns2.Text = Convert.ToString(area + " m²");
        }

        private void TxtLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtWidth_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
