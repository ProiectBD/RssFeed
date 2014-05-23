using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RssFeed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[,] rssData = null;

        private String[,] getRssData(String channel)
        {
            System.Net.WebRequest _myRequest = System.Net.WebRequest.Create(channel);
            System.Net.WebResponse _myResponse = _myRequest.GetResponse();

            System.IO.Stream rssStream = _myResponse.GetResponseStream();
            System.Xml.XmlDocument rssDoc = new System.Xml.XmlDocument();
            
            rssDoc.Load(rssStream);

            System.Xml.XmlNodeList rssItems = rssDoc.SelectNodes("rss/channel/item");

            String[,] tempRssData = new String[100, 3];

            for (int i = 0; i < rssItems.Count; i++)
            {
                System.Xml.XmlNode rssNode;

                rssNode = rssItems.Item(i).SelectSingleNode("title");
                if (rssNode != null)
                {
                    tempRssData[i, 0] = rssNode.InnerText;
                }
                else
                {
                    tempRssData[i, 0] = "";
                }


                rssNode = rssItems.Item(i).SelectSingleNode("description");
                if (rssNode != null)
                {
                    tempRssData[i, 1] = rssNode.InnerText;
                }
                else
                {
                    tempRssData[i, 1] = "";
                }

                rssNode = rssItems.Item(i).SelectSingleNode("link");
                if (rssNode != null)
                {
                    tempRssData[i, 2] = rssNode.InnerText;
                }
                else
                {
                    tempRssData[i, 2] = "";
                }
            }
            return tempRssData;
        }

        private void RefreshB_Click(object sender, EventArgs e)
        {
            titlesCB.Items.Clear();
            rssData = getRssData(ChannelTB.Text);
            for (int i = 0; i < rssData.GetLength(0); i++)
            {
                if (rssData[i, 0] != null)
                {
                    titlesCB.Items.Add(rssData[i, 0]);
                }
                titlesCB.SelectedIndex = 0;
            }
        }

        private void titlesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rssData[titlesCB.SelectedIndex, 1] != null)
            {
                DescriptionTB.Text = rssData[titlesCB.SelectedIndex, 1];
            }
            if (rssData[titlesCB.SelectedIndex, 2] != null)
            {
                linkLabel.Text = "Go to:" + rssData[titlesCB.SelectedIndex, 0];
            }
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(rssData[titlesCB.SelectedIndex, 2]!=null)
            {
                System.Diagnostics.Process.Start(rssData[titlesCB.SelectedIndex, 2]);
            }
        }
    }
}
