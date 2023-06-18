using MoneyBox_Application.Moneys.Banknotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBox_Application
{
    public class MoneyBox:IMoneyBox
    {
       
        private List<string> _totalMoneysString;
        private double _totalMoney;
        public double Volume {get;set;}
        public List<string> totalMoneysString { get=>_totalMoneysString; set=>_totalMoneysString=value; }
        public double totalMoney { get=>_totalMoney; set=>_totalMoney=value; }
     
        
        public double Shake(int extravolume)
        {
           double newextravolume = extravolume * 0.33;
            return newextravolume;
        }


        public void Agglutinate()
        {
            
        }
    }
}
