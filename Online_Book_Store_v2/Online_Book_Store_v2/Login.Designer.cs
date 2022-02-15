namespace Online_Book_Store_v2
{
    partial class Login
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblŞifre = new System.Windows.Forms.Label();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxŞifre = new System.Windows.Forms.TextBox();
            this.btnGiriş = new System.Windows.Forms.Button();
            this.btnÜyeol = new System.Windows.Forms.Button();
            this.lblUyarı = new System.Windows.Forms.Label();
            this.pnlÜst = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbŞifreGöster = new System.Windows.Forms.PictureBox();
            this.pnlÜst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbŞifreGöster)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.Location = new System.Drawing.Point(12, 211);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(69, 20);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-posta:";
            // 
            // lblŞifre
            // 
            this.lblŞifre.AutoSize = true;
            this.lblŞifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblŞifre.Location = new System.Drawing.Point(35, 249);
            this.lblŞifre.Name = "lblŞifre";
            this.lblŞifre.Size = new System.Drawing.Size(46, 20);
            this.lblŞifre.TabIndex = 1;
            this.lblŞifre.Text = "Şifre:";
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxEmail.Location = new System.Drawing.Point(87, 208);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(147, 26);
            this.txtboxEmail.TabIndex = 2;
            // 
            // txtBoxŞifre
            // 
            this.txtBoxŞifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxŞifre.Location = new System.Drawing.Point(88, 246);
            this.txtBoxŞifre.Name = "txtBoxŞifre";
            this.txtBoxŞifre.PasswordChar = '*';
            this.txtBoxŞifre.Size = new System.Drawing.Size(147, 26);
            this.txtBoxŞifre.TabIndex = 3;
            // 
            // btnGiriş
            // 
            this.btnGiriş.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiriş.Location = new System.Drawing.Point(58, 294);
            this.btnGiriş.Name = "btnGiriş";
            this.btnGiriş.Size = new System.Drawing.Size(75, 31);
            this.btnGiriş.TabIndex = 4;
            this.btnGiriş.Text = "Giriş";
            this.btnGiriş.UseVisualStyleBackColor = true;
            this.btnGiriş.Click += new System.EventHandler(this.btnGiriş_Click);
            // 
            // btnÜyeol
            // 
            this.btnÜyeol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÜyeol.Location = new System.Drawing.Point(148, 294);
            this.btnÜyeol.Name = "btnÜyeol";
            this.btnÜyeol.Size = new System.Drawing.Size(75, 31);
            this.btnÜyeol.TabIndex = 5;
            this.btnÜyeol.Text = "Üye Ol";
            this.btnÜyeol.UseVisualStyleBackColor = true;
            this.btnÜyeol.Click += new System.EventHandler(this.btnÜyeol_Click);
            // 
            // lblUyarı
            // 
            this.lblUyarı.AutoSize = true;
            this.lblUyarı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyarı.ForeColor = System.Drawing.Color.Red;
            this.lblUyarı.Location = new System.Drawing.Point(12, 333);
            this.lblUyarı.Name = "lblUyarı";
            this.lblUyarı.Size = new System.Drawing.Size(0, 20);
            this.lblUyarı.TabIndex = 7;
            // 
            // pnlÜst
            // 
            this.pnlÜst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(23)))), ((int)(((byte)(176)))));
            this.pnlÜst.Controls.Add(this.label1);
            this.pnlÜst.Controls.Add(this.btn_minimize);
            this.pnlÜst.Controls.Add(this.btn_close);
            this.pnlÜst.Location = new System.Drawing.Point(0, 0);
            this.pnlÜst.Name = "pnlÜst";
            this.pnlÜst.Size = new System.Drawing.Size(291, 29);
            this.pnlÜst.TabIndex = 9;
            this.pnlÜst.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlÜst_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Üye Girişi";
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(23)))), ((int)(((byte)(176)))));
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_minimize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_minimize.Image = global::Online_Book_Store_v2.Properties.Resources.minimize_window_24;
            this.btn_minimize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_minimize.Location = new System.Drawing.Point(218, 3);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(33, 23);
            this.btn_minimize.TabIndex = 11;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(23)))), ((int)(((byte)(176)))));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_close.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_close.Image = global::Online_Book_Store_v2.Properties.Resources.x_mark_5_24;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(257, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(31, 29);
            this.btn_close.TabIndex = 10;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Online_Book_Store_v2.Properties.Resources.ooploginbackg1;
            this.pbLogo.Location = new System.Drawing.Point(0, 26);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(302, 182);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 8;
            this.pbLogo.TabStop = false;
            // 
            // pbŞifreGöster
            // 
            this.pbŞifreGöster.Image = global::Online_Book_Store_v2.Properties.Resources.eyeico;
            this.pbŞifreGöster.Location = new System.Drawing.Point(241, 250);
            this.pbŞifreGöster.Name = "pbŞifreGöster";
            this.pbŞifreGöster.Size = new System.Drawing.Size(23, 19);
            this.pbŞifreGöster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbŞifreGöster.TabIndex = 6;
            this.pbŞifreGöster.TabStop = false;
            this.pbŞifreGöster.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbŞifreGöster_MouseDown_1);
            this.pbŞifreGöster.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbŞifreGöster_MouseUp_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 367);
            this.Controls.Add(this.pnlÜst);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblUyarı);
            this.Controls.Add(this.pbŞifreGöster);
            this.Controls.Add(this.btnÜyeol);
            this.Controls.Add(this.btnGiriş);
            this.Controls.Add(this.txtBoxŞifre);
            this.Controls.Add(this.txtboxEmail);
            this.Controls.Add(this.lblŞifre);
            this.Controls.Add(this.lblEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Girişi";
            this.Shown += new System.EventHandler(this.Login_Shown);
            this.pnlÜst.ResumeLayout(false);
            this.pnlÜst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbŞifreGöster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblŞifre;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.TextBox txtBoxŞifre;
        private System.Windows.Forms.Button btnGiriş;
        private System.Windows.Forms.Button btnÜyeol;
        private System.Windows.Forms.PictureBox pbŞifreGöster;
        private System.Windows.Forms.Label lblUyarı;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pnlÜst;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Label label1;
    }
}