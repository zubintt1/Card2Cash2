using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Runtime.Serialization.Json;
using System.Web;
using System.Net;
using System.IO;
using System.Runtime.Serialization;
using System.Diagnostics;

namespace Card2Cash2
{
    public partial class PayForm1 : Window
    {
        public PayForm1(string numver)
        {
            InitializeComponent();
            result_txtbx1.Text = null;
            if (numver.ToString() != null)
            {
                numver2_txtbx.Text = numver;
            }
        }

        public PayForm1()
        {
            InitializeComponent();
            result_txtbx1.Text = null;
        }

        private void back_btn1_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow(numver2_txtbx.Text);
            result_txtbx1.Text = null;
            this.Hide();
            mw.ShowDialog();
        }

        private void pay_btn1_Click_1(object sender, RoutedEventArgs e)
        {
            result_txtbx1.Text = null;
            string Number2 = numver2_txtbx.Text.Trim();
            float amount = float.Parse(amount_txtbx1.Text.Trim());

            //jUST FOR CHECKING numver2_txtbx.Text = amount.ToString();

            string ApiReq1 = "https://api.urbanpiper.com/api/v1/card/balanceupdate/?format=json&customer_phone=91#number#&username=zubin_urbanpiper&api_key=12345&amount=-#amount#";
            string ApiReq2 = ApiReq1.Replace("#number#", Number2);
            string ApiReq3 = ApiReq2.Replace("#amount#", amount.ToString());

            WebRequest request = WebRequest.Create(ApiReq3);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();

            /*
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            result_txtbx1.Text = responseFromServer;
            */


            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ResponseData2));
            ResponseData2 datagot = (ResponseData2)serializer.ReadObject(dataStream);

            PayForm2 pf2 = new PayForm2(numver2_txtbx.Text);

            string status = datagot.success;
            string message = datagot.message;

            Color color1 = (Color)ColorConverter.ConvertFromString("#FF0007A2");
            Color color2 = (Color)ColorConverter.ConvertFromString("#FF9C0404");

            if (status == "False")
            {
                result_txtbx1.Text = message;
                Failure_lbl1.Visibility = Visibility.Visible;
                result_txtbx1.Foreground = new System.Windows.Media.SolidColorBrush(color2);
                //this.Enabled = false;
                WaitSomeTime();
                this.Hide();
                pf2.ShowDialog();
            }
            else
            {
                result_txtbx1.Foreground = new System.Windows.Media.SolidColorBrush(color1);
                result_txtbx1.Text = message;
                Success_lbl1.Visibility = Visibility.Visible;
                //this.Enabled = false;
                WaitSomeTime();
                this.Hide();
                pf2.ShowDialog();
            }

        }

        public class ResponseData2
        {
            public string success { get; set; }
            public string message { get; set; }

        }
        public async void WaitSomeTime()
        {
            await Task.Delay(5000);
            //this.Enabled = true;
        }

    }
}