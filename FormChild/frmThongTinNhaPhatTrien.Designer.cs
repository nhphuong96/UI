namespace HH
{
    partial class frmThongTinNhaPhatTrien
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
            this.Back = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.Back.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackgroundImage = global::HH.Properties.Resources._500_F_70405005_HSPK56xgomY3aYoetQArMuA1CdqoWXie___Copy;
            this.Back.Dock = System.Windows.Forms.DockStyle.None;
            this.Back.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4});
            this.Back.Location = new System.Drawing.Point(1322, 9);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 47);
            this.Back.TabIndex = 11;
            this.Back.Text = "menuStrip3";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.BackgroundImage = global::HH.Properties.Resources._500_F_70405005_HSPK56xgomY3aYoetQArMuA1CdqoWXie___Copy;
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem4.Image = global::HH.Properties.Resources.Windows_Close_Program_icon1;
            this.toolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(67, 43);
            this.toolStripMenuItem4.Text = ".";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1196, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 39);
            this.button1.TabIndex = 17;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmThongTinNhaPhatTrien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1237, 552);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Back);
            this.Name = "frmThongTinNhaPhatTrien";
            this.ShowIcon = false;
            this.Text = "Thông tin nhà phát triển";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Back.ResumeLayout(false);
            this.Back.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Back;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Button button1;

    }
}