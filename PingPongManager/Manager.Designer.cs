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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userControlPn = new System.Windows.Forms.Panel();
            this.sliderPn = new System.Windows.Forms.Panel();
            this.playersBt = new System.Windows.Forms.Button();
            this.playersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sliderPn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 80);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(13, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(165, 59);
            this.panel3.TabIndex = 0;
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
            // userControlPn
            // 
            this.userControlPn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userControlPn.BackColor = System.Drawing.Color.Transparent;
            this.userControlPn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userControlPn.Location = new System.Drawing.Point(184, 83);
            this.userControlPn.Name = "userControlPn";
            this.userControlPn.Size = new System.Drawing.Size(824, 510);
            this.userControlPn.TabIndex = 1;
            // 
            // sliderPn
            // 
            this.sliderPn.BackColor = System.Drawing.Color.White;
            this.sliderPn.Controls.Add(this.pictureBox1);
            this.sliderPn.Controls.Add(this.playersBt);
            this.sliderPn.Dock = System.Windows.Forms.DockStyle.Left;
            this.sliderPn.Location = new System.Drawing.Point(0, 80);
            this.sliderPn.Name = "sliderPn";
            this.sliderPn.Size = new System.Drawing.Size(178, 597);
            this.sliderPn.TabIndex = 4;
            // 
            // playersBt
            // 
            this.playersBt.Image = ((System.Drawing.Image)(resources.GetObject("playersBt.Image")));
            this.playersBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.playersBt.Location = new System.Drawing.Point(0, 49);
            this.playersBt.Name = "playersBt";
            this.playersBt.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.playersBt.Size = new System.Drawing.Size(178, 37);
            this.playersBt.TabIndex = 9;
            this.playersBt.Text = "Players";
            this.playersBt.UseVisualStyleBackColor = true;
            this.playersBt.Click += new System.EventHandler(this.onClick);
            // 
            // playersToolStripMenuItem
            // 
            this.playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            this.playersToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 677);
            this.Controls.Add(this.userControlPn);
            this.Controls.Add(this.sliderPn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Manager";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sliderPn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel userControlPn;
        private System.Windows.Forms.Panel sliderPn;
        private System.Windows.Forms.ToolStripMenuItem playersToolStripMenuItem;
        private System.Windows.Forms.Button playersBt;
    }
}

