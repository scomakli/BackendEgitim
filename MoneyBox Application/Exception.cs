using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyBox_Application
{
    public class Exception

    {
        public void ExceptionFully()
        {
            MessageBox.Show("Kumbara Doldu.Artık Para Atamazsınız");
        }
       
        public void ExceptionShake()
        {
            MessageBox.Show("Kumbarayı Yeteri Kadar Salladınız Tekrar Sallamadan önce Para Atın");
        }
        public void ExceptionAgglutinate()
        {
            MessageBox.Show("Kumbarayı Sadece Bir Kez Yapıştırabilirsiniz!!");
        }
    }
}
