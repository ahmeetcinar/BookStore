using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Online_Book_Store_v2
{
    /// <summary>
    /// üye kaydı yapılan form.
    /// </summary>
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
        }
        Login form = new Login();

        /// <summary>
        /// üye olmaya yarayan method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnÜyeol_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxAdSoyad.Text) || string.IsNullOrWhiteSpace(txtboxAdress.Text) || string.IsNullOrWhiteSpace(txtBoxEmail.Text) || string.IsNullOrWhiteSpace(txtboxŞifre.Text) || string.IsNullOrWhiteSpace(txtboxŞifre.Text) || string.IsNullOrWhiteSpace(txtBoxŞifreTekrar.Text))
            {
                lblUyarı.Text = "Hiçbir alan boş kalamaz!";
            }
            else if (!IsValidEmail(txtBoxEmail.Text))
            {
                lblUyarı.Text = "Geçerli bir e-posta giriniz!";
            }
            else if (txtboxŞifre.Text != txtBoxŞifreTekrar.Text)
            {
                lblUyarı.Text = "Girdiğiniz şifreler aynı değil!";
            }
            else
            {
                using (SqlConnection con = new SqlConnection("Data Source = den1.mssql7.gear.host; Initial Catalog = ooponlinestore; User Id=ooponlinestore; Password=Sz144TFe65?-"))
                {
                    con.Open();

                    bool exists = false;
                    using (SqlCommand cmd = new SqlCommand("select count(*) from [dbo].[CUSTOMER] where Email = @EMAIL", con))
                    {
                        cmd.Parameters.AddWithValue("Email", txtBoxEmail.Text.Trim());
                        exists = (int)cmd.ExecuteScalar() > 0;
                    }
                    if (exists)
                    {
                        lblUyarı.Text = "Bu email ile daha önce kayıt yapılmış!";
                        return;
                    }
                    else
                    {
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[CUSTOMER] ([Name],[Address],[Email],[Password],[IsAdmin]) VALUES (@NAME, @ADDRESS, @EMAIL, @PASSWORD, @ISADMIN)", con))
                        {
                            cmd.Parameters.AddWithValue("Name", txtboxAdSoyad.Text.Trim());
                            cmd.Parameters.AddWithValue("Address", txtboxAdress.Text.Trim());
                            cmd.Parameters.AddWithValue("Email", txtBoxEmail.Text.Trim());
                            cmd.Parameters.AddWithValue("Password", txtboxŞifre.Text.Trim());
                            cmd.Parameters.AddWithValue("IsAdmin", 0);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    con.Close();
                    this.Hide();
                    form.Show();
                }
            }
        }
        /// <summary>
        /// emailin geçerli olup olmadığını kontrol eden method.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void txtboxAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtboxAdress_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
             && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        private void txtBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// şifrenin normal halde gösterilmesini sağlayan method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbŞifreGöster2_MouseDown(object sender, MouseEventArgs e)
        {
            txtboxŞifre.PasswordChar = '\0';
            txtBoxŞifreTekrar.PasswordChar = '\0';
        }
        /// <summary>
        /// şifrenin normal halde gösterilmesini sağlayan method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbŞifreGöster2_MouseUp(object sender, MouseEventArgs e)
        {
            txtboxŞifre.PasswordChar = '*';
            txtBoxŞifreTekrar.PasswordChar = '*';
        }
        /// <summary>
        /// formu kapatan method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// formu minimize eden method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1; public const int HT_CAPTION = 0x2;[DllImportAttribute("user32.dll")]  //paneli hareket ettirmek için
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);[DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        /// <summary>
        /// formu hareket ettirmeye yarayan method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlÜst_MouseMove(object sender, MouseEventArgs e)
        {
            Drag_Form(Handle, e);
        }
        /// <summary>
        /// formu hareket ettirmeye yarayan method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void Drag_Form(IntPtr Handle, MouseEventArgs e) { if (e.Button == MouseButtons.Left) { ReleaseCapture(); SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); } }

    }
}
