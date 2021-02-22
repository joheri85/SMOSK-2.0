
namespace SMOSK_2._0
{
    partial class ImportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportForm));
            this.labelTitle = new System.Windows.Forms.Label();
            this.ImportFormListView = new System.Windows.Forms.ListView();
            this.ImportProgressbar = new System.Windows.Forms.ProgressBar();
            this.ButtonScan = new System.Windows.Forms.Button();
            this.ButtonImportSelected = new System.Windows.Forms.Button();
            this.toolTipScan = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipImport = new System.Windows.Forms.ToolTip(this.components);
            this.labelImportSelected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(12, 23);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(368, 14);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Scan for installed addons and select the ones to import";
            // 
            // ImportFormListView
            // 
            this.ImportFormListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportFormListView.AutoArrange = false;
            this.ImportFormListView.BackColor = System.Drawing.Color.Black;
            this.ImportFormListView.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportFormListView.ForeColor = System.Drawing.Color.White;
            this.ImportFormListView.FullRowSelect = true;
            this.ImportFormListView.HideSelection = false;
            this.ImportFormListView.Location = new System.Drawing.Point(12, 46);
            this.ImportFormListView.Name = "ImportFormListView";
            this.ImportFormListView.Size = new System.Drawing.Size(776, 353);
            this.ImportFormListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ImportFormListView.TabIndex = 3;
            this.ImportFormListView.UseCompatibleStateImageBehavior = false;
            this.ImportFormListView.View = System.Windows.Forms.View.Details;
            // 
            // ImportProgressbar
            // 
            this.ImportProgressbar.Location = new System.Drawing.Point(13, 405);
            this.ImportProgressbar.Name = "ImportProgressbar";
            this.ImportProgressbar.Size = new System.Drawing.Size(737, 33);
            this.ImportProgressbar.TabIndex = 7;
            this.ImportProgressbar.Visible = false;
            // 
            // ButtonScan
            // 
            this.ButtonScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonScan.BackColor = System.Drawing.Color.Black;
            this.ButtonScan.BackgroundImage = global::SMOSK_2._0.Properties.Resources.search_context;
            this.ButtonScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonScan.ForeColor = System.Drawing.Color.White;
            this.ButtonScan.Location = new System.Drawing.Point(756, 406);
            this.ButtonScan.Name = "ButtonScan";
            this.ButtonScan.Size = new System.Drawing.Size(32, 32);
            this.ButtonScan.TabIndex = 8;
            this.ButtonScan.UseVisualStyleBackColor = false;
            this.ButtonScan.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonImportSelected
            // 
            this.ButtonImportSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonImportSelected.BackColor = System.Drawing.Color.Black;
            this.ButtonImportSelected.BackgroundImage = global::SMOSK_2._0.Properties.Resources.import26;
            this.ButtonImportSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonImportSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonImportSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonImportSelected.ForeColor = System.Drawing.Color.White;
            this.ButtonImportSelected.Location = new System.Drawing.Point(718, 406);
            this.ButtonImportSelected.Name = "ButtonImportSelected";
            this.ButtonImportSelected.Size = new System.Drawing.Size(32, 32);
            this.ButtonImportSelected.TabIndex = 15;
            this.ButtonImportSelected.UseVisualStyleBackColor = false;
            this.ButtonImportSelected.Visible = false;
            this.ButtonImportSelected.Click += new System.EventHandler(this.ButtonImportSelected_Click);
            // 
            // labelImportSelected
            // 
            this.labelImportSelected.BackColor = System.Drawing.Color.Transparent;
            this.labelImportSelected.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImportSelected.ForeColor = System.Drawing.Color.Orange;
            this.labelImportSelected.Location = new System.Drawing.Point(230, 406);
            this.labelImportSelected.Name = "labelImportSelected";
            this.labelImportSelected.Size = new System.Drawing.Size(490, 32);
            this.labelImportSelected.TabIndex = 16;
            this.labelImportSelected.Text = "Select the addons you want to import and click ->";
            this.labelImportSelected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelImportSelected.Visible = false;
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SMOSK_2._0.Properties.Resources.Wall_color;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelImportSelected);
            this.Controls.Add(this.ButtonImportSelected);
            this.Controls.Add(this.ButtonScan);
            this.Controls.Add(this.ImportProgressbar);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.ImportFormListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImportForm";
            this.Text = "Import addons";
            this.Load += new System.EventHandler(this.ImportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListView ImportFormListView;
        private System.Windows.Forms.ProgressBar ImportProgressbar;
        private System.Windows.Forms.Button ButtonScan;
        private System.Windows.Forms.Button ButtonImportSelected;
        private System.Windows.Forms.ToolTip toolTipScan;
        private System.Windows.Forms.ToolTip toolTipImport;
        private System.Windows.Forms.Label labelImportSelected;
    }
}