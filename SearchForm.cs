using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.IO.Compression;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SMOSK_2._0
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        static class Globals
        {
            // Global Database variables
            public static XmlDocument ClassicDB = new XmlDocument();
            public static XmlDocument RetailDB = new XmlDocument();
            public static XmlDocument Settings = new XmlDocument();
            public static dynamic SearchRespons;
            public static string gameFlavor;

        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            Globals.ClassicDB.Load(@".\Data\ClassicDB.xml");
            Globals.RetailDB.Load(@".\Data\RetailDB.xml");
            Globals.Settings.Load(@".\Data\Settings.xml");

            

            if (this.Name == "Classic")
            {
                Globals.gameFlavor = "wow_classic";
            }
            else
            {
                Globals.gameFlavor = "wow_retail";
            }

            if (this.Name == "Classic")
            {
                GameVersionSelector.SelectedItem = GameVersionSelector.Items[0];
            }
            else
            {
                GameVersionSelector.SelectedItem = GameVersionSelector.Items[1];
            }
            
        }
        

        private void Search_Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) //if keypressed = Enter
            {
              
                if (this.Name == "Classic")
                {
                    string query = "api/v2/addon/search?&gameId=1&sort=downloadCount&gameVersionFlavor=wow_classic&searchFilter=" + Search_Input.Text;
                    _ = APISearchAsync(query);
                }
                else
                {
                    string query = "/api/v2/addon/search?&gameId=1&sort=downloadCount&gameVersionFlavor=wow_retail&searchFilter=" + Search_Input.Text;
                    _ = APISearchAsync(query);
                }
               
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            
        }

        async Task APISearchAsync(string url)
        {
            try
            {
                var baseAddress = new Uri("https://addons-ecs.forgesvc.net");

                using (var httpClient = new HttpClient { BaseAddress = baseAddress })
                {
                    {
                        using (var response = await httpClient.GetAsync(url))
                        {
                            string responseHeaders = response.Headers.ToString();
                            string responseData = await response.Content.ReadAsStringAsync();

                            //Console.WriteLine("Status " + (int)response.StatusCode);
                            //Console.WriteLine("Headers " + responseHeaders);
                            //Console.WriteLine(responseData);


                            Globals.SearchRespons = JsonConvert.DeserializeObject(responseData);
                            PopulateSearchResults();
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                throw ex;
            }

        }

        private void PopulateSearchResults()
        {
            //Console.Out.WriteLine(Globals.SearchRespons);
            try
            {
                SearchFormListView.Clear();


                SearchFormListView.Columns.Add("Name");
                SearchFormListView.Columns.Add("Description");
                SearchFormListView.Columns.Add("Version");
                SearchFormListView.Columns.Add("PID");

                
                if (this.Name == "Classic")
                {
                    Globals.gameFlavor = "wow_classic";
                }
                else
                {
                    Globals.gameFlavor = "wow_retail";
                }



                
                

                
                foreach (dynamic item in Globals.SearchRespons)
                {

                    dynamic correctRelease = null;
                    foreach (dynamic subItem in item.latestFiles)
                    {
                        if (subItem.gameVersionFlavor == Globals.gameFlavor && subItem.releaseType == "1")
                        {
                            correctRelease = subItem;
                            break;
                        }

                    }

                    ListViewItem ResultItem = new ListViewItem();
                    ResultItem.Text = item.name;
                    ResultItem.SubItems.Add((string)item.summary);
                    if (correctRelease != null)
                    {
                        ResultItem.SubItems.Add((string)correctRelease.displayName);
                    }
                    else
                    {
                        ResultItem.SubItems.Add("***** This addon has no version marked as 'Realease' for " + Globals.gameFlavor + " *****");
                    }
                    
                    ResultItem.SubItems.Add((string)item.id);


                    SearchFormListView.Items.Add(ResultItem);
                    
                    
                }

                SearchFormListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
                SearchFormListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
                SearchFormListView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
                SearchFormListView.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
            } 
            catch (Exception e)
            {
                Console.Out.WriteLine(e);
            }
        }

        private void GameVersionSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GameVersionSelector.SelectedItem == GameVersionSelector.Items[0])
            {
                this.Name = "Classic";
            }
            else
            {
                this.Name = "Retail";
            }
            
        }

        private void ButtonInstallSelected_Click(object sender, EventArgs e)
        {
            if (SearchFormListView.SelectedItems.Count > 0)
            {
                progressBarInstalling.Visible = true;
                ButtonInstallSelected.Text = "Installing...";
                ButtonInstallSelected.Enabled = false;
                SearchFormListView.Enabled = false;

                List<string> IDs = new List<string>();

                foreach (ListViewItem item in SearchFormListView.SelectedItems)
                {
                    IDs.Add(item.SubItems[3].Text);
                }


                int i = 0;
                foreach (String item in IDs)
                {
                    System.Xml.XPath.XPathNavigator nodeNav;
                    XmlNode root;
                    XmlNode SubNodeAddon;
                    XmlNode SubChildID;
                    XmlNode SubChildName;
                    XmlNode SubChildDL;
                    XmlNode SubChildDesc;
                    XmlNode SubChildCV;
                    XmlNode SubChildLV;
                    XmlNode SubChildMod;
                    XmlNode SubChildWeb;

                    if (this.Name == "Classic")
                    {
                        


                        //********************************
                        nodeNav = Globals.ClassicDB.CreateNavigator();

                        string XPathStringClassic = "config/Addon[ID='" + item + "']";
                        var MatchedNodeClassic = nodeNav.SelectSingleNode(XPathStringClassic);
                    
                        //********************************
                        if (MatchedNodeClassic != null)
                        {
                            SearchFormListView.SelectedItems[i].SubItems[1].Text = "Already installed";
                            SearchFormListView.SelectedItems[i].BackColor = System.Drawing.Color.Orange;
                            SearchFormListView.SelectedItems[i].ForeColor = System.Drawing.Color.Black;
                            i++;
                            Console.Out.WriteLine("Addon already installed");
                            continue;
                        }
                        
                       

                        root = Globals.ClassicDB.SelectSingleNode("config");
                            SubNodeAddon    = Globals.ClassicDB.CreateNode(XmlNodeType.Element,"Addon",null);
                                SubChildID      = Globals.ClassicDB.CreateNode(XmlNodeType.Element, "ID", null);
                                SubChildName    = Globals.ClassicDB.CreateNode(XmlNodeType.Element, "Name", null);
                                SubChildDL      = Globals.ClassicDB.CreateNode(XmlNodeType.Element, "DownloadLink", null);
                                SubChildDesc    = Globals.ClassicDB.CreateNode(XmlNodeType.Element, "Description", null);
                                SubChildCV      = Globals.ClassicDB.CreateNode(XmlNodeType.Element, "CurrentVersion", null);
                                SubChildLV      = Globals.ClassicDB.CreateNode(XmlNodeType.Element, "LatestVersion", null);
                                SubChildMod     = Globals.ClassicDB.CreateNode(XmlNodeType.Element, "Modules", null);
                                SubChildWeb     = Globals.ClassicDB.CreateNode(XmlNodeType.Element, "Website", null);
                    }
                    else
                    {
                        //********************************
                        nodeNav = Globals.RetailDB.CreateNavigator();

                        string XPathStringRetail = "config/Addon[ID='" + item + "']";
                        var MatchedNodeRetail = nodeNav.SelectSingleNode(XPathStringRetail);

                        //********************************
                        if (MatchedNodeRetail != null)
                        {
                            SearchFormListView.SelectedItems[i].SubItems[1].Text = "Already installed";
                            SearchFormListView.SelectedItems[i].BackColor = System.Drawing.Color.Orange;
                            SearchFormListView.SelectedItems[i].ForeColor = System.Drawing.Color.Black;
                            i++;
                            Console.Out.WriteLine("Addon already installed");
                            continue;
                        }


                        root = Globals.RetailDB.SelectSingleNode("config");
                            SubNodeAddon    = Globals.RetailDB.CreateNode(XmlNodeType.Element, "Addon", null);
                                SubChildID      = Globals.RetailDB.CreateNode(XmlNodeType.Element, "ID", null);
                                SubChildName    = Globals.RetailDB.CreateNode(XmlNodeType.Element, "Name", null);
                                SubChildDL      = Globals.RetailDB.CreateNode(XmlNodeType.Element, "DownloadLink", null);
                                SubChildDesc    = Globals.RetailDB.CreateNode(XmlNodeType.Element, "Description", null);
                                SubChildCV      = Globals.RetailDB.CreateNode(XmlNodeType.Element, "CurrentVersion", null);
                                SubChildLV      = Globals.RetailDB.CreateNode(XmlNodeType.Element, "LatestVersion", null);
                                SubChildMod     = Globals.RetailDB.CreateNode(XmlNodeType.Element, "Modules", null);
                                SubChildWeb     = Globals.RetailDB.CreateNode(XmlNodeType.Element, "Website", null);
                    }



               
                    foreach (dynamic addon in Globals.SearchRespons)
                    {
                        if (item == (string)addon.id)
                        {
                            SubChildID.InnerText    = (string)addon.id;
                            SubChildName.InnerText  = (string)addon.name;
                            SubChildDesc.InnerText  = (string)addon.summary;
                            SubChildWeb.InnerText   = (string)addon.websiteUrl;

                            foreach (dynamic release in addon.latestFiles)
                            {
                                
                                if (release.releaseType == "1" && release.gameVersionFlavor == Globals.gameFlavor)
                                {
                                    SubChildDL.InnerText    = (string)release.downloadUrl;
                                    newAddon((string)release.downloadUrl);
                                    SubChildCV.InnerText    = (string)release.displayName;
                                    SubChildLV.InnerText    = (string)release.displayName;

                                    string moduleString     = "";
                                    foreach (dynamic module in release.modules)
                                    {
                                        moduleString += (module.foldername + ",");
                                    }
                                    SubChildMod.InnerText = moduleString.Trim(new Char[] { ',' });
                                    break;
                                }
                            }

                            break;
                        }
                    }

                    SubNodeAddon.AppendChild(SubChildID);
                    SubNodeAddon.AppendChild(SubChildName);
                    SubNodeAddon.AppendChild(SubChildDL);
                    SubNodeAddon.AppendChild(SubChildDesc);
                    SubNodeAddon.AppendChild(SubChildCV);
                    SubNodeAddon.AppendChild(SubChildLV);
                    SubNodeAddon.AppendChild(SubChildMod);
                    SubNodeAddon.AppendChild(SubChildWeb);

                    root.AppendChild(SubNodeAddon);



                    SearchFormListView.SelectedItems[i].BackColor = System.Drawing.Color.LightGreen;
                    SearchFormListView.SelectedItems[i].ForeColor = System.Drawing.Color.Black;
                    i++;
                    progressBarInstalling.Value = (int)((i / (decimal)IDs.Count) * 100);
                }

                if (this.Name == "Classic")
                {
                    Globals.ClassicDB.Save(@".\Data\ClassicDB.xml");
                }
                else
                {
                    Globals.RetailDB.Save(@".\Data\RetailDB.xml");
                }
            }
            progressBarInstalling.Visible = false;
            SearchFormListView.SelectedIndices.Clear();
            SearchFormListView.Enabled = true;
            ButtonInstallSelected.Enabled = true;
            ButtonInstallSelected.Text = "Install";
        }

        private void newAddon(string url)
        {

            using (var client = new WebClient())
            {
                client.DownloadFile(new System.Uri(url), ".\\Downloads\\dl.zip");
            }
            String ExtractPath;
            if (this.Name == "Classic")
            {
                ExtractPath = (Globals.Settings.SelectNodes("config/wowpath")[0].InnerText) + "\\_classic_\\Interface\\Addons\\";
            }
            else
            {
                ExtractPath = (Globals.Settings.SelectNodes("config/wowpath")[0].InnerText) + "\\_retail_\\Interface\\Addons\\";
            }

            ZipFile.ExtractToDirectory(".\\Downloads\\dl.zip", ExtractPath);

            File.Delete(".\\Downloads\\dl.zip");
        }
    }
}
