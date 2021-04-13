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
using System.Xml.Linq;

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
            public static XDocument ClassicDB;
            public static XDocument TBCDB;
            public static XDocument RetailDB;
            public static XDocument Settings;
            public static dynamic SearchRespons;
            public static string gameFlavor;

        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            Globals.ClassicDB = XDocument.Load(@".\Data\ClassicDB.xml");
            Globals.TBCDB = XDocument.Load(@".\Data\TBCDB.xml");
            Globals.RetailDB = XDocument.Load(@".\Data\RetailDB.xml");
            Globals.Settings = XDocument.Load(@".\Data\Settings.xml");

            

            if (this.Name == "Classic")
            {
                Globals.gameFlavor = "wow_classic";
            }
            else if (this.Name == "TBC")
            {
                Globals.gameFlavor = "wow_burning_crusade";
            }
            else
            {
                Globals.gameFlavor = "wow_retail";
            }

            if (this.Name == "Classic")
            {
                GameVersionSelector.SelectedItem = GameVersionSelector.Items[0];
            }
            else if (this.Name == "TBC")
            {
                GameVersionSelector.SelectedItem = GameVersionSelector.Items[1];
            }
            else
            {
                GameVersionSelector.SelectedItem = GameVersionSelector.Items[2];
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
                else if (this.Name == "TBC")
                {
                    string query = "api/v2/addon/search?&gameId=1&sort=downloadCount&gameVersionFlavor=wow_burning_crusade&searchFilter=" + Search_Input.Text;
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
                else if (this.Name == "TBC")
                {
                    Globals.gameFlavor = "wow_burning_crusade";
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

                int i = 0;
                foreach (ListViewItem Item in SearchFormListView.Items)
                {
                    if (i % 2 == 0)
                    {
                        Item.BackColor = System.Drawing.Color.Black;
                        Item.ForeColor = System.Drawing.Color.LightGray;
                    }
                    else
                    {
                        Item.BackColor = System.Drawing.ColorTranslator.FromHtml("#272727");
                        Item.ForeColor = System.Drawing.Color.Snow;
                    }

                    i++;
                }


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
            else if (GameVersionSelector.SelectedItem == GameVersionSelector.Items[1])
            {
                this.Name = "TBC";
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
                LabelInstalling.Text = "Installing..." + Environment.NewLine + Environment.NewLine + "(Window may appear unresponsive)";
                LabelInstalling.Visible = true;
                LabelInstalling.Update();
                Search_Input.Enabled = false;
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
                   
                    XElement NewAddon = new XElement("Addon");

                    if (this.Name == "Classic")
                    {

                        var MatchedNodeClassic = Globals.ClassicDB.Descendants("Addon")
                            .Where(x => (string)x.Element("ID").Value == (string)item)
                            .Count();

                        if (MatchedNodeClassic > 0)
                        {
                            SearchFormListView.SelectedItems[i].SubItems[1].Text = "Already installed";
                            SearchFormListView.SelectedItems[i].BackColor = System.Drawing.Color.Orange;
                            SearchFormListView.SelectedItems[i].ForeColor = System.Drawing.Color.Black;
                            i++;
                            Console.Out.WriteLine("Addon already installed");
                            continue;
                        }


                        NewAddon.Add(new XElement("ID"));
                        NewAddon.Add(new XElement("Name"));
                        NewAddon.Add(new XElement("DownloadLink"));
                        NewAddon.Add(new XElement("Description"));
                        NewAddon.Add(new XElement("CurrentVersion"));
                        NewAddon.Add(new XElement("LatestVersion"));
                        NewAddon.Add(new XElement("Modules"));
                        NewAddon.Add(new XElement("Website"));
                    }
                    else if (this.Name == "TBC")
                    {

                        var MatchedNodeTBC = Globals.TBCDB.Descendants("Addon")
                            .Where(x => (string)x.Element("ID").Value == (string)item)
                            .Count();

                        if (MatchedNodeTBC > 0)
                        {
                            SearchFormListView.SelectedItems[i].SubItems[1].Text = "Already installed";
                            SearchFormListView.SelectedItems[i].BackColor = System.Drawing.Color.Orange;
                            SearchFormListView.SelectedItems[i].ForeColor = System.Drawing.Color.Black;
                            i++;
                            Console.Out.WriteLine("Addon already installed");
                            continue;
                        }


                        NewAddon.Add(new XElement("ID"));
                        NewAddon.Add(new XElement("Name"));
                        NewAddon.Add(new XElement("DownloadLink"));
                        NewAddon.Add(new XElement("Description"));
                        NewAddon.Add(new XElement("CurrentVersion"));
                        NewAddon.Add(new XElement("LatestVersion"));
                        NewAddon.Add(new XElement("Modules"));
                        NewAddon.Add(new XElement("Website"));
                    }
                    else //if retail
                    {
                        var MatchedNodeRetail = Globals.RetailDB.Descendants("Addon")
                            .Where(x => (string)x.Element("ID").Value == (string)item)
                            .Count();

                        if (MatchedNodeRetail > 0)
                        {
                            SearchFormListView.SelectedItems[i].SubItems[1].Text = "Already installed";
                            SearchFormListView.SelectedItems[i].BackColor = System.Drawing.Color.Orange;
                            SearchFormListView.SelectedItems[i].ForeColor = System.Drawing.Color.Black;
                            i++;
                            Console.Out.WriteLine("Addon already installed");
                            continue;
                        }


                        NewAddon.Add(new XElement("ID"));
                        NewAddon.Add(new XElement("Name"));
                        NewAddon.Add(new XElement("DownloadLink"));
                        NewAddon.Add(new XElement("Description"));
                        NewAddon.Add(new XElement("CurrentVersion"));
                        NewAddon.Add(new XElement("LatestVersion"));
                        NewAddon.Add(new XElement("Modules"));
                        NewAddon.Add(new XElement("Website"));
                    }



               
                    foreach (dynamic addon in Globals.SearchRespons)
                    {
                        if (item == (string)addon.id)
                        {
                            NewAddon.Descendants("ID").First().Value = (string)addon.id;
                            NewAddon.Descendants("Name").First().Value = (string)addon.name;
                            NewAddon.Descendants("Description").First().Value = (string)addon.summary;
                            NewAddon.Descendants("Website").First().Value = (string)addon.websiteUrl;

                            foreach (dynamic release in addon.latestFiles)
                            {
                                
                                if (release.releaseType == "1" && release.gameVersionFlavor == Globals.gameFlavor)
                                {
                                    NewAddon.Descendants("DownloadLink").First().Value = (string)release.downloadUrl;
                                    newAddon((string)release.downloadUrl);
                                    NewAddon.Descendants("CurrentVersion").First().Value = (string)release.displayName;
                                    NewAddon.Descendants("LatestVersion").First().Value = (string)release.displayName;

                                    string moduleString     = "";
                                    foreach (dynamic module in release.modules)
                                    {
                                        moduleString += (module.foldername + ",");
                                    }
                                    NewAddon.Descendants("Modules").First().Value = moduleString.Trim(new Char[] { ',' });
                                    break;
                                }
                            }

                            break;
                        }
                    }



                    if (this.Name == "Classic")
                    {
                        Globals.ClassicDB.Descendants("config").Last().Add(NewAddon);
                    }
                    else if (this.Name == "TBC")
                    {
                        Globals.TBCDB.Descendants("config").Last().Add(NewAddon);
                    }
                    else
                    {
                        Globals.RetailDB.Descendants("config").Last().Add(NewAddon);
                    }
                        
                    //*********

                    SearchFormListView.SelectedItems[i].BackColor = System.Drawing.Color.LightGreen;
                    SearchFormListView.SelectedItems[i].ForeColor = System.Drawing.Color.Black;
                    i++;
                    progressBarInstalling.Value = (int)((i / (decimal)IDs.Count) * 100);
                    progressBarInstalling.Update();
                }

                if (this.Name == "Classic")
                {
                    Globals.ClassicDB.Save(@".\Data\ClassicDB.xml");
                }
                else if (this.Name == "TBC")
                {
                    Globals.TBCDB.Save(@".\Data\TBCDB.xml");
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
            Search_Input.Enabled = true;
            ButtonInstallSelected.Text = "Install";
            LabelInstalling.Visible = false;
        }

        private void newAddon(string url)
        {

            using (var client = new WebClient())
            {
                client.DownloadFile(new System.Uri(url), @".\Downloads\dl.zip");
            }
            String ExtractPath;
            if (this.Name == "Classic")
            {
                ExtractPath = Globals.Settings.Descendants("wowpath").First().Value + @"\_classic_\Interface\Addons\";
            }
            else if (this.Name == "TBC")
            {
                ExtractPath = Globals.Settings.Descendants("TBCPath").First().Value + @"\_tbc_\Interface\Addons\";
            }
            else
            {
                ExtractPath = Globals.Settings.Descendants("retailPath").First().Value + @"\_retail_\Interface\Addons\";
            }
            try
            {
                ZipFile.ExtractToDirectory(@".\Downloads\dl.zip", ExtractPath);
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e);
            }


            File.Delete(@".\Downloads\dl.zip");
        }
    }
}
