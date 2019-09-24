/*
 * Created by: Kaelan K
 * Created on: 24-09-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #12 - Pizza Cost
 * This program calculates the cost of pizza with a given diameter and the tax
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

namespace PizzaCostKaelanK
{
    public partial class frmPizzaCost : Form
    {
        public frmPizzaCost()
        {
            InitializeComponent();
        }

        private void FrmPizzaCost_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double diameter, costBeforeTax, costAfterTax;

            // convert the diameter to double
            diameter = double.Parse(txtDiameter.Text);

            // calculate cost before and after tax
            costBeforeTax = 0.75 + 0.99 + 0.50 * diameter;

            costAfterTax = costBeforeTax * 1.13;

            // display the cost as a label and rounded to two decimals
            lblCostAns.Text = String.Format("${0:0.00}", costAfterTax);
                
        }
    }

}