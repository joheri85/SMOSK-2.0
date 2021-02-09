﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Net.Http.Headers;
using System.Net;
using System.IO;
using System.Xml.Linq;
using System.Xml.XPath;

namespace SMOSK_2._0
{
    
    public partial class Form1 : Form
    {
        private object jsonconvert;

        public Form1()
        {
            InitializeComponent();
        }

        static class Globals
        {
            // Global Database variables
            public static XmlDocument ClassicDB = new XmlDocument();
            public static XmlDocument RetailDB = new XmlDocument();

        }
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Classic")
            {
                RefreshClassic(null, null);
            } 
            else
            {
                RefreshRetail(null, null);
            }
        }

       

        private void RefreshClassic(object sender, EventArgs e)
        {
            DetailsBox.Clear();

            XmlNodeList ClassicAddons = Globals.ClassicDB.GetElementsByTagName("Addon");
            ClassicListView.Clear();
            

            ClassicListView.Columns.Add("PID");
            ClassicListView.Columns.Add("Name");
            ClassicListView.Columns.Add("Current version");
            ClassicListView.Columns.Add("Latest version");
            ClassicListView.Columns.Add("Description");


            foreach (XmlNode Node in ClassicAddons)
            {
                
                ListViewItem ClassicItem = new ListViewItem();
                ClassicItem.Text = Node["ID"].InnerText;

                ClassicItem.SubItems.Add(Node["Name"].InnerText);
                ClassicItem.SubItems.Add(Node["CurrentVersion"].InnerText);
                ClassicItem.SubItems.Add(Node["LatestVersion"].InnerText);
                ClassicItem.SubItems.Add(Node["Description"].InnerText);

                ClassicListView.Items.Add(ClassicItem);
            }

            ClassicListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            ClassicListView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
            ClassicListView.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
            ClassicListView.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.ColumnContent);
        }
        private void RefreshRetail(object sender, EventArgs e)
        {
            DetailsBox.Clear();
            
            

            XmlNodeList RetailAddons = Globals.RetailDB.GetElementsByTagName("Addon");

            RetailListView.Clear();


            RetailListView.Columns.Add("PID");
            RetailListView.Columns.Add("Name");
            RetailListView.Columns.Add("Current version");
            RetailListView.Columns.Add("Latest version");
            RetailListView.Columns.Add("Description");


            foreach (XmlNode Node in RetailAddons)
            {

                ListViewItem RetailItem = new ListViewItem();
                RetailItem.Text = Node["ID"].InnerText;

                RetailItem.SubItems.Add(Node["Name"].InnerText);
                RetailItem.SubItems.Add(Node["CurrentVersion"].InnerText);
                RetailItem.SubItems.Add(Node["LatestVersion"].InnerText);
                RetailItem.SubItems.Add(Node["Description"].InnerText);

                RetailListView.Items.Add(RetailItem);
            }

            RetailListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            RetailListView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
            RetailListView.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
            RetailListView.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.ColumnContent);
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            Globals.ClassicDB.Load(@"..\..\Data\Save.xml");
            Globals.RetailDB.Load(@"..\..\Data\Save_Retail.xml");
            RefreshClassic(null, null);
        }


        private void ClassicListView_Click(object sender, EventArgs e)
        {
            String ClassicDetails = ClassicListView.SelectedItems[0].Text + @"
" + ClassicListView.SelectedItems[0].SubItems[1].Text + @"
" + ClassicListView.SelectedItems[0].SubItems[2].Text + @"
" + ClassicListView.SelectedItems[0].SubItems[3].Text + @"
" + ClassicListView.SelectedItems[0].SubItems[4].Text;

            DetailsBox.Text = ClassicDetails;
        }

        private void RetailListView_Click(object sender, EventArgs e)
        {
            String RetailDetails = RetailListView.SelectedItems[0].Text + @"
" + RetailListView.SelectedItems[0].SubItems[1].Text + @"
" + RetailListView.SelectedItems[0].SubItems[2].Text + @"
" + RetailListView.SelectedItems[0].SubItems[3].Text + @"
" + RetailListView.SelectedItems[0].SubItems[4].Text;

            DetailsBox.Text = RetailDetails;
        }

        private void GetAddonManifest(object sender, EventArgs e)
        {
            XmlNodeList Addons;
            XPathNavigator node;
            string gameFlavor;
            bool isClassic;

            if (tabControl1.SelectedTab.Text == "Classic")
            {
                isClassic = true;
            }
            else
            {
                isClassic = false;
            }

            if (isClassic)
            {
                Addons = Globals.ClassicDB.GetElementsByTagName("Addon");
                gameFlavor = "wow_classic";
            }
            else
            {
                Addons = Globals.RetailDB.GetElementsByTagName("Addon");
                gameFlavor = "wow_retail";
            }
            

            List<string> IDs = new List<string>();

            foreach (XmlNode addonNode in Addons)
            {
                IDs.Add(addonNode["ID"].InnerText);
            }

            String[] IDArray = IDs.ToArray();
           
            var JsonIDArray = JsonConvert.SerializeObject(IDArray);
           

            var body = new StringContent(JsonIDArray, Encoding.UTF8, "application/json");
            

            var response = APIPOST("https://addons-ecs.forgesvc.net/api/v2/addon/", JsonIDArray);
            
            dynamic json = JsonConvert.DeserializeObject(response);


            
            
            foreach (dynamic item in json )
            {
                if (tabControl1.SelectedTab.Text == "Classic")
                {
                    node = Globals.ClassicDB.CreateNavigator();
                }
                else
                {
                    node = Globals.RetailDB.CreateNavigator();
                }

               
                string XPathString = "config/Addon[ID='" + item.id + "']";
                var MatchedNode = node.SelectSingleNode(XPathString);


                foreach (dynamic subItem in item.latestFiles)
                {
                    if (subItem.gameVersionFlavor == gameFlavor && subItem.releaseType == "1")
                    {
                        MatchedNode.SelectSingleNode("LatestVersion").InnerXml = subItem.displayName;
                        break;
                    }
                    
                }

            }
            if (isClassic)
            {
                Globals.ClassicDB.Save(@"..\..\Data\Save.xml");
                RefreshClassic(null, null);
            }
            else
            {
                Globals.RetailDB.Save(@"..\..\Data\Save_Retail.xml");
                RefreshRetail(null, null);
            }
                
            

        }

        string APIPOST(string url, string jsonArray)
        {

            

            try
            {
               

                var httpWebRequest = WebRequest.CreateHttp(url);
                httpWebRequest.ContentType = "application/json; charset=utf-8";
                httpWebRequest.Method = "POST";
  
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(jsonArray);
                    streamWriter.Flush();
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                string responseText;

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    responseText = streamReader.ReadToEnd();
                }
                
                httpWebRequest.Abort();
              
                return responseText;
            }
            catch (WebException ex)
            {
                throw ex;
            }

        }
    }
}
