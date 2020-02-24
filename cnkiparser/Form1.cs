using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace cnkiparser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Open_Button_Click(object sender, EventArgs e)
        {
            if (Website_TextBox.Text != "")
            {
                HttpWebRequest HttpWReq = (HttpWebRequest)WebRequest.Create(Website_TextBox.Text);
                HttpWebResponse HttpWResp = (HttpWebResponse)HttpWReq.GetResponse();
                Stream dataStream = HttpWResp.GetResponseStream();
                StreamReader streamReader = new StreamReader(dataStream, Encoding.UTF8);
                Content_TextBox.Text = streamReader.ReadToEnd();
                HtmlAgilityPack.HtmlDocument htmldoc = new HtmlAgilityPack.HtmlDocument();
                htmldoc.LoadHtml(streamReader.ReadToEnd());
            }
            else
            {
                Content_TextBox.Text = "请输入网址";
            }
        }
    }
}
