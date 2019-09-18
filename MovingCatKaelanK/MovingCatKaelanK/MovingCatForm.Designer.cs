namespace MovingCatKaelanK
{
    partial class frmMovingCat
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
            this.picChangedPic = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSeattleUprising = new System.Windows.Forms.ToolStripMenuItem();
            this.mniOttawaRedblacks = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTorontoRaptors = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picChangedPic)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picChangedPic
            // 
            this.picChangedPic.Image = global::MovingCatKaelanK.Properties.Resources.torontoRaptors;
            this.picChangedPic.Location = new System.Drawing.Point(243, 135);
            this.picChangedPic.Name = "picChangedPic";
            this.picChangedPic.Size = new System.Drawing.Size(242, 202);
            this.picChangedPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChangedPic.TabIndex = 0;
            this.picChangedPic.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.teamsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // teamsToolStripMenuItem
            // 
            this.teamsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSeattleUprising,
            this.mniOttawaRedblacks,
            this.mniTorontoRaptors});
            this.teamsToolStripMenuItem.Name = "teamsToolStripMenuItem";
            this.teamsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.teamsToolStripMenuItem.Text = "Teams";
            // 
            // mniSeattleUprising
            // 
            this.mniSeattleUprising.Name = "mniSeattleUprising";
            this.mniSeattleUprising.Size = new System.Drawing.Size(180, 22);
            this.mniSeattleUprising.Text = "Seattle Uprising";
            this.mniSeattleUprising.Click += new System.EventHandler(this.MniSeattleUprising_Click);
            // 
            // mniOttawaRedblacks
            // 
            this.mniOttawaRedblacks.Name = "mniOttawaRedblacks";
            this.mniOttawaRedblacks.Size = new System.Drawing.Size(180, 22);
            this.mniOttawaRedblacks.Text = "Ottawa Redblacks";
            this.mniOttawaRedblacks.Click += new System.EventHandler(this.MniOttawaRedblacks_Click);
            // 
            // mniTorontoRaptors
            // 
            this.mniTorontoRaptors.Name = "mniTorontoRaptors";
            this.mniTorontoRaptors.Size = new System.Drawing.Size(180, 22);
            this.mniTorontoRaptors.Text = "Toronto Raptors";
            this.mniTorontoRaptors.Click += new System.EventHandler(this.MniTorontoRaptors_Click);
            // 
            // frmMovingCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picChangedPic);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMovingCat";
            this.Text = "Moving Cat";
            ((System.ComponentModel.ISupportInitialize)(this.picChangedPic)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picChangedPic;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniSeattleUprising;
        private System.Windows.Forms.ToolStripMenuItem mniOttawaRedblacks;
        private System.Windows.Forms.ToolStripMenuItem mniTorontoRaptors;
    }
}

