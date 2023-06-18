using MoneyBox_Application.Moneys;
using MoneyBox_Application.Moneys.Banknotes;
using MoneyBox_Application.Moneys.Coins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyBox_Application
{
    public partial class Form1 : Form
    {
        Banknotes banknote = new Banknotes();
        Coins coin = new Coins();
        MoneyBox moneyBox = new MoneyBox();
        Exception exception = new Exception();
        List<string> strings = new List<string>();
        List<string> strings2 = new List<string>();

        double totalVolume;
        double totalMoney = 0;
        int extravolume = 0;
        double percent;
        int shake = 0;
        int breakMoneyBox = 0;
        public Form1()
        {
            InitializeComponent();
            cmbMoneyType.Items.Add("Lütfen Seçiniz");
            cmbMoneyType.Items.AddRange(Enum.GetNames(typeof(MoneyType)));
            cmbMoneyType.SelectedIndex = 0;
            moneyBox.Volume = 150000;
            moneyBox.totalMoneysString = strings;
            moneyBox.totalMoney = totalMoney;
            btnFold.Enabled = false;
            btnSendMoney.Enabled = false;
            cmbPara.Enabled = false;
            btnAgglutinate.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbMoneyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPara.Items.Clear();
            switch (cmbMoneyType.SelectedItem.ToString())
            {
                case nameof(MoneyType.KagitPara):
                    cmbPara.Items.Add("Lütfen Seçiniz");
                    cmbPara.Items.AddRange(Enum.GetNames(typeof(BanknoteNames)));
                    cmbPara.SelectedIndex = 0;
                    btnSendMoney.Enabled = false;
                    break;
                case nameof(MoneyType.BozukPara):
                    cmbPara.Items.Add("Lütfen Seçiniz");
                    cmbPara.Items.AddRange(Enum.GetNames(typeof(CoinNames)));
                    cmbPara.SelectedIndex = 0;
                    btnSendMoney.Enabled = true;
                    btnFold.Enabled = false;
                    break;
            }

            cmbPara.Enabled = true;
        }

        private void cmbPara_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbPara.SelectedItem.ToString())
            {
                case nameof(BanknoteNames.IkiYuzLira):
                    banknote.Name = BanknoteNames.IkiYuzLira;
                    banknote.Value = 200;
                    banknote.Width = 72;
                    banknote.Length = 160;
                    banknote.Height = 0.25;
                    btnFold.Enabled = true;
                    break;
                case nameof(BanknoteNames.YuzLira):
                    banknote.Name = BanknoteNames.YuzLira;
                    banknote.Value = 100;
                    banknote.Width = 72;
                    banknote.Length = 154;
                    banknote.Height = 0.25;
                    btnFold.Enabled = true;
                    break;
                case nameof(BanknoteNames.ElliLira):

                    banknote.Name = BanknoteNames.ElliLira;
                    banknote.Value = 50;
                    banknote.Width = 68;
                    banknote.Length = 148;
                    banknote.Height = 0.25;
                    btnFold.Enabled = true;
                    break;
                case nameof(BanknoteNames.YirmiLira):
                    banknote.Name = BanknoteNames.YirmiLira;
                    banknote.Value = 20;
                    banknote.Width = 68;
                    banknote.Length = 142;
                    banknote.Height = 0.25;
                    btnFold.Enabled = true;
                    break;
                case nameof(BanknoteNames.OnLira):
                    banknote.Name = BanknoteNames.OnLira;
                    banknote.Value = 10;
                    banknote.Width = 64;
                    banknote.Length = 136;
                    banknote.Height = 0.25;
                    btnFold.Enabled = true;
                    break;
                case nameof(BanknoteNames.BesLira):
                    banknote.Name = BanknoteNames.BesLira;
                    banknote.Value = 200;
                    banknote.Width = 064;
                    banknote.Length = 130;
                    banknote.Height = 0.25;
                    btnFold.Enabled = true;
                    break;
                case nameof(CoinNames.BirLira):
                    coin.Name = CoinNames.BirLira;
                    coin.Value = 1;
                    coin.Radius = 13.07;
                    coin.Height = 1.9;
                    break;
                case nameof(CoinNames.ElliKurus):
                    coin.Name = CoinNames.ElliKurus;
                    coin.Value = 0.50;
                    coin.Radius = 11.92;
                    coin.Height = 1.9;
                    break;
                case nameof(CoinNames.YirmiBesKurus):
                    coin.Name = CoinNames.YirmiBesKurus;
                    coin.Value = 0.25;
                    coin.Radius = 10.25;
                    coin.Height = 1.65;
                    break;
                case nameof(CoinNames.OnKurus):
                    coin.Name = CoinNames.OnKurus;
                    coin.Value = 0.10;
                    coin.Radius = 9.25;
                    coin.Height = 1.65;
                    break;

            }
        }

        private void btnFold_Click(object sender, EventArgs e)
        {

            banknote.Fold(banknote);
            btnSendMoney.Enabled = true;
            btnFold.Enabled = false;

        }

        private void btnSendMoney_Click(object sender, EventArgs e)
        {
            switch (cmbMoneyType.SelectedItem.ToString())
            {
                case nameof(MoneyType.KagitPara):
                    extravolume = extravolume + banknote.CalculateVolume();
                    totalVolume = totalVolume + banknote.Volume;
                    percent = totalVolume / moneyBox.Volume * 100;
                    label6.Text = "%" + percent.ToString();
                    if (percent >= 100)
                    {
                        exception.ExceptionFully();
                        break;
                    }
                    else
                    {
                        moneyBox.totalMoneysString.Add(cmbPara.SelectedItem.ToString());
                        moneyBox.totalMoney = moneyBox.totalMoney + banknote.Value;
                        btnSendMoney.Enabled = false;
                        btnFold.Enabled = true;
                        btnShake.Enabled = true;
                        shake = 0;
                        break;
                    }
                case nameof(MoneyType.BozukPara):
                    extravolume = extravolume + coin.CalculateVolume();
                    totalVolume = totalVolume + coin.Volume;
                    percent = totalVolume / moneyBox.Volume * 100;
                    label6.Text = "%" + percent.ToString();
                    if (percent >= 100)
                    {
                        exception.ExceptionFully();
                        break;
                    }
                    else
                    {
                        moneyBox.totalMoneysString.Add(cmbPara.SelectedItem.ToString());
                        moneyBox.totalMoney = moneyBox.totalMoney + coin.Value;
                        btnSendMoney.Enabled = true;
                        shake = 0;
                        break;
                    }


            }

        }

        private void btnShake_Click(object sender, EventArgs e)
        {
            if (shake == 1)
            {
                exception.ExceptionShake();
            }
            else
            {
                double newExtraVolume = moneyBox.Shake(extravolume);
                totalVolume = totalVolume - (extravolume - newExtraVolume);
                percent = totalVolume / moneyBox.Volume * 100;
                label6.Text = "%" + percent.ToString();
                shake = shake + 1;
            }

        }

        private void btnBreak_Click(object sender, EventArgs e)
        {

            foreach (var item in moneyBox.totalMoneysString.GroupBy(x => x))
            {
                string a = string.Format("Kumbarada {0} adet {1} vardır", item.Count().ToString(), item.Key);
                listBoxTotal.Items.Add(a);
            }

            label5.Text = moneyBox.totalMoney.ToString() + "₺";
            breakMoneyBox = breakMoneyBox + 1;
            btnSendMoney.Enabled = false;
            btnAgglutinate.Enabled = true;

        }

        private void btnAgglutinate_Click(object sender, EventArgs e)
        {
            if (breakMoneyBox == 2)
            {
                exception.ExceptionAgglutinate();
            }
            else
            {
                moneyBox.totalMoney = 0;
                moneyBox.totalMoneysString = strings2;
                totalVolume = 0;
                extravolume = 0;
                listBoxTotal.Items.Clear();
                label5.Text = "0";
                label6.Text = "%0";
                btnAgglutinate.Enabled = false;
            }
        }


    }
}
