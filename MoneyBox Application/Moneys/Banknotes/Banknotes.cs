using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBox_Application.Moneys.Banknotes
{
    public enum BanknoteNames
    {
        IkiYuzLira, YuzLira, ElliLira, YirmiLira, OnLira, BesLira
    }

    public class Banknotes : IMoneys, IBanknotes
    {
        Random rnd = new Random();
        private BanknoteNames _banknoteName;
        private double _value;
        private double _length;
        private double _width;
        private double _height;
      
        public BanknoteNames Name { get=>_banknoteName ; set=>_banknoteName=value ; }
        public double Value { get => _value; set=>_value=value; }
        public double Volume { get; set; }
        public double Length { get=>_length; set=>_length=value; }
        public double Width { get=>_width; set=>_width=value; }
        public double Height { get=>_height; set=>_height=value; }



        public void Fold(Banknotes banknotes)
        {
            banknotes.Width = banknotes.Width * 0.25;
            banknotes.Height = banknotes.Height * 4;   
        }
        
        public int CalculateVolume()
        {
            Volume = 0;
            Volume = Width * Length * Height;
            int extravolume = Convert.ToInt32(rnd.NextDouble()*(Volume*0.75-Volume*0.25)+Volume*0.25);
            Volume = Volume + extravolume;
            return extravolume;
        }
    }
}
