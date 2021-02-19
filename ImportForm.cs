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
            public static XmlDocument ClassicDB = new XmlDocument();
            public static XmlDocument RetailDB = new XmlDocument();
            public static XmlDocument Settings = new XmlDocument();
            public static string gameFlavor;
            public static dynamic lastItem = null;

        }

        private void ImportForm_Load(object sender, EventArgs e)
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
        }



        private void GetAddonList()
        {
            ImportFormListView.Columns.Add("Name");
            ImportFormListView.Columns.Add("Description");
            ImportFormListView.Columns.Add("Version");
            ImportFormListView.Columns.Add("PID");

            if (this.Name == "Classic")
            {
                string ClassicPath = Globals.Settings.GetElementsByTagName("wowpath")[0].InnerText + @"\_classic_\Interface\addons\";
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
                string RetailPath = Globals.Settings.GetElementsByTagName("wowpath")[0].InnerText + @"\_retail_\Interface\addons\";
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

            
            

            int i = 0;
            foreach (ListViewItem Item in ImportFormListView.Items)
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
            ImportProgressbar.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImportFormListView.Clear();
            ImportProgressbar.Value = 0;
            ImportProgressbar.Visible = true;
            GetAddonList();
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

                            ListViewItem ResultItem = new ListViewItem();
                            ResultItem.Text = item.name;
                            ResultItem.SubItems.Add((string)item.summary);
                            
                            if (ImportFormListView.FindItemWithText((string)correctRelease.displayName) != null)
                            {
                                Console.Out.WriteLine(ImportFormListView.FindItemWithText((string)correctRelease.displayName).Text);
                            }
                            

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


        

        
        
    }
}


