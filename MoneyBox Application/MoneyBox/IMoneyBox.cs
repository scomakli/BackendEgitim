using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBox_Application
{
    public interface IMoneyBox
    {
        double Volume { get; set; }
        List<string> totalMoneysString { get; set; }

        double totalMoney { get; set; }
        double Shake(int extravolume);      
        void Agglutinate();

    }
}
