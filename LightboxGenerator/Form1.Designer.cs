
namespace LightboxGenerator
{
    partial class Window
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
            this.quitbo = new System.Windows.Forms.Panel();
            this.quitbox = new System.Windows.Forms.Label();
            this.downloadtemplate = new System.Windows.Forms.Button();
            this.quitbo.SuspendLayout();
            this.SuspendLayout();
            // 
            // quitbo
            // 
            this.quitbo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quitbo.Controls.Add(this.quitbox);
            this.quitbo.Dock = System.Windows.Forms.DockStyle.Top;
            this.quitbo.Location = new System.Drawing.Point(0, 0);
            this.quitbo.Name = "quitbo";
            this.quitbo.Size = new System.Drawing.Size(884, 37);
            this.quitbo.TabIndex = 0;
            // 
            // quitbox
            // 
            this.quitbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.quitbox.AutoSize = true;
            this.quitbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitbox.ForeColor = System.Drawing.Color.White;
            this.quitbox.Location = new System.Drawing.Point(852, 9);
            this.quitbox.Name = "quitbox";
            this.quitbox.Size = new System.Drawing.Size(20, 21);
            this.quitbox.TabIndex = 0;
            this.quitbox.Text = "X";
            this.quitbox.Click += new System.EventHandler(this.quitbox_Click);
            // 
            // downloadtemplate
            // 
            this.downloadtemplate.BackColor = System.Drawing.Color.Silver;
            this.downloadtemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downloadtemplate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.downloadtemplate.FlatAppearance.BorderSize = 0;
            this.downloadtemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadtemplate.Location = new System.Drawing.Point(12, 414);
            this.downloadtemplate.Name = "downloadtemplate";
            this.downloadtemplate.Size = new System.Drawing.Size(125, 35);
            this.downloadtemplate.TabIndex = 1;
            this.downloadtemplate.Text = "Download template";
            this.downloadtemplate.UseVisualStyleBackColor = false;
            this.downloadtemplate.Click += new System.EventHandler(this.downloadtemplate_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.ControlBox = false;
            this.Controls.Add(this.downloadtemplate);
            this.Controls.Add(this.quitbo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Euro Truck Simulator 2 Lightbox maker";
            this.quitbo.ResumeLayout(false);
            this.quitbo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel quitbo;
        private System.Windows.Forms.Label quitbox;
        private System.Windows.Forms.Button downloadtemplate;
    }
}

