namespace Online_Book_Store_v2
{
    partial class MagazineDetailsForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblYayinci = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.lblBDiscount = new System.Windows.Forms.Label();
            this.lblADiscounte = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddCard = new System.Windows.Forms.Button();
            this.pcbPicture = new System.Windows.Forms.PictureBox();
            this.pnltop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nupQuantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPicture)).BeginInit();
            this.pnltop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(227, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 18);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Name";
            // 
            // lblYayinci
            // 
            this.lblYayinci.AutoSize = true;
            this.lblYayinci.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYayinci.Location = new System.Drawing.Point(227, 113);
            this.lblYayinci.Name = "lblYayinci";
            this.lblYayinci.Size = new System.Drawing.Size(73, 18);
            this.lblYayinci.TabIndex = 14;
            this.lblYayinci.Text = "Publisher";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategory.Location = new System.Drawing.Point(227, 164);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(76, 18);
            this.lblCategory.TabIndex = 15;
            this.lblCategory.Text = "category";
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPage.Location = new System.Drawing.Point(227, 213);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(54, 18);
            this.lblPage.TabIndex = 16;
            this.lblPage.Text = "pages";
            // 
            // lblBDiscount
            // 
            this.lblBDiscount.AutoSize = true;
            this.lblBDiscount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBDiscount.Location = new System.Drawing.Point(227, 263);
            this.lblBDiscount.Name = "lblBDiscount";
            this.lblBDiscount.Size = new System.Drawing.Size(133, 18);
            this.lblBDiscount.TabIndex = 17;
            this.lblBDiscount.Text = "Before Discounte";
            // 
            // lblADiscounte
            // 
            this.lblADiscounte.AutoSize = true;
            this.lblADiscounte.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblADiscounte.Location = new System.Drawing.Point(379, 265);
            this.lblADiscounte.Name = "lblADiscounte";
            this.lblADiscounte.Size = new System.Drawing.Size(119, 18);
            this.lblADiscounte.TabIndex = 18;
            this.lblADiscounte.Text = "After Discounte";
            // 
            // lblSum
            // 
            this.lblSum.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSum.ForeColor = System.Drawing.Color.Silver;
            this.lblSum.Location = new System.Drawing.Point(11, 14);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(471, 107);
            this.lblSum.TabIndex = 19;
            this.lblSum.Text = "Summary";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuantity.Location = new System.Drawing.Point(192, 505);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(74, 18);
            this.lblQuantity.TabIndex = 23;
            this.lblQuantity.Text = "Quantity:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = global::Online_Book_Store_v2.Properties.Resources.back_arrow;
            this.btnBack.Location = new System.Drawing.Point(411, 2);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 43);
            this.btnBack.TabIndex = 24;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddCard
            // 
            this.btnAddCard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddCard.FlatAppearance.BorderSize = 0;
            this.btnAddCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCard.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddCard.ForeColor = System.Drawing.Color.White;
            this.btnAddCard.Image = global::Online_Book_Store_v2.Properties.Resources.cart2;
            this.btnAddCard.Location = new System.Drawing.Point(382, 472);
            this.btnAddCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCard.Name = "btnAddCard";
            this.btnAddCard.Size = new System.Drawing.Size(103, 86);
            this.btnAddCard.TabIndex = 21;
            this.btnAddCard.UseVisualStyleBackColor = false;
            // 
            // pcbPicture
            // 
            this.pcbPicture.Location = new System.Drawing.Point(15, 52);
            this.pcbPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbPicture.Name = "pcbPicture";
            this.pcbPicture.Size = new System.Drawing.Size(196, 258);
            this.pcbPicture.TabIndex = 12;
            this.pcbPicture.TabStop = false;
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnltop.Controls.Add(this.btnBack);
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Margin = new System.Windows.Forms.Padding(4);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(497, 46);
            this.pnltop.TabIndex = 28;
            this.pnltop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnltop_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lblSum);
            this.panel1.Location = new System.Drawing.Point(0, 332);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 134);
            this.panel1.TabIndex = 29;
            // 
            // nupQuantity
            // 
            this.nupQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.nupQuantity.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nupQuantity.Location = new System.Drawing.Point(272, 503);
            this.nupQuantity.Name = "nupQuantity";
            this.nupQuantity.Size = new System.Drawing.Size(88, 26);
            this.nupQuantity.TabIndex = 30;
            // 
            // MagazineDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(497, 569);
            this.Controls.Add(this.nupQuantity);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnltop);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnAddCard);
            this.Controls.Add(this.lblADiscounte);
            this.Controls.Add(this.lblBDiscount);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblYayinci);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pcbPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MagazineDetailsForm";
            this.Text = "MagazineDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pcbPicture)).EndInit();
            this.pnltop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbPicture;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblYayinci;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label lblBDiscount;
        private System.Windows.Forms.Label lblADiscounte;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Button btnAddCard;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nupQuantity;
    }
}