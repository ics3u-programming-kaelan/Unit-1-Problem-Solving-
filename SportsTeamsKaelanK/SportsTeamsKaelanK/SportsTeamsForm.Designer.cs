namespace SportsTeamsKaelanK
{
    partial class frmSportsTeams
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
            this.components = new System.ComponentModel.Container();
            this.mnuSports = new System.Windows.Forms.MenuStrip();
            this.mniSports = new System.Windows.Forms.ToolStripMenuItem();
            this.mniBasketball = new System.Windows.Forms.ToolStripMenuItem();
            this.mniFootball = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSoccer = new System.Windows.Forms.ToolStripMenuItem();
            this.mniPaintball = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grbLabels = new System.Windows.Forms.GroupBox();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.lblSportName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnuSports.SuspendLayout();
            this.grbLabels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuSports
            // 
            this.mnuSports.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSports});
            this.mnuSports.Location = new System.Drawing.Point(0, 0);
            this.mnuSports.Name = "mnuSports";
            this.mnuSports.Size = new System.Drawing.Size(800, 24);
            this.mnuSports.TabIndex = 0;
            // 
            // mniSports
            // 
            this.mniSports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniBasketball,
            this.mniFootball,
            this.mniSoccer,
            this.mniPaintball});
            this.mniSports.Name = "mniSports";
            this.mniSports.Size = new System.Drawing.Size(52, 20);
            this.mniSports.Text = "Sports";
            // 
            // mniBasketball
            // 
            this.mniBasketball.Name = "mniBasketball";
            this.mniBasketball.Size = new System.Drawing.Size(127, 22);
            this.mniBasketball.Text = "Basketball";
            this.mniBasketball.Click += new System.EventHandler(this.MniBasketball_Click);
            // 
            // mniFootball
            // 
            this.mniFootball.Name = "mniFootball";
            this.mniFootball.Size = new System.Drawing.Size(127, 22);
            this.mniFootball.Text = "Football";
            this.mniFootball.Click += new System.EventHandler(this.MniFootball_Click);
            // 
            // mniSoccer
            // 
            this.mniSoccer.Name = "mniSoccer";
            this.mniSoccer.Size = new System.Drawing.Size(127, 22);
            this.mniSoccer.Text = "Soccer";
            this.mniSoccer.Click += new System.EventHandler(this.MniSoccer_Click);
            // 
            // mniPaintball
            // 
            this.mniPaintball.Name = "mniPaintball";
            this.mniPaintball.Size = new System.Drawing.Size(127, 22);
            this.mniPaintball.Text = "Paintball";
            this.mniPaintball.Click += new System.EventHandler(this.MniPaintball_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // grbLabels
            // 
            this.grbLabels.Controls.Add(this.pictureBox1);
            this.grbLabels.Controls.Add(this.lblTeamName);
            this.grbLabels.Controls.Add(this.lblSportName);
            this.grbLabels.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLabels.Location = new System.Drawing.Point(101, 121);
            this.grbLabels.Name = "grbLabels";
            this.grbLabels.Size = new System.Drawing.Size(451, 243);
            this.grbLabels.TabIndex = 2;
            this.grbLabels.TabStop = false;
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Font = new System.Drawing.Font("Verdana", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamName.Location = new System.Drawing.Point(7, 117);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(213, 52);
            this.lblTeamName.TabIndex = 1;
            this.lblTeamName.Text = "Raptors";
            // 
            // lblSportName
            // 
            this.lblSportName.AutoSize = true;
            this.lblSportName.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSportName.Location = new System.Drawing.Point(6, 27);
            this.lblSportName.Name = "lblSportName";
            this.lblSportName.Size = new System.Drawing.Size(206, 59);
            this.lblSportName.TabIndex = 0;
            this.lblSportName.Text = "Toronto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(223, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 185);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmSportsTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbLabels);
            this.Controls.Add(this.mnuSports);
            this.MainMenuStrip = this.mnuSports;
            this.Name = "frmSportsTeams";
            this.Text = "Sports and Teams";
            this.mnuSports.ResumeLayout(false);
            this.mnuSports.PerformLayout();
            this.grbLabels.ResumeLayout(false);
            this.grbLabels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuSports;
        private System.Windows.Forms.ToolStripMenuItem mniSports;
        private System.Windows.Forms.ToolStripMenuItem mniBasketball;
        private System.Windows.Forms.ToolStripMenuItem mniFootball;
        private System.Windows.Forms.ToolStripMenuItem mniSoccer;
        private System.Windows.Forms.ToolStripMenuItem mniPaintball;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox grbLabels;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Label lblSportName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

