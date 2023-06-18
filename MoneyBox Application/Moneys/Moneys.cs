using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBox_Application.Moneys
{
    public enum MoneyType
    {
        KagitPara,BozukPara
    }

    public class Moneys
    {
        private MoneyType _moneyType;
        
        public MoneyType MoneyType { get=>_moneyType; set=>_moneyType = value; }
    }
}
