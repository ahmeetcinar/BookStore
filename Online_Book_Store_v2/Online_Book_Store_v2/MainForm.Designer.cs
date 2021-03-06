namespace Online_Book_Store_v2
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShoppingCart = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btnUserAdmin = new System.Windows.Forms.Button();
            this.btnMagazine = new System.Windows.Forms.Button();
            this.btnMusicCd = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbSortBy = new System.Windows.Forms.ComboBox();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.flpnlShowItem = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnShoppingCart);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.btnUserAdmin);
            this.panel1.Controls.Add(this.btnMagazine);
            this.panel1.Controls.Add(this.btnMusicCd);
            this.panel1.Controls.Add(this.btnBook);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 720);
            this.panel1.TabIndex = 0;
            // 
            // btnShoppingCart
            // 
            this.btnShoppingCart.FlatAppearance.BorderSize = 0;
            this.btnShoppingCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoppingCart.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShoppingCart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnShoppingCart.Image = global::Online_Book_Store_v2.Properties.Resources.cart_72_24;
            this.btnShoppingCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShoppingCart.Location = new System.Drawing.Point(0, 358);
            this.btnShoppingCart.Margin = new System.Windows.Forms.Padding(4);
            this.btnShoppingCart.Name = "btnShoppingCart";
            this.btnShoppingCart.Size = new System.Drawing.Size(261, 63);
            this.btnShoppingCart.TabIndex = 10;
            this.btnShoppingCart.Text = "  Shopping Cart";
            this.btnShoppingCart.UseVisualStyleBackColor = true;
            this.btnShoppingCart.Click += new System.EventHandler(this.btnShoppingCart_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdmin.Image = global::Online_Book_Store_v2.Properties.Resources.administrator_24;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(0, 429);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(261, 63);
            this.btnAdmin.TabIndex = 9;
            this.btnAdmin.Text = "   ADMIN PANEL";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblName.Location = new System.Drawing.Point(37, 583);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(105, 23);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Ad Soyad";
            // 
            // btnUserAdmin
            // 
            this.btnUserAdmin.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnUserAdmin.FlatAppearance.BorderSize = 0;
            this.btnUserAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserAdmin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUserAdmin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUserAdmin.Image = global::Online_Book_Store_v2.Properties.Resources.settings_4_24;
            this.btnUserAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserAdmin.Location = new System.Drawing.Point(151, 646);
            this.btnUserAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserAdmin.Name = "btnUserAdmin";
            this.btnUserAdmin.Size = new System.Drawing.Size(44, 46);
            this.btnUserAdmin.TabIndex = 7;
            this.btnUserAdmin.UseVisualStyleBackColor = false;
            this.btnUserAdmin.Click += new System.EventHandler(this.btnUserAdmin_Click);
            // 
            // btnMagazine
            // 
            this.btnMagazine.FlatAppearance.BorderSize = 0;
            this.btnMagazine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMagazine.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMagazine.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMagazine.Image = global::Online_Book_Store_v2.Properties.Resources.magazine_24;
            this.btnMagazine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMagazine.Location = new System.Drawing.Point(0, 224);
            this.btnMagazine.Margin = new System.Windows.Forms.Padding(4);
            this.btnMagazine.Name = "btnMagazine";
            this.btnMagazine.Size = new System.Drawing.Size(261, 63);
            this.btnMagazine.TabIndex = 3;
            this.btnMagazine.Text = "   MAGAZINE";
            this.btnMagazine.UseVisualStyleBackColor = true;
            this.btnMagazine.Click += new System.EventHandler(this.btnMagazine_Click);
            // 
            // btnMusicCd
            // 
            this.btnMusicCd.FlatAppearance.BorderSize = 0;
            this.btnMusicCd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusicCd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusicCd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMusicCd.Image = global::Online_Book_Store_v2.Properties.Resources.cd_music;
            this.btnMusicCd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusicCd.Location = new System.Drawing.Point(0, 287);
            this.btnMusicCd.Margin = new System.Windows.Forms.Padding(4);
            this.btnMusicCd.Name = "btnMusicCd";
            this.btnMusicCd.Size = new System.Drawing.Size(261, 63);
            this.btnMusicCd.TabIndex = 2;
            this.btnMusicCd.Text = "   MUSIC / CD";
            this.btnMusicCd.UseVisualStyleBackColor = true;
            this.btnMusicCd.Click += new System.EventHandler(this.btnMusicCd_Click);
            // 
            // btnBook
            // 
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnBook.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBook.Image = global::Online_Book_Store_v2.Properties.Resources.books_24;
            this.btnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBook.Location = new System.Drawing.Point(0, 161);
            this.btnBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(261, 63);
            this.btnBook.TabIndex = 1;
            this.btnBook.Text = "BOOKS";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_home.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_home.Image = global::Online_Book_Store_v2.Properties.Resources.home_5_24;
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(0, 98);
            this.btn_home.Margin = new System.Windows.Forms.Padding(4);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(261, 63);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "HOME";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.btn_minimize);
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(265, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1068, 55);
            this.panel2.TabIndex = 1;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_minimize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_minimize.Image = global::Online_Book_Store_v2.Properties.Resources.minimize_window_24;
            this.btn_minimize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_minimize.Location = new System.Drawing.Point(941, 0);
            this.btn_minimize.Margin = new System.Windows.Forms.Padding(4);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(44, 52);
            this.btn_minimize.TabIndex = 5;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_close.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_close.Image = global::Online_Book_Store_v2.Properties.Resources.x_mark_5_24;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(993, 0);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(44, 52);
            this.btn_close.TabIndex = 4;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(288, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 235);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(64, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "BOOKSHOP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(41, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "ESOGU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Online_Book_Store_v2.Properties.Resources.Esogu_logo;
            this.pictureBox1.Location = new System.Drawing.Point(-15, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmbSortBy
            // 
            this.cmbSortBy.BackColor = System.Drawing.SystemColors.Control;
            this.cmbSortBy.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSortBy.FormattingEnabled = true;
            this.cmbSortBy.Items.AddRange(new object[] {
            "Default",
            "A-Z",
            "Z-A",
            "Low to High",
            "High to Low"});
            this.cmbSortBy.Location = new System.Drawing.Point(1075, 206);
            this.cmbSortBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSortBy.Name = "cmbSortBy";
            this.cmbSortBy.Size = new System.Drawing.Size(153, 30);
            this.cmbSortBy.TabIndex = 3;
            this.cmbSortBy.SelectedIndexChanged += new System.EventHandler(this.cmbSortBy_SelectedIndexChanged);
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSortBy.Location = new System.Drawing.Point(996, 206);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(73, 23);
            this.lblSortBy.TabIndex = 4;
            this.lblSortBy.Text = "Sort by";
            // 
            // flpnlShowItem
            // 
            this.flpnlShowItem.AutoScroll = true;
            this.flpnlShowItem.Location = new System.Drawing.Point(285, 251);
            this.flpnlShowItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpnlShowItem.Name = "flpnlShowItem";
            this.flpnlShowItem.Size = new System.Drawing.Size(1027, 458);
            this.flpnlShowItem.TabIndex = 5;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategory.Location = new System.Drawing.Point(709, 208);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(98, 23);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.SystemColors.Control;
            this.cmbCategory.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "All",
            "Adventure",
            "Horror",
            "Sci-Fi"});
            this.cmbCategory.Location = new System.Drawing.Point(813, 206);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(153, 30);
            this.cmbCategory.TabIndex = 6;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1333, 720);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flpnlShowItem);
            this.Controls.Add(this.lblSortBy);
            this.Controls.Add(this.cmbSortBy);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMagazine;
        private System.Windows.Forms.Button btnMusicCd;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btnUserAdmin;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbSortBy;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.FlowLayoutPanel flpnlShowItem;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnShoppingCart;
        private System.Windows.Forms.Timer timer1;
    }
}