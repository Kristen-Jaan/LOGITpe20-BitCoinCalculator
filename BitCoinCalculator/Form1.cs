using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace BitCoinCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetRatesBTN_Click(object sender, EventArgs e)
        {
            if(CurrencyMenu.SelectedItem.ToString() == "EUR")
            {
                resultLabel.Visible = true;
                Result.Visible = true;

                BitCoinRates resultRates = GetRates();
                int userCoins = Int32.Parse(AmountOfBTC.Text); //the amount of user's bitcoins

                float currentRate = resultRates.bpi.EUR.rate_float; //current bitcoin rate in EUR
                float btcResult = userCoins * currentRate;
                Result.Text = $"{btcResult} {resultRates.bpi.EUR.rate_float} EUR";
            }
            if(CurrencyMenu.SelectedItem.ToString() == "USD")
            {
                resultLabel.Visible = true;
                Result.Visible = true;

                BitCoinRates resultRates = GetRates();
                int userCoins = Int32.Parse(AmountOfBTC.Text);
                float currentRate = resultRates.bpi.USD.rate_float;
                float btcResult = userCoins * currentRate;
                Result.Text = $"{btcResult} {resultRates.bpi.USD.rate_float} USD";
            }
            if(CurrencyMenu.SelectedItem.ToString() == "GBP")
            {
                resultLabel.Visible = true;
                Result.Visible = true;

                BitCoinRates resultRates = GetRates();
                int userCoins = Int32.Parse(AmountOfBTC.Text);
                float currentRate = resultRates.bpi.GBP.rate_float;
                float btcResult = userCoins * currentRate;
                Result.Text = $"{btcResult} {resultRates.bpi.GBP.rate_float} GBP";
            }
        }

        public static BitCoinRates GetRates()
        {
            string url = "https://api.coindesk.com/v1/bpi/currentprice.json";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            BitCoinRates bitcoin;

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                bitcoin = JsonConvert.DeserializeObject<BitCoinRates>(response);
            }

            return bitcoin;

        }

    
    }
}
