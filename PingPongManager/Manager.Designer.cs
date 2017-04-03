namespace PingPongManager
{
    partial class Manager
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sliderPn = new System.Windows.Forms.Panel();
            this.playersMs = new System.Windows.Forms.MenuStrip();
            this.playersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.leagueMs = new System.Windows.Forms.MenuStrip();
            this.leagueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.sliderPn.SuspendLayout();
            this.playersMs.SuspendLayout();
            this.leagueMs.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 83);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(178, 83);
            this.panel3.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(810, 476);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(151, 143);
            this.panel7.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 32);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(817, 395);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(148, 143);
            this.panel6.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(-1, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(811, 430);
            this.panel2.TabIndex = 1;
            // 
            // sliderPn
            // 
            this.sliderPn.BackColor = System.Drawing.Color.White;
            this.sliderPn.Controls.Add(this.pictureBox1);
            this.sliderPn.Controls.Add(this.playersMs);
            this.sliderPn.Controls.Add(this.leagueMs);
            this.sliderPn.Location = new System.Drawing.Point(810, 81);
            this.sliderPn.Name = "sliderPn";
            this.sliderPn.Size = new System.Drawing.Size(154, 398);
            this.sliderPn.TabIndex = 4;
            // 
            // playersMs
            // 
            this.playersMs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.playersMs.AutoSize = false;
            this.playersMs.BackColor = System.Drawing.Color.Gainsboro;
            this.playersMs.Dock = System.Windows.Forms.DockStyle.None;
            this.playersMs.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.playersMs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playersToolStripMenuItem2,
            this.playersToolStripMenuItem1});
            this.playersMs.Location = new System.Drawing.Point(7, 62);
            this.playersMs.Name = "playersMs";
            this.playersMs.Size = new System.Drawing.Size(136, 28);
            this.playersMs.TabIndex = 7;
            this.playersMs.Text = "Players";
            // 
            // playersToolStripMenuItem1
            // 
            this.playersToolStripMenuItem1.Name = "playersToolStripMenuItem1";
            this.playersToolStripMenuItem1.Size = new System.Drawing.Size(12, 24);
            // 
            // leagueMs
            // 
            this.leagueMs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.leagueMs.AutoSize = false;
            this.leagueMs.BackColor = System.Drawing.Color.Gainsboro;
            this.leagueMs.Dock = System.Windows.Forms.DockStyle.None;
            this.leagueMs.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.leagueMs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leagueToolStripMenuItem});
            this.leagueMs.Location = new System.Drawing.Point(7, 104);
            this.leagueMs.Name = "leagueMs";
            this.leagueMs.Size = new System.Drawing.Size(136, 28);
            this.leagueMs.TabIndex = 8;
            this.leagueMs.Text = "League";
            // 
            // leagueToolStripMenuItem
            // 
            this.leagueToolStripMenuItem.AutoSize = false;
            this.leagueToolStripMenuItem.Name = "leagueToolStripMenuItem";
            this.leagueToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.leagueToolStripMenuItem.Text = "League";
            // 
            // playersToolStripMenuItem
            // 
            this.playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            this.playersToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // playersToolStripMenuItem2
            // 
            this.playersToolStripMenuItem2.AutoSize = false;
            this.playersToolStripMenuItem2.Name = "playersToolStripMenuItem2";
            this.playersToolStripMenuItem2.Size = new System.Drawing.Size(67, 24);
            this.playersToolStripMenuItem2.Text = "Players";
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 619);
            this.Controls.Add(this.sliderPn);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Manager";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.sliderPn.ResumeLayout(false);
            this.playersMs.ResumeLayout(false);
            this.playersMs.PerformLayout();
            this.leagueMs.ResumeLayout(false);
            this.leagueMs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel sliderPn;
        private System.Windows.Forms.ToolStripMenuItem playersToolStripMenuItem;
        private System.Windows.Forms.MenuStrip playersMs;
        private System.Windows.Forms.ToolStripMenuItem playersToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip leagueMs;
        private System.Windows.Forms.ToolStripMenuItem leagueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playersToolStripMenuItem2;
    }
}

