namespace AreaPerFormKaelanK
{
    partial class frmAreaPer
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
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblPerAns = new System.Windows.Forms.Label();
            this.lblAreaAns = new System.Windows.Forms.Label();
            this.lblAns1 = new System.Windows.Forms.Label();
            this.lblAns2 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(62, 73);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(172, 37);
            this.lblLength.TabIndex = 4;
            this.lblLength.Text = "Length (M)";
            this.lblLength.Click += new System.EventHandler(this.LblLength_Click);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(62, 171);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(157, 37);
            this.lblWidth.TabIndex = 5;
            this.lblWidth.Text = "Width (M)";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(529, 120);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(140, 54);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lblPerAns
            // 
            this.lblPerAns.AutoSize = true;
            this.lblPerAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerAns.Location = new System.Drawing.Point(63, 269);
            this.lblPerAns.Name = "lblPerAns";
            this.lblPerAns.Size = new System.Drawing.Size(130, 31);
            this.lblPerAns.TabIndex = 7;
            this.lblPerAns.Text = "Perimiter:";
            this.lblPerAns.Click += new System.EventHandler(this.LblPerAns_Click);
            // 
            // lblAreaAns
            // 
            this.lblAreaAns.AutoSize = true;
            this.lblAreaAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaAns.Location = new System.Drawing.Point(66, 337);
            this.lblAreaAns.Name = "lblAreaAns";
            this.lblAreaAns.Size = new System.Drawing.Size(86, 31);
            this.lblAreaAns.TabIndex = 8;
            this.lblAreaAns.Text = "Area: ";
            this.lblAreaAns.Click += new System.EventHandler(this.LblAreaAns_Click);
            // 
            // lblAns1
            // 
            this.lblAns1.AutoSize = true;
            this.lblAns1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAns1.Location = new System.Drawing.Point(270, 269);
            this.lblAns1.Name = "lblAns1";
            this.lblAns1.Size = new System.Drawing.Size(59, 31);
            this.lblAns1.TabIndex = 9;
            this.lblAns1.Text = "???";
            this.lblAns1.Click += new System.EventHandler(this.LblAns1_Click);
            // 
            // lblAns2
            // 
            this.lblAns2.AutoSize = true;
            this.lblAns2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAns2.Location = new System.Drawing.Point(270, 337);
            this.lblAns2.Name = "lblAns2";
            this.lblAns2.Size = new System.Drawing.Size(59, 31);
            this.lblAns2.TabIndex = 10;
            this.lblAns2.Text = "???";
            this.lblAns2.Click += new System.EventHandler(this.LblAns2_Click);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(276, 88);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(131, 20);
            this.txtLength.TabIndex = 11;
            this.txtLength.TextChanged += new System.EventHandler(this.TxtLength_TextChanged);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(276, 186);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(131, 20);
            this.txtWidth.TabIndex = 12;
            this.txtWidth.TextChanged += new System.EventHandler(this.TxtWidth_TextChanged);
            // 
            // frmAreaPer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblAns2);
            this.Controls.Add(this.lblAns1);
            this.Controls.Add(this.lblAreaAns);
            this.Controls.Add(this.lblPerAns);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Name = "frmAreaPer";
            this.Text = "Area and Perimeter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblPerAns;
        private System.Windows.Forms.Label lblAreaAns;
        private System.Windows.Forms.Label lblAns1;
        private System.Windows.Forms.Label lblAns2;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
    }
}

