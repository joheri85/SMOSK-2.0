using System;
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
    
    public partial class MainForm : Form
    {
        private object jsonconvert;

        public MainForm()
        {
            InitializeComponent();
        }

        static class Globals
        {
            // Global Database variables
            public static XmlDocument ClassicDB = new XmlDocument();
            public static XmlDocument RetailDB = new XmlDocument();
            public static XmlDocument Settings = new XmlDocument();
            

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

        private void Form1_Load(object sender, EventArgs e)
        {
            Globals.ClassicDB.Load(@"..\..\Data\ClassicDB.xml");
            Globals.RetailDB.Load(@"..\..\Data\RetailDB.xml");
            Globals.Settings.Load(@"..\..\Data\Settings.xml");

            

            Label_GamePath.Text = Globals.Settings.GetElementsByTagName("wowpath")[0].InnerText;
            Label_GamePath.Width = 150;

            RefreshClassic(null, null);


        }



        private void RefreshClassic(object sender, EventArgs e)
        {
            

            XmlNodeList ClassicAddons = Globals.ClassicDB.GetElementsByTagName("Addon");
            
            ClassicListView.Clear();
            

            ClassicListView.Columns.Add("PID");
            ClassicListView.Columns.Add("Name");
            ClassicListView.Columns.Add("Current version");
            ClassicListView.Columns.Add("Latest version");
            ClassicListView.Columns.Add("Description");

            int i = 0;
            int ii = 0;
            foreach (XmlNode Node in ClassicAddons)
            {
                
                ListViewItem ClassicItem = new ListViewItem();
                ClassicItem.Text = Node["ID"].InnerText;

                ClassicItem.SubItems.Add(Node["Name"].InnerText);
                ClassicItem.SubItems.Add(Node["CurrentVersion"].InnerText);
                ClassicItem.SubItems.Add(Node["LatestVersion"].InnerText);
                ClassicItem.SubItems.Add(Node["Description"].InnerText);

                if (Node["CurrentVersion"].InnerText == Node["LatestVersion"].InnerText)
                {
                    ClassicListView.Items.Add(ClassicItem);
                    if (i % 2 == 0)
                    {
                        ClassicItem.BackColor = System.Drawing.Color.Black;
                        ClassicItem.ForeColor = System.Drawing.Color.LightGray;
                    }
                    else
                    {
                        ClassicItem.BackColor = System.Drawing.ColorTranslator.FromHtml("#272727");
                        ClassicItem.ForeColor = System.Drawing.Color.Snow;
                    }
                    i++;
                }
                else
                {
                    ClassicListView.Items.Insert(0,ClassicItem);
                    if (ii % 2 == 0)
                    {
                        ClassicItem.BackColor = System.Drawing.Color.Orange;
                        ClassicItem.ForeColor = System.Drawing.Color.Black;
                    }
                    else
                    {
                        ClassicItem.BackColor = System.Drawing.ColorTranslator.FromHtml("#e49400");
                        ClassicItem.ForeColor = System.Drawing.Color.Black;
                    }
                    ii++;
                }
                
                
                
            }

            ClassicListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            ClassicListView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
            ClassicListView.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
            ClassicListView.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.ColumnContent);

            


    }
        private void RefreshRetail(object sender, EventArgs e)
        {
            
            
            

            XmlNodeList RetailAddons = Globals.RetailDB.GetElementsByTagName("Addon");

            

            RetailListView.Clear();


            RetailListView.Columns.Add("PID");
            RetailListView.Columns.Add("Name");
            RetailListView.Columns.Add("Current version");
            RetailListView.Columns.Add("Latest version");
            RetailListView.Columns.Add("Description");

            int i = 0;
            int ii = 0;
            foreach (XmlNode Node in RetailAddons)
            {

                ListViewItem RetailItem = new ListViewItem();
                RetailItem.Text = Node["ID"].InnerText;

                RetailItem.SubItems.Add(Node["Name"].InnerText);
                RetailItem.SubItems.Add(Node["CurrentVersion"].InnerText);
                RetailItem.SubItems.Add(Node["LatestVersion"].InnerText);
                RetailItem.SubItems.Add(Node["Description"].InnerText);

                
                if (Node["CurrentVersion"].InnerText == Node["LatestVersion"].InnerText)
                {
                    RetailListView.Items.Add(RetailItem);
                    if (i % 2 == 0)
                    {
                        RetailItem.BackColor = System.Drawing.Color.Black;
                        RetailItem.ForeColor = System.Drawing.Color.LightGray;
                    }
                    else
                    {
                        RetailItem.BackColor = System.Drawing.ColorTranslator.FromHtml("#272727");
                        RetailItem.ForeColor = System.Drawing.Color.Snow;
                    }
                    i++;
                }
                else
                {
                    RetailListView.Items.Insert(0, RetailItem);
                    if (ii % 2 == 0)
                    {
                        RetailItem.BackColor = System.Drawing.Color.Orange;
                        RetailItem.ForeColor = System.Drawing.Color.Black;
                    }
                    else
                    {
                        RetailItem.BackColor = System.Drawing.ColorTranslator.FromHtml("#e49400");
                        RetailItem.ForeColor = System.Drawing.Color.Black;
                    }
                    ii++;
                }
            }

            RetailListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            RetailListView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
            RetailListView.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
            RetailListView.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.ColumnContent);
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
                Globals.ClassicDB.Save(@"..\..\Data\ClassicDB.xml");
                RefreshClassic(null, null);
            }
            else
            {
                Globals.RetailDB.Save(@"..\..\Data\RetailDB.xml");
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

        private void Button_BrowsPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                Label_GamePath.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;

                Globals.Settings.GetElementsByTagName("wowpath")[0].InnerText = folderDlg.SelectedPath;
                Globals.Settings.Save(@"..\..\Data\Settings.xml");
            }
        }

        private void Label_GamePath_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, Label_GamePath.DisplayRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void Button_OpenSearch_Click(object sender, EventArgs e)
        {
            SearchForm AddonSearch = new SearchForm();
            if (tabControl1.SelectedTab.Text == "Classic")
            {
                AddonSearch.Name = "Classic";
            }
            else
            {
                AddonSearch.Name = "Retail";
            }
            
            AddonSearch.ShowDialog();
            Globals.ClassicDB.Load(@"..\..\Data\ClassicDB.xml");
            Globals.RetailDB.Load(@"..\..\Data\RetailDB.xml");
            if (tabControl1.SelectedTab.Text == "Classic")
            {
                RefreshClassic(null, null);
            }
            else
            {
                RefreshRetail(null, null);
            }
           
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            List<string> IDs = new List<string>();
            if (tabControl1.SelectedTab.Text == "Classic")
            {
                if (ClassicListView.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem item in ClassicListView.SelectedItems)
                    {
                        IDs.Add(item.SubItems[0].Text);
                    }

                    foreach (string ID in IDs)
                    {
                        foreach (XmlNode IDNode in Globals.ClassicDB.SelectNodes("config/Addon/ID"))
                        {
                            if (IDNode.InnerText == ID)
                            {
                                XmlNode addon = IDNode.ParentNode;
                                deleteModules(addon.ChildNodes[6].InnerXml.Split(','));
                                addon.ParentNode.RemoveChild(addon);
                                continue;
                            }
                        }
                    }
                    Globals.ClassicDB.Save(@"..\..\Data\ClassicDB.xml");
                    RefreshClassic(null, null);
                }
            }
            else
            {
                if (RetailListView.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem item in RetailListView.SelectedItems)
                    {
                        IDs.Add(item.SubItems[0].Text);
                    }

                    foreach (string ID in IDs) 
                    {
                        foreach (XmlNode IDNode in Globals.RetailDB.SelectNodes("config/Addon/ID"))
                        {
                            if (IDNode.InnerText == ID)
                            {
                                
                                XmlNode addon = IDNode.ParentNode;
                                deleteModules(addon.ChildNodes[6].InnerXml.Split(','));
                                addon.ParentNode.RemoveChild(addon);
                                continue;
                            }
                        }
                    }

                    Globals.RetailDB.Save(@"..\..\Data\RetailDB.xml");
                    RefreshRetail(null, null);
                }
            }
        }

        private void deleteModules(string[] Modules)
        {
            
            string ModulePath;
            foreach (string Module in Modules) {
                if (tabControl1.SelectedTab.Text == "Classic")
                {
                    ModulePath = (Globals.Settings.SelectNodes("config/wowpath")[0].InnerText) + "\\_classic_\\Interface\\Addons\\" + Module;
                }
                else
                {
                    ModulePath = (Globals.Settings.SelectNodes("config/wowpath")[0].InnerText) + "\\_retail_\\Interface\\Addons\\" + Module;
                }

                if (Directory.Exists(ModulePath))
                {
                    Directory.Delete(ModulePath, true);
                }
            }
            
        }

        private void DownloadNewAddonFiles(string url)
        {

            using (var client = new WebClient())
            {
                client.DownloadFile(new System.Uri(url), "..\\..\\Downloads\\dl.zip");
            }
            String ExtractPath;
            if (tabControl1.SelectedTab.Text == "Classic")
            {
                ExtractPath = (Globals.Settings.SelectNodes("config/wowpath")[0].InnerText) + "\\_classic_\\Interface\\Addons\\";
            }
            else
            {
                ExtractPath = (Globals.Settings.SelectNodes("config/wowpath")[0].InnerText) + "\\_retail_\\Interface\\Addons\\";
            }

            System.IO.Compression.ZipFile.ExtractToDirectory("..\\..\\Downloads\\dl.zip", ExtractPath);

            File.Delete("..\\..\\Downloads\\dl.zip");
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Classic") { 
                
                
                if (ClassicListView.SelectedItems.Count > 0)
                {
                    this.SuspendLayout();

                    List<ListViewItem> UpdateList = new List<ListViewItem>();

                    foreach (ListViewItem ID in ClassicListView.SelectedItems)
                    {
                        UpdateList.Add(ID);
                    }

                    GetAddonManifest(null, null);

                    System.Xml.XPath.XPathNavigator nodeNav;
                    nodeNav = Globals.ClassicDB.CreateNavigator();

                    foreach (ListViewItem item in UpdateList)
                    {


                        string XPathStringClassic = "config/Addon[ID='" + item.SubItems[0].Text + "']";
                        var MatchedNodeClassic = nodeNav.SelectSingleNode(XPathStringClassic);

                        MatchedNodeClassic.SelectSingleNode("CurrentVersion").InnerXml = MatchedNodeClassic.SelectSingleNode("LatestVersion").InnerXml;

                        string[] Modules = MatchedNodeClassic.SelectSingleNode("Modules").InnerXml.Split(',');
                        deleteModules(Modules);
                        DownloadNewAddonFiles(MatchedNodeClassic.SelectSingleNode("DownloadLink").InnerXml);
                    }

                    Globals.ClassicDB.Save(@"..\..\Data\ClassicDB.xml");
                    
                    RefreshClassic(null, null);
                    this.ResumeLayout();

                }




            }
            else
            {
                if (RetailListView.SelectedItems.Count > 0)
                {
                    this.SuspendLayout();

                    List<ListViewItem> UpdateList = new List<ListViewItem>();

                    foreach (ListViewItem ID in RetailListView.SelectedItems)
                    {
                        UpdateList.Add(ID);
                    }

                    GetAddonManifest(null, null);

                    System.Xml.XPath.XPathNavigator nodeNav;
                    nodeNav = Globals.RetailDB.CreateNavigator();

                    foreach (ListViewItem item in UpdateList)
                    {


                        string XPathStringRetail = "config/Addon[ID='" + item.SubItems[0].Text + "']";
                        var MatchedNodeRetail = nodeNav.SelectSingleNode(XPathStringRetail);

                        MatchedNodeRetail.SelectSingleNode("CurrentVersion").InnerXml = MatchedNodeRetail.SelectSingleNode("LatestVersion").InnerXml;

                        string[] Modules = MatchedNodeRetail.SelectSingleNode("Modules").InnerXml.Split(',');
                        deleteModules(Modules);
                        DownloadNewAddonFiles(MatchedNodeRetail.SelectSingleNode("DownloadLink").InnerXml);
                    }

                    Globals.RetailDB.Save(@"..\..\Data\RetailDB.xml");

                    RefreshRetail(null, null);
                    this.ResumeLayout();

                }
            }
        }
    }
}
