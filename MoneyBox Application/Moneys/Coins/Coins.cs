using MoneyBox_Application.Moneys.Banknotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBox_Application.Moneys.Coins
{
    public enum CoinNames
    {
        BirLira, ElliKurus, YirmiBesKurus, OnKurus
    }
    public class Coins : ICoins,IMoneys
    {
        double pi = 3.14;
        Random rnd = new Random();
        private CoinNames _coinNames;
        private double _value;
        private double _radius;
        private double _height;
        public CoinNames Name { get => _coinNames; set => _coinNames = value; }
        public double Radius { get=>_radius; set=>_radius=value; }
        public double Height { get => _height; set => _height = value; }
        public double Value { get => _value; set => _value = value; }
        public double Volume { get; set; }

        public int CalculateVolume()
        {
          Volume=0;
            Volume = pi * Radius * Radius * Height;
            int extravolume = Convert.ToInt32(rnd.NextDouble() * (Volume * 0.75 - Volume * 0.25) + Volume * 0.25);
            Volume = Volume + extravolume;
            return extravolume;
        }
    }
}
