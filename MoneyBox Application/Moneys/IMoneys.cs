using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBox_Application.Moneys
{
    public interface IMoneys
    {
        double Value { get; set; }
        double Volume { get; set; }
        int CalculateVolume ();
        


    }
}
