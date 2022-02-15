using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store_v2
{

    /// <summary>
    /// kitap class'i ve genel uye verileri
    /// </summary>
    public class Book:Product
    {
        public String Author;
        public String Publisher;
        public String ISBN;
        public int Page;
        public string Summary;
        

        public override void ShowProperties()   ///book class ozellik gosterimleri
        {
            BookDetailsForm bookForm = new BookDetailsForm(this);
            bookForm.ShowDialog();
            bookForm.Dispose();
        }   
    }
}
