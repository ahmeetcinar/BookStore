using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Online_Book_Store_v2
{
    /// <summary>
    /// müziklerin gösterildiği panel.
    /// </summary>
    class MusicCDPanel : ProductPanel
    {
        public Label Singer;
        public Label Type;
        public Label Price1;
        public Label Price2;
        public MusicCD musicCD;

        /// <summary>
        /// panelin içerdiği componentlerin oluşturulduğu constructor.
        /// </summary>
        /// <param name="item"></param>
        public MusicCDPanel(MusicCD item)
        {
            musicCD = item;
            this.BackColor = Color.Transparent;
            this.Size = new Size(350, 190);
            this.BorderStyle = BorderStyle.FixedSingle;


            picBox = new PictureBox();
            picBox.Size = new Size(105, 160);
            picBox.BackgroundImage = item.image;
            picBox.BackgroundImageLayout = ImageLayout.Zoom;


            magnifier = new PictureBox();
            magnifier.Size = new Size(32, 32);
            magnifier.BackgroundImage = Properties.Resources.magnifier;
            magnifier.BackgroundImageLayout = ImageLayout.Zoom;
            magnifier.Cursor = Cursors.Hand;
            magnifier.Click += new EventHandler(panelClick);

            name = new Label();
            name.AutoSize = true;
            name.Text = item.name;
            name.TextAlign = ContentAlignment.MiddleLeft;
            name.Font = new Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Controls.Add(name);

            Singer = new Label();
            Singer.AutoSize = true;
            Singer.Text = item.Singer;
            Singer.Font = new Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Controls.Add(Singer);

            Type = new Label();
            Type.AutoSize = true;
            Type.Text = item.Category;
            Type.Font = new Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            Type.ForeColor = Color.Black;
            this.Controls.Add(Type);

            Price1 = new Label();
            Price1.AutoSize = true;
            if (item.Sale > 0 && item.Sale < 100)
                Price1.Text = item.price + "TL  %" + item.Sale;
            else
                Price1.Text = "";
            Price1.Font = new Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            Price1.ForeColor = Color.Black;
            this.Controls.Add(Price1);

            Price2 = new Label();
            Price2.AutoSize = true;
            Price2.Text = item.discountedPrice + " TL";
            Price2.Font = new Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Controls.Add(Price2);



            picAdd = new PictureBox();
            picAdd.Size = new Size(32, 32);
            picAdd.BackgroundImage = Properties.Resources.cart;
            picAdd.BackgroundImageLayout = ImageLayout.Zoom;
            picAdd.Cursor = Cursors.Hand;
            picAdd.Click += new EventHandler(addCart);

            this.Controls[0].Location = new Point(125, 20);// Name label 
            this.Controls[0].BringToFront();
            this.Controls[1].Location = new Point(125, 50);// Singer label
            this.Controls[1].BringToFront();
            this.Controls[2].Location = new Point(125, 80);// Type label
            this.Controls[2].BringToFront();
            this.Controls[3].Location = new Point(125, 110);//  Price1 label
            this.Controls[3].BringToFront();
            this.Controls[4].Location = new Point(210, 110);// Price2 label
            this.Controls[4].BringToFront();
            this.Controls.Add(picBox);
            this.Controls[5].Location = new Point(10, 15); //Picturebox
            this.Controls.Add(magnifier);
            this.Controls[6].Location = new Point(175, 140);//Magnifier image
            this.Controls.Add(picAdd);
            this.Controls[7].Location = new Point(225, 140); //Add to cart image
        }

        /// <summary>
        /// ürülerin ayrıntısını açmaya yarayan method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelClick(object sender, EventArgs e)
        {
            Logger.logger(musicCD.name + " Panel Magnifier");
            musicCD.ShowProperties();

        }


        /// <summary>
        /// ürünleri sepete eklemeye yarayan method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addCart(object sender, EventArgs e)
        {

            Logger.logger(musicCD.name + " Add Cart");
            foreach (var it in MainForm.shoppingCart.ItemsToPurchase)
            {
                if (it.Product == this.musicCD)
                {
                    it.Quantity++;
                    MessageBox.Show(it.Product.name + " has been added to your shopping cart.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            ItemToPurchase item = new ItemToPurchase();
            item.Product = this.musicCD;
            item.Quantity = 1;
            MainForm.shoppingCart.ItemsToPurchase.Add(item);
            MessageBox.Show(item.Product.name + " has been added to your shopping cart.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

