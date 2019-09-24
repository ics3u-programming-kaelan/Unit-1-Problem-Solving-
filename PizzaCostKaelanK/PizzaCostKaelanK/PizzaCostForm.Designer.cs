namespace PizzaCostKaelanK
{
    partial class frmPizzaCost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDiameter = new System.Windows.Forms.Label();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblCostAns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDiameter
            // 
            this.lblDiameter.AutoSize = true;
            this.lblDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiameter.Location = new System.Drawing.Point(12, 48);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(361, 24);
            this.lblDiameter.TabIndex = 0;
            this.lblDiameter.Text = "Enter the diameter of the pizza (in inches):";
            // 
            // txtDiameter
            // 
            this.txtDiameter.Location = new System.Drawing.Point(379, 52);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(100, 20);
            this.txtDiameter.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(16, 108);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(463, 33);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate Cost";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(13, 188);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(229, 24);
            this.lblCost.TabIndex = 3;
            this.lblCost.Text = "The cost (including tax) is:";
            // 
            // lblCostAns
            // 
            this.lblCostAns.AutoSize = true;
            this.lblCostAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostAns.Location = new System.Drawing.Point(260, 188);
            this.lblCostAns.Name = "lblCostAns";
            this.lblCostAns.Size = new System.Drawing.Size(40, 24);
            this.lblCostAns.TabIndex = 4;
            this.lblCostAns.Text = "???";
            // 
            // frmPizzaCost
            // 
            this.ClientSize = new System.Drawing.Size(587, 341);
            this.Controls.Add(this.lblCostAns);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtDiameter);
            this.Controls.Add(this.lblDiameter);
            this.Name = "frmPizzaCost";
            this.Text = "Pizza Cost Kaelan K";
            this.Load += new System.EventHandler(this.FrmPizzaCost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.TextBox txtDiameter;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblCostAns;
    }
}

