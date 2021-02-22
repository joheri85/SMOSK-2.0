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
using System.Diagnostics;

namespace SMOSK_2._0
{

    public partial class MainForm : Form
    {
        

        public MainForm()
        {
            InitializeComponent();
        }

        static class Globals
        {
            // Global Database variables
            public static XDocument ClassicDB;
            public static XDocument RetailDB;
            public static XDocument Settings;


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
            Application.EnableVisualStyles();
            Globals.ClassicDB = XDocument.Load(@".\Data\ClassicDB.xml");
            Globals.RetailDB = XDocument.Load(@".\Data\RetailDB.xml");

            Globals.Settings = XDocument.Load(@".\Data\Settings.xml");

            // ToolTips
            toolTipDelete.SetToolTip(ButtonDelete, "Delete selected addons");
            toolTipImport.SetToolTip(ButtonImport, "Import excisting addons");
            toolTipUppdateAll.SetToolTip(ButtonUpdateAll, "Update all addons with updates available");
            toolTipUpdateSelected.SetToolTip(ButtonUpdate, "Update/re-install selected addons");
            toolTipSearch.SetToolTip(Button_OpenSearch, "Search for new addons on CurseForge");
            toolTipRefresh.SetToolTip(RefreshButton, "Check for updates and refresh the addon list");
            toolTipBrows.SetToolTip(Button_BrowsPath, @"Select your WoW root dir Ex: 'D:\games\World of Warcraft'");

            // End ToolTips

            
            Label_GamePath.Text = (string)Globals.Settings.Descendants("wowpath")
                .First();
            Label_GamePath.Width = 150;


            try
            {
                var webRequest = WebRequest.Create(@"https://smosk.net/downloads/smosk2/smosk2version.txt");
                string latesVersion;

                using (var response = webRequest.GetResponse())
                using (var content = response.GetResponseStream())
                using (var reader = new StreamReader(content))
                {
                    latesVersion = reader.ReadToEnd();
                }


                string currentVersion = (string)Globals.Settings.Descendants("version")
                    .First();

                if (currentVersion != latesVersion)
                {
                    LabelVersion.Visible = true;
                }
            } catch
            {
                Console.Out.WriteLine("Could not check latest version. Timeout.");
            }
            

            GetAddonManifest(null, null);


        }
        private void SortXml(){

        }


        private void RefreshClassic(object sender, EventArgs e)
        {

            ClassicListView.Sorting = SortOrder.Ascending;
            var ClassicAddons = Globals.ClassicDB.Descendants("Addon");
            
            ClassicListView.Clear();
            

            
            ClassicListView.Columns.Add("Name");
            ClassicListView.Columns.Add("Current version");
            ClassicListView.Columns.Add("Latest version");
            ClassicListView.Columns.Add("Description");
            ClassicListView.Columns.Add("PID");

            
            foreach (XElement Node in ClassicAddons)
            {
                
                ListViewItem ClassicItem = new ListViewItem();
                ClassicItem.Text = Node.Element("Name").Value;

                
                ClassicItem.SubItems.Add(Node.Element("CurrentVersion").Value);
                ClassicItem.SubItems.Add(Node.Element("LatestVersion").Value);
                ClassicItem.SubItems.Add(Node.Element("Description").Value);
                ClassicItem.SubItems.Add(Node.Element("ID").Value);


                ClassicListView.Items.Add(ClassicItem);

               
                
            }



            ClassicListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            ClassicListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            ClassicListView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
            ClassicListView.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
            ClassicListView.Columns[4].Width = -2;


            ClassicListView.Sorting = SortOrder.None;
            int NrUpdates = 0;
            int i = 0;
            foreach (ListViewItem item in ClassicListView.Items)
            {
                if (item.SubItems[1].Text != item.SubItems[2].Text)
                {
                    ClassicListView.Items.RemoveAt(item.Index);
                    ClassicListView.Items.Insert(NrUpdates, item);
                    if (NrUpdates % 2 == 0)
                    {
                        item.ForeColor = System.Drawing.Color.Black;
                        item.BackColor = System.Drawing.Color.Orange;
                    }
                    else
                    {
                        item.ForeColor = System.Drawing.Color.Black;
                        item.BackColor = System.Drawing.ColorTranslator.FromHtml("#e49400");
                    }
                        
                    NrUpdates++;
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        item.BackColor = System.Drawing.Color.Black;
                        item.ForeColor = System.Drawing.Color.LightGray;
                    }
                    else
                    {
                        item.BackColor = System.Drawing.ColorTranslator.FromHtml("#272727");
                        item.ForeColor = System.Drawing.Color.Snow;
                    }
                }
                i++;
            }

            if (NrUpdates != 0)
            {
                LabelNrUpdates.Text = NrUpdates.ToString();
                LabelNrUpdates.Visible = true;

            }
            else
            {
                LabelNrUpdates.Visible = false;
            }

            
        }

        private void RefreshRetail(object sender, EventArgs e)
        {



            RetailListView.Sorting = SortOrder.Ascending;
            var RetailAddons = Globals.RetailDB.Descendants("Addon");

            

            RetailListView.Clear();


            
            RetailListView.Columns.Add("Name");
            RetailListView.Columns.Add("Current version");
            RetailListView.Columns.Add("Latest version");
            RetailListView.Columns.Add("Description");
            RetailListView.Columns.Add("PID");

            
            foreach (XElement Node in RetailAddons)
            {

                ListViewItem RetailItem = new ListViewItem();
                RetailItem.Text = Node.Element("Name").Value;

                
                RetailItem.SubItems.Add(Node.Element("CurrentVersion").Value);
                RetailItem.SubItems.Add(Node.Element("LatestVersion").Value);
                RetailItem.SubItems.Add(Node.Element("Description").Value);
                RetailItem.SubItems.Add(Node.Element("ID").Value);

                RetailListView.Items.Add(RetailItem);

                

            }

            
            

            RetailListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            RetailListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            RetailListView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
            RetailListView.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
            RetailListView.Columns[4].Width = -2;

            RetailListView.Sorting = SortOrder.None;
            int NrUpdates = 0;
            int i = 0;
            foreach (ListViewItem item in RetailListView.Items)
            {
                if (item.SubItems[1].Text != item.SubItems[2].Text)
                {
                    RetailListView.Items.RemoveAt(item.Index);
                    RetailListView.Items.Insert(NrUpdates, item);
                    if (NrUpdates % 2 == 0)
                    {
                        item.ForeColor = System.Drawing.Color.Black;
                        item.BackColor = System.Drawing.Color.Orange;
                    }
                    else
                    {
                        item.ForeColor = System.Drawing.Color.Black;
                        item.BackColor = System.Drawing.ColorTranslator.FromHtml("#e49400");
                    }

                    NrUpdates++;
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        item.BackColor = System.Drawing.Color.Black;
                        item.ForeColor = System.Drawing.Color.LightGray;
                    }
                    else
                    {
                        item.BackColor = System.Drawing.ColorTranslator.FromHtml("#272727");
                        item.ForeColor = System.Drawing.Color.Snow;
                    }
                }
                i++;
            }

            if (NrUpdates != 0)
            {
                LabelNrUpdates.Text = NrUpdates.ToString();
                LabelNrUpdates.Visible = true;

            }
            else
            {
                LabelNrUpdates.Visible = false;
            }
        }

       



        private void GetAddonManifest(object sender, EventArgs e)
        {
            
            dynamic Addons;
            XPathNavigator node;
            string gameFlavor;
            bool isClassic;
            
            if (tabControl1.SelectedTab.Text == "Classic")
            {
                isClassic = true;
                ClassicListView.BeginUpdate();
            }
            else
            {
                isClassic = false;
                RetailListView.BeginUpdate();
            }

            if (isClassic)
            {
                Addons = Globals.ClassicDB.Descendants("Addon");
                gameFlavor = "wow_classic";
            }
            else
            {
                Addons = Globals.RetailDB.Descendants("Addon");
                gameFlavor = "wow_retail";
            }
            

            List<string> IDs = new List<string>();

            foreach (XElement addonNode in Addons)
            {
                IDs.Add(addonNode.Element("ID").Value);
            }

            String[] IDArray = IDs.ToArray();
           
            var JsonIDArray = JsonConvert.SerializeObject(IDArray);
            

            var response = APIPOST("https://addons-ecs.forgesvc.net/api/v2/addon/", JsonIDArray);
            
            if (response != null)
            {

               
                
                dynamic json = JsonConvert.DeserializeObject(response);

               


                foreach (dynamic item in json )
                {

                    dynamic MatchedNode = null;
                    if (tabControl1.SelectedTab.Text == "Classic")
                    {
                        MatchedNode = Globals.ClassicDB.Descendants("Addon")
                            .Where(x => (string)x.Element("ID").Value == (string)item.id)
                            .First();
                    }
                    else
                    {
                        MatchedNode = Globals.RetailDB.Descendants("Addon")
                            .Where(x => (string)x.Element("ID").Value == (string)item.id)
                            .First();
                    }

               
                   


                    foreach (dynamic subItem in item.latestFiles)
                    {
                        if (subItem.gameVersionFlavor == gameFlavor && subItem.releaseType == "1")
                        {
                            MatchedNode.Element("LatestVersion").Value = (string)subItem.displayName;
                            MatchedNode.Element("DownloadLink").Value = (string)subItem.downloadUrl;
                            break;
                        }
                    
                    }

                }
            }


            if (isClassic)
            {
                Globals.ClassicDB.Save(@".\Data\ClassicDB.xml");
                RefreshClassic(null, null);
                ClassicListView.EndUpdate();
            }
            else
            {
                Globals.RetailDB.Save(@".\Data\RetailDB.xml");
                RefreshRetail(null, null);
                RetailListView.EndUpdate();
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
                return null;
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

                Globals.Settings.Descendants("wowpath").First().Value = folderDlg.SelectedPath;
                Globals.Settings.Save(@".\Data\Settings.xml");
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
            AddonSearch.StartPosition = FormStartPosition.Manual;
            AddonSearch.Location = new Point(this.Bounds.Location.X + 50, this.Bounds.Location.Y + 50);
            AddonSearch.ShowDialog();
            Globals.ClassicDB = XDocument.Load(@".\Data\ClassicDB.xml");
            Globals.RetailDB = XDocument.Load(@".\Data\RetailDB.xml");
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
            
            if (tabControl1.SelectedTab.Text == "Classic")
            {
                if (ClassicListView.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem item in ClassicListView.SelectedItems)
                    {
                        
                    
                        string ID = item.SubItems[4].Text;

                        var NodeToDelete = Globals.ClassicDB.Descendants("Addon")
                            .Where(x => (string)x.Element("ID") == ID)
                            .First();

                        deleteModules((NodeToDelete.Element("Modules").Value).Split(','));

                        NodeToDelete.Remove();


                    }
                    Globals.ClassicDB.Save(@".\Data\ClassicDB.xml");
                    RefreshClassic(null, null);
                }
            }
            else
            {
                if (RetailListView.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem item in RetailListView.SelectedItems)
                    {


                        string ID = item.SubItems[4].Text;

                        var NodeToDelete = Globals.RetailDB.Descendants("Addon")
                            .Where(x => (string)x.Element("ID") == ID)
                            .First();

                        deleteModules((NodeToDelete.Element("Modules").Value).Split(','));

                        NodeToDelete.Remove();


                    }
                    Globals.RetailDB.Save(@".\Data\ClassicDB.xml");
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
                    ModulePath = Globals.Settings.Descendants("wowpath").First().Value + "\\_classic_\\Interface\\Addons\\" + Module;
                }
                else
                {
                    ModulePath = Globals.Settings.Descendants("wowpath").First().Value + "\\_retail_\\Interface\\Addons\\" + Module;
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
                client.DownloadFile(new System.Uri(url), ".\\Downloads\\dl.zip");
            }
            String ExtractPath;
            if (tabControl1.SelectedTab.Text == "Classic")
            {
                ExtractPath = Globals.Settings.Descendants("wowpath").First().Value + "\\_classic_\\Interface\\Addons\\";
            }
            else
            {
                ExtractPath = Globals.Settings.Descendants("wowpath").First().Value + "\\_retail_\\Interface\\Addons\\";
            }

            System.IO.Compression.ZipFile.ExtractToDirectory(".\\Downloads\\dl.zip", ExtractPath);

            File.Delete(".\\Downloads\\dl.zip");
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            var buttonPressed = (Button)sender;

            if (tabControl1.SelectedTab.Text == "Classic") {
                
                
                if (ClassicListView.SelectedItems.Count > 0 || buttonPressed.Name == "ButtonUpdateAll")
                {
                    progressBarUpdate.Value = 0;
                    progressBarUpdate.Visible = true;

                    
                    

                    List<ListViewItem> UpdateList = new List<ListViewItem>();



                    
                    
                    if (buttonPressed.Name == "ButtonUpdate")
                    {
                        foreach (ListViewItem item in ClassicListView.SelectedItems)
                        {
                            UpdateList.Add(item);
                        }
                    }
                    else
                    {
                        foreach (ListViewItem item in ClassicListView.Items)
                        {
                            if (item.SubItems[1].Text != item.SubItems[2].Text)
                            {
                                UpdateList.Add(item);

                            }   
                        }
                    }

                    
                    
                    GetAddonManifest(null, null);

                    System.Xml.XPath.XPathNavigator nodeNav;
                    nodeNav = Globals.ClassicDB.CreateNavigator();

                    decimal i = 1;
                    foreach (ListViewItem item in UpdateList)
                    {

                        progressBarUpdate.Value = (int)((i / ((decimal)UpdateList.Count*2)) * 100);
                        string XPathStringClassic = "config/Addon[ID='" + item.SubItems[4].Text + "']";
                        var MatchedNodeClassic = nodeNav.SelectSingleNode(XPathStringClassic);
                        MatchedNodeClassic.SelectSingleNode("CurrentVersion").InnerXml = MatchedNodeClassic.SelectSingleNode("LatestVersion").InnerXml;

                        string[] Modules = MatchedNodeClassic.SelectSingleNode("Modules").InnerXml.Split(',');
                        deleteModules(Modules);
                        DownloadNewAddonFiles(MatchedNodeClassic.SelectSingleNode("DownloadLink").InnerXml);
                        progressBarUpdate.Value = (int)((i/(decimal)UpdateList.Count)*100);
                        
                        i++;
                    }

                    Globals.ClassicDB.Save(@".\Data\ClassicDB.xml");
                    
                    RefreshClassic(null, null);
                    progressBarUpdate.Visible = false;
                    //this.ResumeLayout();

                }




            }
            else
            {
                if (RetailListView.SelectedItems.Count > 0 || buttonPressed.Name == "ButtonUpdateAll")
                {
                    progressBarUpdate.Value = 0;
                    progressBarUpdate.Visible = true;
                    this.SuspendLayout();

                    List<ListViewItem> UpdateList = new List<ListViewItem>();

                    if (buttonPressed.Name == "ButtonUpdate")
                    {
                        foreach (ListViewItem item in RetailListView.SelectedItems)
                        {
                            UpdateList.Add(item);
                        }
                    }
                    else
                    {
                        foreach (ListViewItem item in RetailListView.Items)
                        {
                            if (item.SubItems[1].Text != item.SubItems[2].Text)
                            {
                                UpdateList.Add(item);

                            }
                        }
                    }

                    GetAddonManifest(null, null);

                    System.Xml.XPath.XPathNavigator nodeNav;
                    nodeNav = Globals.RetailDB.CreateNavigator();

                    decimal i = 1;
                    foreach (ListViewItem item in UpdateList)
                    {


                        string XPathStringRetail = "config/Addon[ID='" + item.SubItems[4].Text + "']";
                        var MatchedNodeRetail = nodeNav.SelectSingleNode(XPathStringRetail);

                        MatchedNodeRetail.SelectSingleNode("CurrentVersion").InnerXml = MatchedNodeRetail.SelectSingleNode("LatestVersion").InnerXml;

                        string[] Modules = MatchedNodeRetail.SelectSingleNode("Modules").InnerXml.Split(',');
                        deleteModules(Modules);
                        DownloadNewAddonFiles(MatchedNodeRetail.SelectSingleNode("DownloadLink").InnerXml);
                        progressBarUpdate.Value = (int)((i / (decimal)UpdateList.Count) * 100);

                        i++;
                    }

                    Globals.RetailDB.Save(@".\Data\RetailDB.xml");

                    
                    RefreshRetail(null, null);
                    progressBarUpdate.Visible = false;
                    this.ResumeLayout();
                    

                }
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Classic")
            {
                ClassicListView.Columns[4].Width = -2;
            } 
            else
            {
                RetailListView.Columns[4].Width = -2;
            }
            
        }

        private void LabelVersion_Click(object sender, EventArgs e)
        {
            Process.Start(@".\SMOSK 2.0 Updater.exe");
            Application.Exit();
        }

        private void ButtonImport_Click(object sender, EventArgs e)
        {
            ImportForm ImportView = new ImportForm();
            if (tabControl1.SelectedTab.Text == "Classic")
            {
                ImportView.Name = "Classic";
            }
            else
            {
                ImportView.Name = "Retail";
            }
            ImportView.StartPosition = FormStartPosition.Manual;
            ImportView.Location = new Point(this.Bounds.Location.X + 50, this.Bounds.Location.Y + 50);
            ImportView.ShowDialog();
            Globals.ClassicDB = XDocument.Load(@".\Data\ClassicDB.xml");
            Globals.RetailDB= XDocument.Load(@".\Data\RetailDB.xml");
            if (tabControl1.SelectedTab.Text == "Classic")
            {
                RefreshClassic(null, null);
            }
            else
            {
                RefreshRetail(null, null);
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void ClassicListView_DoubleClick(object sender, EventArgs e)
        {
            
            
            var Classic = XDocument.Load(@".\Data\ClassicDB.xml");

            var Url = Classic.Descendants("Addon")
                .Where(x => (string)x.Element("ID") == ClassicListView.SelectedItems[0].SubItems[4].Text)
                .First()
                .Descendants("Website")
                .First();
            System.Diagnostics.Process.Start((string)Url);

            
            
        }

        private void RetailListView_DoubleClick(object sender, EventArgs e)
        {
            var Retail = XDocument.Load(@".\Data\RetailDB.xml");

            var Url = Retail.Descendants("Addon")
                .Where(x => (string)x.Element("ID") == RetailListView.SelectedItems[0].SubItems[4].Text)
                .First()
                .Descendants("Website")
                .First();
            System.Diagnostics.Process.Start((string)Url);
        }
    }
}
