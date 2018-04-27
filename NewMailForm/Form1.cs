using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace NewMailForm
{
    public partial class Frm : Form
    {
        //string message_subject;
        //string message_author;
        //string tagline;
        //string message_summary;
        public Frm()
        {
            InitializeComponent();
        }

        private class IgnoreBadCert : ICertificatePolicy
        {
            public bool CheckValidationResult(ServicePoint sp, X509Certificate cert, WebRequest request, int err)
            {
                return true;
            }
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string pass = txtPassword.Text;
            ServicePointManager.CertificatePolicy = new IgnoreBadCert();
            NetworkCredential cred = new NetworkCredential();
            cred.UserName = username;
            cred.Password = pass;
            WebRequest webr = WebRequest.Create("https://mail.google.com/mail/feed/atom");
            webr.Credentials = cred;
            Stream stream = webr.GetResponse().GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string s = sr.ReadToEnd();
            s = s.Replace("<feed version=\"0.3\" xmlns =\"http://purl.org/atom/ns#\">", @"<feed>");
            StreamWriter sw = new StreamWriter("emaildata.txt");
            sw.Write(s);
            sr.Close();
            sw.Close();
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load("emaildata.txt");
            string nr = xmldoc.SelectSingleNode(@"/feed/fullcount").InnerText;
            Console.WriteLine("Count: {0}", nr);
            foreach (XmlNode node in xmldoc.SelectNodes(@"/feed/entry"))
            {
                string title = node.SelectSingleNode("title").InnerText;
                string summary =
                node.SelectSingleNode("summary").InnerText;
                Console.WriteLine("{0} \n{1}\n", title, summary);
            }


            //System.Net.WebClient objclient = new WebClient();
            //XmlNodeList nodeList = default(XmlNodeList);
            //XmlNode node = default(XmlNode);
            //XmlNode node2 = default(XmlNode);
            //string response = null;
            //XmlDocument xdoc = new XmlDocument();
            //try
            //{
            //    objclient.Credentials = new System.Net.NetworkCredential(txtUser.Text.Trim(), txtPassword.Text.Trim());
            //    response = Encoding.UTF8.GetString(objclient.DownloadData("https://mail.google.com/mail/feed/atom"));
            //    response = response.Replace("<feed version=\"0.3\" xmlns =\"http://purl.org/atom/ns#\">", @"<feed>");
            //    xdoc.LoadXml(response);
            //    node = xdoc.SelectSingleNode("/feed/fullcount");
            //    Variables.mailcount = Convert.ToInt16(node.InnerText);
            //    labTBao.Text = "Bạn Có " + Variables.mailcount + "mail";
            //    tagline = xdoc.SelectSingleNode("/feed/tagline").InnerText;
            //    //
            //    if (Variables.mailcount > 0)
            //    {
            //        node2 = xdoc.SelectSingleNode("feed").SelectSingleNode("emtry");
            //        message_subject = node2.SelectSingleNode("title").InnerText;
            //        message_author = node2.SelectSingleNode("author").SelectSingleNode("name").InnerText;
            //        message_summary = node2.SelectSingleNode("summary").InnerText;

            //    }
            //}
            //catch (Exception ex)
            //{

            //}

        }
    }
}
