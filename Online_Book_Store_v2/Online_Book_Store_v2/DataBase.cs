using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Online_Book_Store_v2
{
    /// <summary>
    /// veritabani baglantisi icin olusturulan siniftir.
    /// </summary>
    class DataBase
    {
        static private DataBase db;
        private DataBase() { }
        public static DataBase getInstance()
        {
            if (db == null)
                db = new DataBase();
            return db;
        }
        SqlConnection connection = new SqlConnection("Data Source = den1.mssql7.gear.host; Initial Catalog = ooponlinestore; User Id=ooponlinestore; Password=Sz144TFe65?-");
        public void CustomerUpdate(Customer cstmr) ///kullanici updatelerini gerceklestiren metod
        {
            string kayit = "UPDATE CUSTOMER SET NAME=@NAME, ADDRESS=@ADDRESS,Email=@EMAIL,Password=@PASSWORD,Purchases=@PURCHASES where EMAIL=@EMAIL";
            db.connection.Open();
            SqlCommand cmd = new SqlCommand(kayit, connection);
            cmd.Parameters.AddWithValue("ID", cstmr.Id);
            cmd.Parameters.AddWithValue("NAME", cstmr.Name);
            cmd.Parameters.AddWithValue("ADDRESS", cstmr.Adress);
            cmd.Parameters.AddWithValue("EMAIL", cstmr.Email);
            cmd.Parameters.AddWithValue("PASSWORD", cstmr.Password);
            cmd.Parameters.AddWithValue("PURCHASES", cstmr.PurchCount);
            cmd.ExecuteNonQuery();
            db.connection.Close();
        }
        public Customer CustomerHandler(string email, string password)  ///giris yaparken kullanilir veriler dogru mu degil mi kontrol eder.
        {
            Customer customer = null;
            try
            {
                db.connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[CUSTOMER] where EMAIL = @EMAIL", connection);
                command.Parameters.AddWithValue("EMAIL", email);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (password == (string)reader["PASSWORD"])
                {
                    customer = Customer.getInstance();
                    customer.Name = (string)reader["NAME"];
                    customer.Adress = (string)reader["ADDRESS"];
                    customer.Email = (string)reader["EMAIL"];
                    customer.Password = (string)reader["PASSWORD"];
                    customer.IsAdmin = (int)reader["ISADMIN"];
                    if (!DBNull.Value.Equals(reader["PURCHASES"]))
                        customer.PurchCount = (int)reader["PURCHASES"];
                }
            }
            catch (InvalidOperationException)
            {
                //Do nothing
            }
            catch (Exception ex)
            {
         //       System.Windows.Forms.MessageBox.Show("Server Connection Crashed, Please try again. \n" + ex.Message, "Connection Crashed", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            db.connection.Close();
            return customer;
        }
        public List<Product> BookLoader()   ///kitaplarin listesi, yuklemesi gerceklenir.
        {
            List<Product> booklist = new List<Product>();
            db.connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[BOOK]", connection);
            SqlDataReader reader = command.ExecuteReader();
            Book bk;
            while (reader.Read())
            {
                bk = new Book();
                bk.ProductID = (int)reader["ID"];
                bk.name = (string)reader["NAME"];
                bk.ISBN = (string)reader["ISBN"];
                bk.Author = (string)reader["AUTHOR"];
                bk.Publisher = (string)reader["PUBLISHER"];
                bk.Page = (int)reader["PAGE"];
                bk.price = Convert.ToDouble(reader["PRICE"]);
                bk.Sale = Convert.ToDouble(reader["SALE"]);
                

                if (bk.Sale <= 0 || bk.Sale >= 100)
                    bk.discountedPrice = bk.price;
                else
                    bk.discountedPrice = bk.price - (bk.price * bk.Sale) / 100;

                bk.Category = (string)reader["CATEGORY"];
                bk.Summary = (string)reader["SUMMARY"];
                try
                {
                    bk.image = Image.FromFile(Application.StartupPath + @"\Resources\BookPictures\" + (string)reader["IMAGEDEST"] + ".png");
                }
                catch (Exception)
                {
                    bk.image = Properties.Resources.dasdas;
                }
                booklist.Add(bk);
            }
            db.connection.Close();
            return booklist;
        }
        public List<Product> MusicCDLoader() ///albumlerin listesi, yuklemesi yapilir
        {
            List<Product> musiclist = new List<Product>();
            db.connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[MUSICCD]", connection);
            SqlDataReader reader = command.ExecuteReader();
            MusicCD mc;
            while (reader.Read())
            {
                mc = new MusicCD();
                mc.ProductID = (int)reader["ID"];
                mc.name = (string)reader["NAME"];
                mc.price = Convert.ToDouble(reader["PRICE"]);
                mc.Singer = (string)reader["SINGER"];
                mc.Category = (string)reader["TYPE"];       
                mc.Description = (string)reader["DESCRIPTION"];
                mc.Sale = Convert.ToDouble(reader["SALE"]);
               
                

                if (mc.Sale <= 0 || mc.Sale >= 100)
                    mc.discountedPrice = mc.price;
                else
                    mc.discountedPrice = mc.price - (mc.price * mc.Sale) / 100;

                
                try
                {
                    mc.image = Image.FromFile(Application.StartupPath + @"\Resources\MusicCdPictures\" + (string)reader["IMAGEDEST"] + ".png");
                }
                catch (Exception)
                {
                    mc.image = Properties.Resources.dasdas;
                }
                musiclist.Add(mc);
            }
            db.connection.Close();
            return musiclist;
        }
        public List<Product> MagazineLoader() ///dergilerin listesi, yuklemesi yapilir
        {
            List<Product> magazinelist = new List<Product>();
            db.connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[MAGAZINE]", connection);
            SqlDataReader reader = command.ExecuteReader();
            Magazine mg;
            while (reader.Read())
            {
                mg = new Magazine();
                mg.ProductID = (int)reader["ID"];
                mg.name = (string)reader["NAME"];
                mg.Description = (string)reader["DESCRIPTION"];
                mg.Issue = "Issue: " + reader["ISSUE"];
                mg.price = Convert.ToDouble(reader["PRICE"]);
                mg.Sale = Convert.ToDouble(reader["SALE"]);
                mg.Category = (string)reader["TYPE"];

                if (mg.Sale <= 0 || mg.Sale >= 100)
                    mg.discountedPrice = mg.price;
                else
                    mg.discountedPrice = mg.price - (mg.price * mg.Sale) / 100;

                try
                {
                    mg.image = Image.FromFile(Application.StartupPath + @"\Resources\MagazinePictures\" + (string)reader["IMAGEDEST"] + ".png");
                }
                catch (Exception)
                {
                    mg.image = Properties.Resources.dasdas;
                }

                magazinelist.Add(mg);
            }
            db.connection.Close();
            return magazinelist;
        }
        public void DbUpdate(string[] values, string command) ///database update gerceklesir.
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(command, connection);
            for (int i = 0; i < values.Length; i++)
            {
                cmd.Parameters.AddWithValue("" + i, values[i]);
            }
                cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
