using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store_v2
{
   public class Magazine : Product ///dergi class i olusturuldu, product ile inherit edilmiş halde.
    {
        public String Issue;
        public string Description;
       
       
        public override void ShowProperties()
        {
            MagazineDetailsForm magazineForm = new MagazineDetailsForm(this);
            magazineForm.ShowDialog();
            magazineForm.Dispose();
        }

    }
}
