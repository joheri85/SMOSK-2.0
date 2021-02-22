using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace SMOSK_2._0
{
    public partial class ImportForm : Form
    {
        public ImportForm()
        {
            InitializeComponent();
        }

        static class Globals
        {
            // Global Database variables
            public static XDocument ClassicDB;
            public static XDocument RetailDB;
            public static XDocument Settings;
            public static dynamic lastItem = null;
            public static string gameFlavor;

        }

        private void ImportForm_Load(object sender, EventArgs e)
        {
            Globals.ClassicDB = XDocument.Load(@".\Data\ClassicDB.xml");
            Globals.RetailDB = XDocument.Load(@".\Data\RetailDB.xml");
            Globals.Settings = XDocument.Load(@".\Data\Settings.xml");

            if (File.Exists(@".\Data\import.xml"))
            {
                File.Delete(@".\Data\import.xml");
            }

            toolTipScan.SetToolTip(ButtonScan, ("Scan " + this.Name + " folder for excisting addons"));
            toolTipImport.SetToolTip(ButtonImportSelected, ("Import selected addons"));

            if (this.Name == "Classic")
            {
                Globals.gameFlavor = "wow_classic";
                labelTitle.Text = "Scan '" + (string)Globals.Settings.Descendants("wowpath").First() + @"\_classic_\Interface\addons\' for excisting addons";
            }
            else
            {
                Globals.gameFlavor = "wow_retail";
                labelTitle.Text = "Scan '" + (string)Globals.Settings.Descendants("wowpath").First() + @"\_retail_\Interface\addons\' for excisting addons";
            }
        }



        private void GetAddonList()
        {
            ImportFormListView.Columns.Add("Name");
            ImportFormListView.Columns.Add("Description");
            ImportFormListView.Columns.Add("Version");
            ImportFormListView.Columns.Add("PID");

            XDocument importXML = new XDocument(new XElement("config", string.Empty));
                                         
            importXML.Save(@".\Data\import.xml");

            if (this.Name == "Classic")
            {
                string ClassicPath = (string)Globals.Settings.Descendants("wowpath").First() + @"\_classic_\Interface\addons\";
                var directories = Directory.GetDirectories(ClassicPath);

                int ii = 0;
                foreach (string dir in directories)
                {
                    string[] FullPath = dir.Split('\\');
                    string name = FullPath[FullPath.Length - 1];

                    _ = APISearchAsync("api/v2/addon/search?&gameId=1&sort=downloadCount&gameVersionFlavor=wow_classic&searchFilter=" + name);

                    System.Threading.Thread.Sleep(200);
                    ImportProgressbar.Value = (int)((ii / (decimal)directories.Length) * 100);
                    ii++;
                }
                


            }
            else
            {
                string RetailPath = (string)Globals.Settings.Descendants("wowpath").First() + @"\_retail_\Interface\addons\";
                var directories = Directory.GetDirectories(RetailPath);

                int ii = 0;
                foreach (string dir in directories)
                {
                    string[] FullPath = dir.Split('\\');
                    string name = FullPath[FullPath.Length - 1];

                    _ = APISearchAsync("api/v2/addon/search?&gameId=1&sort=downloadCount&gameVersionFlavor=wow_retail&searchFilter=" + name);

                    System.Threading.Thread.Sleep(200);
                    ImportProgressbar.Value = (int)((ii / (decimal)directories.Length) * 100);
                    ii++;
                }
            }

            
            

            
            ImportProgressbar.Visible = false;
            ButtonImportSelected.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImportFormListView.BeginUpdate();
            ImportFormListView.Clear();
           
            
            ImportProgressbar.Value = 0;
            ImportProgressbar.Visible = true;
            GetAddonList();
            labelImportSelected.Visible = true;
            ImportFormListView.EndUpdate();
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

                           


                            dynamic addonResponse = JsonConvert.DeserializeObject(responseData);
                            dynamic item = addonResponse[0];

                            

                            dynamic correctRelease = null;
                            foreach (dynamic subItem in item.latestFiles)
                            {
                                if (subItem.gameVersionFlavor == Globals.gameFlavor && subItem.releaseType == "1")
                                {
                                    correctRelease = subItem;
                                    break;
                                }

                            }


                            // XML

                            XDocument importXML = XDocument.Load(@".\Data\import.xml");
                            importXML.Descendants("config").Last().Add(new XElement("Addon"));

                            importXML.Descendants("Addon").Last().Add(new XElement("ID", (string)item.id));
                            importXML.Descendants("Addon").Last().Add(new XElement("Name", (string)item.name));
                            importXML.Descendants("Addon").Last().Add(new XElement("DownloadLink", (string)correctRelease.downloadUrl));
                            importXML.Descendants("Addon").Last().Add(new XElement("Description", (string)item.summary));
                            importXML.Descendants("Addon").Last().Add(new XElement("CurrentVersion", "???"));
                            importXML.Descendants("Addon").Last().Add(new XElement("LatestVersion", (string)correctRelease.displayName));
                            string moduleString = "";
                            foreach (dynamic module in correctRelease.modules)
                            {
                                moduleString += (module.foldername + ",");
                            }
                            
                            importXML.Descendants("Addon").Last().Add(new XElement("Modules", moduleString.Trim(new Char[] { ',' })));
                            importXML.Descendants("Addon").Last().Add(new XElement("Website", (string)item.websiteUrl));

                            importXML.Save(@".\Data\import.xml");

                            // End XML

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

                            if (ImportFormListView.FindItemWithText((string)correctRelease.displayName) == null)
                            {
                                ImportFormListView.Items.Add(ResultItem);
                            }


                            ImportFormListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
                            ImportFormListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
                            ImportFormListView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
                            ImportFormListView.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);

                            
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                throw ex;
            }

        }

        private void ButtonImportSelected_Click(object sender, EventArgs e)
        {

            XDocument importXML = XDocument.Load(@".\Data\import.xml");

            if (this.Name == "Classic")
            {
                foreach (ListViewItem item in ImportFormListView.SelectedItems)
                {
                    try
                    {
                        var ExcistingNode = Globals.ClassicDB.Descendants("Addon")
                            .Where(x => (string)x.Element("ID") == item.SubItems[3].Text)
                            .Single();
                    } 
                    catch
                    {
                        var MatchingXMLNode = importXML.Descendants("Addon")
                            .Where(x => (string)x.Element("ID") == item.SubItems[3].Text)
                            .First();

                        Globals.ClassicDB.Descendants("config").Last().Add(MatchingXMLNode);
                    }

                }

                
                
                Globals.ClassicDB.Save(@".\Data\ClassicDB.xml");
            } 
            else
            {
                foreach (ListViewItem item in ImportFormListView.SelectedItems)
                {

                    try
                    {
                        var ExcistingNode = Globals.RetailDB.Descendants("Addon")
                            .Where(x => (string)x.Element("ID") == item.SubItems[3].Text)
                            .Single();
                    }
                    catch
                    {
                        var MatchingXMLNode = importXML.Descendants("Addon")
                            .Where(x => (string)x.Element("ID") == item.SubItems[3].Text)
                            .First();

                        Globals.RetailDB.Descendants("config").Last().Add(MatchingXMLNode);
                    }

                }
                Globals.RetailDB.Save(@".\Data\RetailDB.xml");
            }




            this.Close();

        }
    }
}


