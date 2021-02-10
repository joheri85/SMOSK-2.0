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

            
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            Globals.ClassicDB.Load(@"..\..\Data\ClassicDB.xml");
            Globals.RetailDB.Load(@"..\..\Data\RetailDB.xml");
            Globals.Settings.Load(@"..\..\Data\Settings.xml");


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

                            PopulateSearchResults(responseData);
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                throw ex;
            }

        }

        private void PopulateSearchResults(string result)
        {
            try
            {
                SearchFormListView.Clear();


                SearchFormListView.Columns.Add("PID");
                SearchFormListView.Columns.Add("Name");
                SearchFormListView.Columns.Add("Version");
                SearchFormListView.Columns.Add("Description");

                string gameFlavor;
                if (this.Name == "Classic")
                {
                    gameFlavor = "wow_classic";
                }
                else
                {
                    gameFlavor = "wow_retail";
                }



                dynamic json = JsonConvert.DeserializeObject(result);
                

                int i = 0;
                foreach (dynamic item in json)
                {

                    dynamic correctRelease = null;
                    foreach (dynamic subItem in item.latestFiles)
                    {
                        if (subItem.gameVersionFlavor == gameFlavor && subItem.releaseType == "1")
                        {
                            correctRelease = subItem;
                            break;
                        }

                    }

                    ListViewItem ResultItem = new ListViewItem();
                    ResultItem.Text = item.id;
                    ResultItem.SubItems.Add((string)item.name);
                    if (correctRelease != null)
                    {
                        ResultItem.SubItems.Add((string)correctRelease.displayName);
                    }
                    else
                    {
                        ResultItem.SubItems.Add("***** This addon has no version marked as 'Realease' for " + gameFlavor + " *****");
                    }
                    
                    ResultItem.SubItems.Add((string)item.summary);


                    SearchFormListView.Items.Add(ResultItem);
                    if (i % 2 == 0)
                    {
                        ResultItem.BackColor = System.Drawing.Color.Black;
                        ResultItem.ForeColor = System.Drawing.Color.LightGray;
                    }
                    else
                    {
                        ResultItem.BackColor = System.Drawing.ColorTranslator.FromHtml("#272727");
                        ResultItem.ForeColor = System.Drawing.Color.Snow;
                    }
                    i++;
                    
                }

                SearchFormListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
                SearchFormListView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
                SearchFormListView.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
            } 
            catch (Exception e)
            {
                Console.Out.WriteLine(e);
            }
        }

        private void SearchForm_Load_1(object sender, EventArgs e)
        {
            
        }
    }
}
