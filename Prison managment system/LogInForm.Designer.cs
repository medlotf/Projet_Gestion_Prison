namespace Prison_managment_system
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.idtext = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.loginbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.mdptext = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 521);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Integrity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Respect ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Correctional Excellence \r\n";
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(90, 91);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(167, 159);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(533, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 42);
            this.label4.TabIndex = 4;
            this.label4.Text = "Log In";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(410, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(410, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Password :";
            // 
            // idtext
            // 
            this.idtext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idtext.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.idtext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.idtext.HintForeColor = System.Drawing.Color.Empty;
            this.idtext.HintText = "Enter your ID :";
            this.idtext.isPassword = false;
            this.idtext.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.idtext.LineIdleColor = System.Drawing.Color.Black;
            this.idtext.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.idtext.LineThickness = 3;
            this.idtext.Location = new System.Drawing.Point(434, 204);
            this.idtext.Margin = new System.Windows.Forms.Padding(4);
            this.idtext.Name = "idtext";
            this.idtext.Size = new System.Drawing.Size(298, 40);
            this.idtext.TabIndex = 0;
            this.idtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // loginbtn
            // 
            this.loginbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.loginbtn.BackColor = System.Drawing.Color.SeaGreen;
            this.loginbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginbtn.BorderRadius = 0;
            this.loginbtn.ButtonText = "Log In";
            this.loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbtn.DisabledColor = System.Drawing.Color.Gray;
            this.loginbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.loginbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("loginbtn.Iconimage")));
            this.loginbtn.Iconimage_right = null;
            this.loginbtn.Iconimage_right_Selected = null;
            this.loginbtn.Iconimage_Selected = null;
            this.loginbtn.IconMarginLeft = 0;
            this.loginbtn.IconMarginRight = 0;
            this.loginbtn.IconRightVisible = true;
            this.loginbtn.IconRightZoom = 0D;
            this.loginbtn.IconVisible = true;
            this.loginbtn.IconZoom = 90D;
            this.loginbtn.IsTab = false;
            this.loginbtn.Location = new System.Drawing.Point(656, 410);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Normalcolor = System.Drawing.Color.SeaGreen;
            this.loginbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.loginbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.loginbtn.selected = false;
            this.loginbtn.Size = new System.Drawing.Size(106, 39);
            this.loginbtn.TabIndex = 2;
            this.loginbtn.Text = "Log In";
            this.loginbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginbtn.Textcolor = System.Drawing.Color.White;
            this.loginbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label7.Location = new System.Drawing.Point(829, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "x";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.loginbtn;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 25;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            this.bunifuElipse3.TargetControl = this.panel1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label8.Location = new System.Drawing.Point(797, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "-";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // mdptext
            // 
            this.mdptext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mdptext.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.mdptext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mdptext.HintForeColor = System.Drawing.Color.Empty;
            this.mdptext.HintText = "*";
            this.mdptext.isPassword = true;
            this.mdptext.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.mdptext.LineIdleColor = System.Drawing.Color.Black;
            this.mdptext.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.mdptext.LineThickness = 3;
            this.mdptext.Location = new System.Drawing.Point(434, 304);
            this.mdptext.Margin = new System.Windows.Forms.Padding(4);
            this.mdptext.Name = "mdptext";
            this.mdptext.Size = new System.Drawing.Size(298, 33);
            this.mdptext.TabIndex = 1;
            this.mdptext.Text = "a";
            this.mdptext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(861, 521);
            this.Controls.Add(this.mdptext);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.idtext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogInForm";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox idtext;
        private Bunifu.Framework.UI.BunifuFlatButton loginbtn;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox mdptext;
    }
}