using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store_v2
{
    /// <summary>
    /// music cdnin verilerini tutan class.
    /// </summary>
    public class MusicCD : Product
    {
        public String Singer;
        public string Description;
        public string demo;

        /// <summary>
        /// music classının verilerini detaylı olarak gösteren formun oluşturulduğu method.
        /// </summary>
        public override void ShowProperties()
        {

            MusicCDDetailsForm musicForm = new MusicCDDetailsForm(this);
            musicForm.ShowDialog();
            musicForm.Dispose();
        }
    }
}
