using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBox_Application.Moneys.Banknotes
{
    public interface IBanknotes
    {
        double Length { get; set; }
        double Width { get; set; }
        double Height { get; set;}
        void Fold(Banknotes banknotes);


    }
}
