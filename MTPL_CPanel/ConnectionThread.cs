using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;
using System.Net.Http;
using System.Net;
using System.IO;
using System.Collections;

namespace MTPL_CPanel
{
    class ConnectionThread : BackgroundWorker
    {
        private object _SENDER;
        
        Frm_Main apt;
        String[] args;
        List<string> Phones;
        List<string> Brands;
        private Frm_LoadingScreen LoadingScreen;
        private static readonly HttpClient client = new HttpClient();
        
        public ConnectionThread(object Sender)
        {
            _SENDER = Sender;
            Phones = new List<string>();
            Brands = new List<String>();
        }

        public void Execute(params string[] args)
        {
            this.args = args;
            if (!args[0].Equals("6")) {
                apt = (Frm_Main)_SENDER;
                apt.Enabled = false;
            }
            LoadingScreen = new Frm_LoadingScreen();
            LoadingScreen.Show();
            RunWorkerAsync();
        }

                             //**********************
                            // args[0]: destination
                           // if
                          //      args[0] = 1
        protected override void OnDoWork(DoWorkEventArgs e)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            HttpWebRequest request;
            var postData = "CPanel_Client=1";
            switch (args[0])
            {
                case "1":
                    request = (HttpWebRequest)WebRequest.Create("https://mawlatelecom.com/shop/pricelist/resources/api/phones_getter.php");
                    postData += "&request=phones";
                    break;
                case "2":
                    request= (HttpWebRequest)WebRequest.Create("https://mawlatelecom.com/shop/pricelist/resources/api/insert_phone.php");
                    postData += "&phonename=" +args[1];
                    postData += "&phonedesc=" +args[2];
                    postData += "&phoneprice=" +args[3];
                    postData += "&phonehidden=" +args[4];
                    postData += "&brandid=" +args[5];
                    break;
                case "3":
                    request = (HttpWebRequest)WebRequest.Create("https://mawlatelecom.com/shop/pricelist/resources/api/brands_getter.php");
                    postData += "&request=brands";
                    break;
                case "4":
                    request = (HttpWebRequest)WebRequest.Create("https://mawlatelecom.com/shop/pricelist/resources/api/phone_remover.php");
                    postData += "&phoneid=" +args[1];
                    break;
                case "5":
                    request = (HttpWebRequest)WebRequest.Create("https://mawlatelecom.com/shop/pricelist/resources/api/phone_updater.php");
                    postData += "&phoneid=" + args[1];
                    postData += "&phonename=" + args[2];
                    postData += "&phonedesc=" + args[3];
                    postData += "&phoneprice=" + args[4];
                    postData += "&phonehidden=" + args[5];
                    postData += "&brandid=" + args[6];
                    break;

                case "6":
                    request = (HttpWebRequest)WebRequest.Create("https://mawlatelecom.com/shop/pricelist/resources/api/brand_adder.php");
                    postData += "&brandname=" + args[1];
                    postData += "&brandhidden=" + args[2];
                    break;

                case "7":
                    request = (HttpWebRequest)WebRequest.Create("https://mawlatelecom.com/shop/pricelist/resources/api/brand_remover.php");
                    postData += "&brandid=" + args[1];
                    break;

                default:
                    request = null;
                    break;
            }
            
            var data = Encoding.ASCII.GetBytes(postData);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            var responseString = reader.ReadLine();
          
            if (responseString.Length > 1)
            {
                switch (args[0])
                {
                    case "1":
                        do
                        {
                            Phones.Add(responseString);
                        }
                        while ((responseString = reader.ReadLine()) != null);
                        break;
                    case "3":
                        do
                        {
                            Brands.Add(responseString);
                        }
                        while ((responseString = reader.ReadLine()) != null);
                        break;
                        
                }
            }
            else 
            {
                MessageBox.Show("An error occured!");
            }
            base.OnDoWork(e);
        }
        protected override void OnRunWorkerCompleted(RunWorkerCompletedEventArgs e)
        {
            switch (args[0]){
                case "1":
                foreach (string x in Phones)
            {
                int id = int.Parse(x.Split(';')[0]);
                String name = x.Split(';')[1];
                String price = x.Split(';')[3];
                String desc = x.Split(';')[2];
                apt.dgv.Rows.Add(id, name, price, desc);
            }
                    break;

                case "2":
                    apt.Refreshphones();
                    break;

                case "3":
                    foreach (string x in Brands)
                    {
                        int id = int.Parse(x.Split(';')[0]);
                        String name = x.Split(';')[1];
                        apt.cbox_brand.Items.Add(new ComboBox_ItemRow(id.ToString(),name));
                    }
                    apt.cbox_brand.SelectedIndex = 0;
                        break;
                case "4":
                    apt.Refreshphones();
                    break;

                case "5":
                    apt.Refreshphones();
                    break;

            }
            LoadingScreen.Hide();
            if (!args[0].Equals("6"))
            {
                apt.Enabled = true;

                
            }
            base.OnRunWorkerCompleted(e);
        }
        protected override void OnProgressChanged(ProgressChangedEventArgs e)
        {
            base.OnProgressChanged(e);
        }
    }
}
