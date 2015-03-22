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
    public partial class PayForm2 : Window
    {
        public PayForm2(string numver3)
        {
            InitializeComponent();
            result_txtbx2.Text = null;
            Success_lbl2.Visibility = Visibility.Hidden;
            Failure_lbl2.Visibility = Visibility.Hidden;
            if (numver3.ToString() != null)
            {
                numver_txtbx3.Text = numver3;
            }
        }

        private void back_btn2_Click_1(object sender, RoutedEventArgs e)
        {
            Success_lbl2.Visibility = Visibility.Hidden;
            Failure_lbl2.Visibility = Visibility.Hidden;
            this.Hide();
            result_txtbx2.Text = null;
            PayForm1 pf2 = new PayForm1(numver_txtbx3.Text);
            pf2.ShowDialog();

        }

        private void pay_btn2_Click_1(object sender, RoutedEventArgs e)
        {
            result_txtbx2.Text = null;
            Success_lbl2.Visibility = Visibility.Hidden;
            Failure_lbl2.Visibility = Visibility.Hidden;
            string Number3 = numver_txtbx3.Text.Trim();
            float amount3 = float.Parse(amount_txtbx1.Text.ToString());
            string OTPNum = otpver_txtbx1.Text.Trim();

            string ApiReq1 = "https://api.urbanpiper.com/api/v1/card/balanceupdate/?format=json&customer_phone=91#number#&username=zubin_urbanpiper&api_key=12345&amount=-#amount#&pin=#Otp#";
            string ApiReq2 = ApiReq1.Replace("#number#", Number3);
            string ApiReq3 = ApiReq2.Replace("#amount#", amount3.ToString());
            string ApiReq4 = ApiReq3.Replace("#Otp#", OTPNum);

            WebRequest request = WebRequest.Create(ApiReq4);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();

            /*
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            result_txtbx2.Text = responseFromServer+ApiReq4;
            */

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ResponseData3));
            ResponseData3 datagot = (ResponseData3)serializer.ReadObject(dataStream);

            string status = datagot.success;
            string message = datagot.message;

            Color color1 = (Color)ColorConverter.ConvertFromString("#FF0007A2");
            Color color2 = (Color)ColorConverter.ConvertFromString("#FF9C0404");

            if (status == "False")
            {
                Success_lbl2.Visibility = Visibility.Hidden;
                Failure_lbl2.Visibility = Visibility.Visible;
                result_txtbx2.Foreground = new System.Windows.Media.SolidColorBrush(color2);
                result_txtbx2.Text = message;
                //result_txtbx2.Text = ApiReq4;

            }
            else
            {
                Failure_lbl2.Visibility = Visibility.Hidden;
                Success_lbl2.Visibility = Visibility.Visible;
                result_txtbx2.Foreground = new System.Windows.Media.SolidColorBrush(color1);
                result_txtbx2.Text = message;
                //result_txtbx2.Text = ApiReq4;

            }

        }

        public class ResponseData3
        {
            public string success { get; set; }
            public string message { get; set; }

        }

    }
}
