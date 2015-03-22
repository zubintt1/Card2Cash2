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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Card2Cash2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
         public MainWindow(string prevnum)
        {
            InitializeComponent();
            if (prevnum.ToString() != null)
            {
                numver_txtbx.Text = prevnum;
            }

        }

        private void activate_btn_Click(object sender, RoutedEventArgs e)
        {
            string Number1 = numver_txtbx.Text.Trim();
            string ApiReq1 = "https://api.urbanpiper.com/api/v1/card/activate/?format=json&customer_phone=91#replace#&username=zubin_urbanpiper&api_key=12345";
            string ApiReq2 = ApiReq1.Replace("#replace#", Number1);
            WebRequest request = WebRequest.Create(ApiReq2);
            
            //Stopwatch timer = new Stopwatch();
            //timer.Start();

            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();

            //timer.Stop();
            //TimeSpan timetaken = timer.Elapsed;

            //numver_txtbx.Text = timetaken.TotalSeconds.ToString();

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ResposeData));
            ResposeData datagot = (ResposeData)serializer.ReadObject(dataStream);

            PayForm1 pf = new PayForm1(numver_txtbx.Text);

            string status = datagot.success;
            
            if(status == "False")
            {
                this.Hide();
                pf.ShowDialog();
            }
            else
            {

                congrats_lbl1.Visibility = Visibility.Visible;
                //this.Enabled = false;
                //WaitSomeTime();
                this.Hide();
                pf.ShowDialog();

            }
            
            /*
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            experi_txtbx.Text = responseFromServer;
            */

        }

        public class ResposeData
        {
            public string success { get; set; }
        }

        public async void WaitSomeTime()
        {
            await Task.Delay(5000);
            //this.Enabled = true;
        }
    }
}
