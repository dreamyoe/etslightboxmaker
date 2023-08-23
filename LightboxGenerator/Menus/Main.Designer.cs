
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
            this.modname = new System.Windows.Forms.TextBox();
            this.modauthor = new System.Windows.Forms.TextBox();
            this.moddescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.currenttruck = new System.Windows.Forms.Label();
            this.quitbo.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // modname
            // 
            this.modname.BackColor = System.Drawing.Color.Silver;
            this.modname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modname.ForeColor = System.Drawing.Color.Black;
            this.modname.Location = new System.Drawing.Point(155, 125);
            this.modname.Name = "modname";
            this.modname.Size = new System.Drawing.Size(200, 13);
            this.modname.TabIndex = 2;
            this.modname.Text = "Mod Name";
            // 
            // modauthor
            // 
            this.modauthor.BackColor = System.Drawing.Color.Silver;
            this.modauthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modauthor.ForeColor = System.Drawing.Color.Black;
            this.modauthor.Location = new System.Drawing.Point(155, 144);
            this.modauthor.Name = "modauthor";
            this.modauthor.Size = new System.Drawing.Size(200, 13);
            this.modauthor.TabIndex = 3;
            this.modauthor.Text = "Mod Author";
            // 
            // moddescription
            // 
            this.moddescription.BackColor = System.Drawing.Color.Silver;
            this.moddescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.moddescription.ForeColor = System.Drawing.Color.Black;
            this.moddescription.Location = new System.Drawing.Point(155, 163);
            this.moddescription.Multiline = true;
            this.moddescription.Name = "moddescription";
            this.moddescription.Size = new System.Drawing.Size(200, 144);
            this.moddescription.TabIndex = 4;
            this.moddescription.Text = "Mod Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(181, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mod Info";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(155, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Select Truck";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.currenttruck);
            this.panel1.Location = new System.Drawing.Point(155, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 31);
            this.panel1.TabIndex = 8;
            // 
            // currenttruck
            // 
            this.currenttruck.AutoSize = true;
            this.currenttruck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currenttruck.Location = new System.Drawing.Point(0, 0);
            this.currenttruck.Name = "currenttruck";
            this.currenttruck.Size = new System.Drawing.Size(123, 13);
            this.currenttruck.TabIndex = 0;
            this.currenttruck.Text = "Current truck mod: None";
            this.currenttruck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.moddescription);
            this.Controls.Add(this.modauthor);
            this.Controls.Add(this.modname);
            this.Controls.Add(this.downloadtemplate);
            this.Controls.Add(this.quitbo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Euro Truck Simulator 2 Lightbox maker";
            this.quitbo.ResumeLayout(false);
            this.quitbo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel quitbo;
        private System.Windows.Forms.Label quitbox;
        private System.Windows.Forms.Button downloadtemplate;
        public System.Windows.Forms.TextBox modauthor;
        public System.Windows.Forms.TextBox modname;
        public System.Windows.Forms.TextBox moddescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label currenttruck;
    }
}

