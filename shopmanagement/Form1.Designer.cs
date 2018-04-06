namespace shopmanagement
{
    partial class Form1
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
            this.uidtext = new System.Windows.Forms.TextBox();
            this.passtext = new System.Windows.Forms.TextBox();
            this.loginline = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.passline = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.loginbtn = new System.Windows.Forms.Button();
            this.titlelable = new System.Windows.Forms.Label();
            this.passwordpicture = new System.Windows.Forms.PictureBox();
            this.userpicture = new System.Windows.Forms.PictureBox();
            this.minimizebtn = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.logopicture = new System.Windows.Forms.PictureBox();
            this.loginline.SuspendLayout();
            this.passline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logopicture)).BeginInit();
            this.SuspendLayout();
            // 
            // uidtext
            // 
            this.uidtext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uidtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uidtext.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uidtext.ForeColor = System.Drawing.Color.Silver;
            this.uidtext.Location = new System.Drawing.Point(46, 197);
            this.uidtext.MaxLength = 100;
            this.uidtext.Name = "uidtext";
            this.uidtext.Size = new System.Drawing.Size(235, 33);
            this.uidtext.TabIndex = 1;
            this.uidtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uidtext.Enter += new System.EventHandler(this.uidtext_Enter);
            this.uidtext.Leave += new System.EventHandler(this.uidtext_Leave);
            // 
            // passtext
            // 
            this.passtext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passtext.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtext.ForeColor = System.Drawing.Color.Silver;
            this.passtext.Location = new System.Drawing.Point(46, 259);
            this.passtext.MaxLength = 100;
            this.passtext.Name = "passtext";
            this.passtext.Size = new System.Drawing.Size(235, 32);
            this.passtext.TabIndex = 2;
            this.passtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passtext.UseSystemPasswordChar = true;
            this.passtext.Enter += new System.EventHandler(this.passtext_Enter);
            this.passtext.Leave += new System.EventHandler(this.passtext_Leave);
            // 
            // loginline
            // 
            this.loginline.BackColor = System.Drawing.Color.Honeydew;
            this.loginline.Controls.Add(this.panel2);
            this.loginline.Location = new System.Drawing.Point(23, 230);
            this.loginline.Name = "loginline";
            this.loginline.Size = new System.Drawing.Size(260, 2);
            this.loginline.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 66);
            this.panel2.TabIndex = 4;
            // 
            // passline
            // 
            this.passline.BackColor = System.Drawing.Color.Honeydew;
            this.passline.Controls.Add(this.panel4);
            this.passline.Location = new System.Drawing.Point(23, 292);
            this.passline.Name = "passline";
            this.passline.Size = new System.Drawing.Size(260, 2);
            this.passline.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Honeydew;
            this.panel4.Location = new System.Drawing.Point(0, 59);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 66);
            this.panel4.TabIndex = 4;
            // 
            // loginbtn
            // 
            this.loginbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginbtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.loginbtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.loginbtn.FlatAppearance.BorderSize = 0;
            this.loginbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.loginbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.loginbtn.Location = new System.Drawing.Point(23, 333);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(250, 40);
            this.loginbtn.TabIndex = 5;
            this.loginbtn.Text = "LOGIN";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // titlelable
            // 
            this.titlelable.AutoSize = true;
            this.titlelable.Font = new System.Drawing.Font("Ed Wood Movies", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelable.ForeColor = System.Drawing.Color.MintCream;
            this.titlelable.Location = new System.Drawing.Point(78, 144);
            this.titlelable.Name = "titlelable";
            this.titlelable.Size = new System.Drawing.Size(149, 26);
            this.titlelable.TabIndex = 8;
            this.titlelable.Text = "Stock Manager";
            // 
            // passwordpicture
            // 
            this.passwordpicture.Image = global::shopmanagement.Properties.Resources.pass;
            this.passwordpicture.Location = new System.Drawing.Point(23, 269);
            this.passwordpicture.Name = "passwordpicture";
            this.passwordpicture.Size = new System.Drawing.Size(20, 20);
            this.passwordpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passwordpicture.TabIndex = 10;
            this.passwordpicture.TabStop = false;
            // 
            // userpicture
            // 
            this.userpicture.Image = global::shopmanagement.Properties.Resources.userid;
            this.userpicture.Location = new System.Drawing.Point(23, 207);
            this.userpicture.Name = "userpicture";
            this.userpicture.Size = new System.Drawing.Size(20, 20);
            this.userpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userpicture.TabIndex = 9;
            this.userpicture.TabStop = false;
            // 
            // minimizebtn
            // 
            this.minimizebtn.BackgroundImage = global::shopmanagement.Properties.Resources.minimize;
            this.minimizebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minimizebtn.FlatAppearance.BorderSize = 0;
            this.minimizebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.minimizebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.minimizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizebtn.Location = new System.Drawing.Point(256, 3);
            this.minimizebtn.Name = "minimizebtn";
            this.minimizebtn.Size = new System.Drawing.Size(20, 20);
            this.minimizebtn.TabIndex = 7;
            this.minimizebtn.UseVisualStyleBackColor = true;
            this.minimizebtn.Click += new System.EventHandler(this.minimizebtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.BackgroundImage = global::shopmanagement.Properties.Resources.close;
            this.closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closebtn.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.closebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Location = new System.Drawing.Point(277, 3);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(20, 20);
            this.closebtn.TabIndex = 6;
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // logopicture
            // 
            this.logopicture.Image = global::shopmanagement.Properties.Resources.box;
            this.logopicture.Location = new System.Drawing.Point(74, 3);
            this.logopicture.Name = "logopicture";
            this.logopicture.Size = new System.Drawing.Size(150, 150);
            this.logopicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logopicture.TabIndex = 0;
            this.logopicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.passwordpicture);
            this.Controls.Add(this.userpicture);
            this.Controls.Add(this.titlelable);
            this.Controls.Add(this.minimizebtn);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.passline);
            this.Controls.Add(this.loginline);
            this.Controls.Add(this.passtext);
            this.Controls.Add(this.uidtext);
            this.Controls.Add(this.logopicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.loginline.ResumeLayout(false);
            this.passline.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.passwordpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logopicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logopicture;
        private System.Windows.Forms.TextBox uidtext;
        private System.Windows.Forms.TextBox passtext;
        private System.Windows.Forms.Panel loginline;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel passline;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Button minimizebtn;
        private System.Windows.Forms.Label titlelable;
        private System.Windows.Forms.PictureBox userpicture;
        private System.Windows.Forms.PictureBox passwordpicture;
    }
}

