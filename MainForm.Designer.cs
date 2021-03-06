﻿
namespace SMOSK_2._0
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTBC = new System.Windows.Forms.TabPage();
            this.TBCListView = new System.Windows.Forms.ListView();
            this.tabClassic = new System.Windows.Forms.TabPage();
            this.ClassicListView = new System.Windows.Forms.ListView();
            this.tabRetail = new System.Windows.Forms.TabPage();
            this.RetailListView = new System.Windows.Forms.ListView();
            this.Label_GamePath = new System.Windows.Forms.Label();
            this.Button_BrowsPath = new System.Windows.Forms.Button();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.toolTipDelete = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipImport = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipUppdateAll = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipUpdateSelected = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSearch = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipRefresh = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBrows = new System.Windows.Forms.ToolTip(this.components);
            this.label_GamePathHeader = new System.Windows.Forms.Label();
            this.buttonSplitPath = new System.Windows.Forms.Button();
            this.toolTipSplitPath = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonImport = new System.Windows.Forms.Button();
            this.ButtonUpdateAll = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.LabelNrUpdates = new System.Windows.Forms.Label();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.Button_OpenSearch = new System.Windows.Forms.Button();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.label_ElvUIVersion = new System.Windows.Forms.Label();
            this.Label_ElvUI_UpdateAvailable = new System.Windows.Forms.Label();
            this.button_ElvUI = new System.Windows.Forms.Button();
            this.progressBarUpdate = new System.Windows.Forms.ProgressBar();
            this.tabControl1.SuspendLayout();
            this.tabTBC.SuspendLayout();
            this.tabClassic.SuspendLayout();
            this.tabRetail.SuspendLayout();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabTBC);
            this.tabControl1.Controls.Add(this.tabClassic);
            this.tabControl1.Controls.Add(this.tabRetail);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 476);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabTBC
            // 
            this.tabTBC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabTBC.Controls.Add(this.TBCListView);
            this.tabTBC.Location = new System.Drawing.Point(4, 22);
            this.tabTBC.Name = "tabTBC";
            this.tabTBC.Size = new System.Drawing.Size(768, 450);
            this.tabTBC.TabIndex = 2;
            this.tabTBC.Text = "TBC";
            this.tabTBC.UseVisualStyleBackColor = true;
            // 
            // TBCListView
            // 
            this.TBCListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBCListView.BackColor = System.Drawing.Color.Black;
            this.TBCListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBCListView.ForeColor = System.Drawing.Color.White;
            this.TBCListView.FullRowSelect = true;
            this.TBCListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.TBCListView.HideSelection = false;
            this.TBCListView.Location = new System.Drawing.Point(-1, 1);
            this.TBCListView.Name = "TBCListView";
            this.TBCListView.Size = new System.Drawing.Size(774, 450);
            this.TBCListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.TBCListView.TabIndex = 1;
            this.TBCListView.UseCompatibleStateImageBehavior = false;
            this.TBCListView.View = System.Windows.Forms.View.Details;
            this.TBCListView.DoubleClick += new System.EventHandler(this.TBCListView_DoubleClick);
            // 
            // tabClassic
            // 
            this.tabClassic.BackColor = System.Drawing.Color.Black;
            this.tabClassic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabClassic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabClassic.Controls.Add(this.ClassicListView);
            this.tabClassic.Location = new System.Drawing.Point(4, 22);
            this.tabClassic.Name = "tabClassic";
            this.tabClassic.Padding = new System.Windows.Forms.Padding(3);
            this.tabClassic.Size = new System.Drawing.Size(768, 450);
            this.tabClassic.TabIndex = 0;
            this.tabClassic.Text = "Classic";
            this.tabClassic.UseVisualStyleBackColor = true;
            // 
            // ClassicListView
            // 
            this.ClassicListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassicListView.BackColor = System.Drawing.Color.Black;
            this.ClassicListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClassicListView.ForeColor = System.Drawing.Color.White;
            this.ClassicListView.FullRowSelect = true;
            this.ClassicListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ClassicListView.HideSelection = false;
            this.ClassicListView.Location = new System.Drawing.Point(-1, 1);
            this.ClassicListView.Name = "ClassicListView";
            this.ClassicListView.Size = new System.Drawing.Size(774, 450);
            this.ClassicListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ClassicListView.TabIndex = 0;
            this.ClassicListView.UseCompatibleStateImageBehavior = false;
            this.ClassicListView.View = System.Windows.Forms.View.Details;
            this.ClassicListView.DoubleClick += new System.EventHandler(this.ClassicListView_DoubleClick);
            // 
            // tabRetail
            // 
            this.tabRetail.BackColor = System.Drawing.Color.Black;
            this.tabRetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabRetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabRetail.Controls.Add(this.RetailListView);
            this.tabRetail.Location = new System.Drawing.Point(4, 22);
            this.tabRetail.Name = "tabRetail";
            this.tabRetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabRetail.Size = new System.Drawing.Size(768, 450);
            this.tabRetail.TabIndex = 1;
            this.tabRetail.Text = "Retail";
            this.tabRetail.UseVisualStyleBackColor = true;
            // 
            // RetailListView
            // 
            this.RetailListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RetailListView.BackColor = System.Drawing.Color.Black;
            this.RetailListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RetailListView.ForeColor = System.Drawing.Color.White;
            this.RetailListView.FullRowSelect = true;
            this.RetailListView.HideSelection = false;
            this.RetailListView.Location = new System.Drawing.Point(-1, 1);
            this.RetailListView.Name = "RetailListView";
            this.RetailListView.Size = new System.Drawing.Size(774, 450);
            this.RetailListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.RetailListView.TabIndex = 0;
            this.RetailListView.UseCompatibleStateImageBehavior = false;
            this.RetailListView.View = System.Windows.Forms.View.Details;
            this.RetailListView.DoubleClick += new System.EventHandler(this.RetailListView_DoubleClick);
            // 
            // Label_GamePath
            // 
            this.Label_GamePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label_GamePath.AutoEllipsis = true;
            this.Label_GamePath.BackColor = System.Drawing.Color.Black;
            this.Label_GamePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_GamePath.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_GamePath.ForeColor = System.Drawing.Color.White;
            this.Label_GamePath.Location = new System.Drawing.Point(39, 519);
            this.Label_GamePath.MinimumSize = new System.Drawing.Size(270, 25);
            this.Label_GamePath.Name = "Label_GamePath";
            this.Label_GamePath.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Label_GamePath.Size = new System.Drawing.Size(270, 25);
            this.Label_GamePath.TabIndex = 3;
            this.Label_GamePath.Text = "test";
            this.Label_GamePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_GamePath.Paint += new System.Windows.Forms.PaintEventHandler(this.Label_GamePath_Paint);
            // 
            // Button_BrowsPath
            // 
            this.Button_BrowsPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_BrowsPath.BackColor = System.Drawing.Color.Black;
            this.Button_BrowsPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_BrowsPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_BrowsPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_BrowsPath.ForeColor = System.Drawing.Color.White;
            this.Button_BrowsPath.Location = new System.Drawing.Point(12, 519);
            this.Button_BrowsPath.Name = "Button_BrowsPath";
            this.Button_BrowsPath.Size = new System.Drawing.Size(25, 25);
            this.Button_BrowsPath.TabIndex = 4;
            this.Button_BrowsPath.Text = "...";
            this.Button_BrowsPath.UseVisualStyleBackColor = false;
            this.Button_BrowsPath.Click += new System.EventHandler(this.Button_BrowsPath_Click);
            this.Button_BrowsPath.MouseEnter += new System.EventHandler(this.Buttons_MouseEnter);
            this.Button_BrowsPath.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            // 
            // LabelVersion
            // 
            this.LabelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelVersion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVersion.ForeColor = System.Drawing.Color.DarkOrange;
            this.LabelVersion.Location = new System.Drawing.Point(530, 4);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(226, 25);
            this.LabelVersion.TabIndex = 13;
            this.LabelVersion.Text = "A new version of SMOSK is available!";
            this.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelVersion.Visible = false;
            this.LabelVersion.Click += new System.EventHandler(this.LabelVersion_Click);
            // 
            // label_GamePathHeader
            // 
            this.label_GamePathHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_GamePathHeader.AutoSize = true;
            this.label_GamePathHeader.BackColor = System.Drawing.Color.Transparent;
            this.label_GamePathHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GamePathHeader.ForeColor = System.Drawing.Color.White;
            this.label_GamePathHeader.Location = new System.Drawing.Point(12, 496);
            this.label_GamePathHeader.Name = "label_GamePathHeader";
            this.label_GamePathHeader.Size = new System.Drawing.Size(298, 18);
            this.label_GamePathHeader.TabIndex = 5;
            this.label_GamePathHeader.Text = "World of Warcraft Classic game folder";
            // 
            // buttonSplitPath
            // 
            this.buttonSplitPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSplitPath.BackColor = System.Drawing.Color.Black;
            this.buttonSplitPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSplitPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSplitPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSplitPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSplitPath.ForeColor = System.Drawing.Color.White;
            this.buttonSplitPath.Location = new System.Drawing.Point(311, 519);
            this.buttonSplitPath.Name = "buttonSplitPath";
            this.buttonSplitPath.Size = new System.Drawing.Size(25, 25);
            this.buttonSplitPath.TabIndex = 15;
            this.buttonSplitPath.Text = "1";
            this.buttonSplitPath.UseVisualStyleBackColor = false;
            this.buttonSplitPath.Click += new System.EventHandler(this.buttonSplitPath_Click);
            this.buttonSplitPath.MouseEnter += new System.EventHandler(this.Buttons_MouseEnter);
            this.buttonSplitPath.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            // 
            // ButtonImport
            // 
            this.ButtonImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonImport.BackColor = System.Drawing.Color.Black;
            this.ButtonImport.BackgroundImage = global::SMOSK_2._0.Properties.Resources.import26;
            this.ButtonImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonImport.ForeColor = System.Drawing.Color.White;
            this.ButtonImport.Location = new System.Drawing.Point(579, 504);
            this.ButtonImport.Name = "ButtonImport";
            this.ButtonImport.Size = new System.Drawing.Size(40, 40);
            this.ButtonImport.TabIndex = 14;
            this.ButtonImport.UseVisualStyleBackColor = false;
            this.ButtonImport.Click += new System.EventHandler(this.ButtonImport_Click);
            this.ButtonImport.MouseEnter += new System.EventHandler(this.Buttons_MouseEnter);
            this.ButtonImport.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            // 
            // ButtonUpdateAll
            // 
            this.ButtonUpdateAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonUpdateAll.BackColor = System.Drawing.Color.Black;
            this.ButtonUpdateAll.BackgroundImage = global::SMOSK_2._0.Properties.Resources.Context_update_all2;
            this.ButtonUpdateAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonUpdateAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonUpdateAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUpdateAll.ForeColor = System.Drawing.Color.White;
            this.ButtonUpdateAll.Location = new System.Drawing.Point(656, 504);
            this.ButtonUpdateAll.Name = "ButtonUpdateAll";
            this.ButtonUpdateAll.Size = new System.Drawing.Size(40, 40);
            this.ButtonUpdateAll.TabIndex = 12;
            this.ButtonUpdateAll.UseVisualStyleBackColor = false;
            this.ButtonUpdateAll.Click += new System.EventHandler(this.ButtonUpdate_Click);
            this.ButtonUpdateAll.MouseEnter += new System.EventHandler(this.Buttons_MouseEnter);
            this.ButtonUpdateAll.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshButton.BackColor = System.Drawing.Color.Black;
            this.RefreshButton.BackgroundImage = global::SMOSK_2._0.Properties.Resources.Refresh_icon;
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.ForeColor = System.Drawing.Color.White;
            this.RefreshButton.Location = new System.Drawing.Point(762, 4);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(25, 25);
            this.RefreshButton.TabIndex = 1;
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.GetAddonManifest);
            this.RefreshButton.MouseEnter += new System.EventHandler(this.Buttons_MouseEnter);
            this.RefreshButton.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            // 
            // LabelNrUpdates
            // 
            this.LabelNrUpdates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelNrUpdates.BackColor = System.Drawing.Color.Transparent;
            this.LabelNrUpdates.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNrUpdates.ForeColor = System.Drawing.Color.Black;
            this.LabelNrUpdates.Image = global::SMOSK_2._0.Properties.Resources.NrUpdates;
            this.LabelNrUpdates.Location = new System.Drawing.Point(636, 491);
            this.LabelNrUpdates.Name = "LabelNrUpdates";
            this.LabelNrUpdates.Size = new System.Drawing.Size(20, 20);
            this.LabelNrUpdates.TabIndex = 10;
            this.LabelNrUpdates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonUpdate.BackColor = System.Drawing.Color.Black;
            this.ButtonUpdate.BackgroundImage = global::SMOSK_2._0.Properties.Resources.Context_update2;
            this.ButtonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUpdate.ForeColor = System.Drawing.Color.White;
            this.ButtonUpdate.Location = new System.Drawing.Point(702, 504);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(40, 40);
            this.ButtonUpdate.TabIndex = 9;
            this.ButtonUpdate.UseVisualStyleBackColor = false;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            this.ButtonUpdate.MouseEnter += new System.EventHandler(this.Buttons_MouseEnter);
            this.ButtonUpdate.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDelete.BackColor = System.Drawing.Color.Black;
            this.ButtonDelete.BackgroundImage = global::SMOSK_2._0.Properties.Resources.Context_trash2;
            this.ButtonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDelete.ForeColor = System.Drawing.Color.White;
            this.ButtonDelete.Location = new System.Drawing.Point(533, 504);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(40, 40);
            this.ButtonDelete.TabIndex = 7;
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            this.ButtonDelete.MouseEnter += new System.EventHandler(this.Buttons_MouseEnter);
            this.ButtonDelete.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            // 
            // Button_OpenSearch
            // 
            this.Button_OpenSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_OpenSearch.BackColor = System.Drawing.Color.Black;
            this.Button_OpenSearch.BackgroundImage = global::SMOSK_2._0.Properties.Resources.search_context;
            this.Button_OpenSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_OpenSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_OpenSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_OpenSearch.ForeColor = System.Drawing.Color.White;
            this.Button_OpenSearch.Location = new System.Drawing.Point(748, 504);
            this.Button_OpenSearch.Name = "Button_OpenSearch";
            this.Button_OpenSearch.Size = new System.Drawing.Size(40, 40);
            this.Button_OpenSearch.TabIndex = 6;
            this.Button_OpenSearch.UseVisualStyleBackColor = false;
            this.Button_OpenSearch.Click += new System.EventHandler(this.Button_OpenSearch_Click);
            this.Button_OpenSearch.MouseEnter += new System.EventHandler(this.Buttons_MouseEnter);
            this.Button_OpenSearch.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            // 
            // panelBackground
            // 
            this.panelBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBackground.BackgroundImage = global::SMOSK_2._0.Properties.Resources.wallpaper_seamless;
            this.panelBackground.Controls.Add(this.label_ElvUIVersion);
            this.panelBackground.Controls.Add(this.Label_ElvUI_UpdateAvailable);
            this.panelBackground.Controls.Add(this.button_ElvUI);
            this.panelBackground.Controls.Add(this.progressBarUpdate);
            this.panelBackground.Location = new System.Drawing.Point(-6, 34);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(808, 522);
            this.panelBackground.TabIndex = 1;
            // 
            // label_ElvUIVersion
            // 
            this.label_ElvUIVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ElvUIVersion.BackColor = System.Drawing.Color.Transparent;
            this.label_ElvUIVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ElvUIVersion.ForeColor = System.Drawing.Color.White;
            this.label_ElvUIVersion.Location = new System.Drawing.Point(428, 455);
            this.label_ElvUIVersion.Name = "label_ElvUIVersion";
            this.label_ElvUIVersion.Size = new System.Drawing.Size(72, 12);
            this.label_ElvUIVersion.TabIndex = 17;
            this.label_ElvUIVersion.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Label_ElvUI_UpdateAvailable
            // 
            this.Label_ElvUI_UpdateAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_ElvUI_UpdateAvailable.BackColor = System.Drawing.Color.Transparent;
            this.Label_ElvUI_UpdateAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ElvUI_UpdateAvailable.ForeColor = System.Drawing.Color.Black;
            this.Label_ElvUI_UpdateAvailable.Image = global::SMOSK_2._0.Properties.Resources.NrUpdates;
            this.Label_ElvUI_UpdateAvailable.Location = new System.Drawing.Point(380, 456);
            this.Label_ElvUI_UpdateAvailable.Name = "Label_ElvUI_UpdateAvailable";
            this.Label_ElvUI_UpdateAvailable.Size = new System.Drawing.Size(20, 20);
            this.Label_ElvUI_UpdateAvailable.TabIndex = 16;
            this.Label_ElvUI_UpdateAvailable.Text = "1";
            this.Label_ElvUI_UpdateAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_ElvUI_UpdateAvailable.Visible = false;
            // 
            // button_ElvUI
            // 
            this.button_ElvUI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ElvUI.BackColor = System.Drawing.Color.Black;
            this.button_ElvUI.BackgroundImage = global::SMOSK_2._0.Properties.Resources.ElvUI_notInstalled;
            this.button_ElvUI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_ElvUI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ElvUI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ElvUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ElvUI.ForeColor = System.Drawing.Color.Silver;
            this.button_ElvUI.Location = new System.Drawing.Point(400, 470);
            this.button_ElvUI.Name = "button_ElvUI";
            this.button_ElvUI.Padding = new System.Windows.Forms.Padding(1);
            this.button_ElvUI.Size = new System.Drawing.Size(100, 40);
            this.button_ElvUI.TabIndex = 16;
            this.button_ElvUI.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button_ElvUI.UseVisualStyleBackColor = false;
            this.button_ElvUI.Click += new System.EventHandler(this.button_ElvUI_Click);
            this.button_ElvUI.MouseEnter += new System.EventHandler(this.Buttons_MouseEnter);
            this.button_ElvUI.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            // 
            // progressBarUpdate
            // 
            this.progressBarUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarUpdate.BackColor = System.Drawing.Color.Black;
            this.progressBarUpdate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBarUpdate.Location = new System.Drawing.Point(661, 513);
            this.progressBarUpdate.Name = "progressBarUpdate";
            this.progressBarUpdate.Size = new System.Drawing.Size(135, 7);
            this.progressBarUpdate.Step = 1;
            this.progressBarUpdate.TabIndex = 1;
            this.progressBarUpdate.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.buttonSplitPath);
            this.Controls.Add(this.ButtonImport);
            this.Controls.Add(this.LabelVersion);
            this.Controls.Add(this.ButtonUpdateAll);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.LabelNrUpdates);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.Button_OpenSearch);
            this.Controls.Add(this.label_GamePathHeader);
            this.Controls.Add(this.Button_BrowsPath);
            this.Controls.Add(this.Label_GamePath);
            this.Controls.Add(this.panelBackground);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 595);
            this.Name = "MainForm";
            this.Text = "SMOSK-C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeBegin += new System.EventHandler(this.MainForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged_1);
            this.tabControl1.ResumeLayout(false);
            this.tabTBC.ResumeLayout(false);
            this.tabClassic.ResumeLayout(false);
            this.tabRetail.ResumeLayout(false);
            this.panelBackground.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tabClassic;
        private System.Windows.Forms.TabPage tabRetail;
        private System.Windows.Forms.ListView ClassicListView;
        private System.Windows.Forms.ListView RetailListView;
        private System.Windows.Forms.Label Label_GamePath;
        private System.Windows.Forms.Button Button_BrowsPath;
        private System.Windows.Forms.Button Button_OpenSearch;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.ProgressBar progressBarUpdate;
        private System.Windows.Forms.Label LabelNrUpdates;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button ButtonUpdateAll;
        private System.Windows.Forms.Label LabelVersion;
        private System.Windows.Forms.Button ButtonImport;
        private System.Windows.Forms.ToolTip toolTipDelete;
        private System.Windows.Forms.ToolTip toolTipImport;
        private System.Windows.Forms.ToolTip toolTipUppdateAll;
        private System.Windows.Forms.ToolTip toolTipUpdateSelected;
        private System.Windows.Forms.ToolTip toolTipSearch;
        private System.Windows.Forms.ToolTip toolTipRefresh;
        private System.Windows.Forms.ToolTip toolTipBrows;
        private System.Windows.Forms.Label label_GamePathHeader;
        private System.Windows.Forms.Button buttonSplitPath;
        private System.Windows.Forms.ToolTip toolTipSplitPath;
        private System.Windows.Forms.TabPage tabTBC;
        private System.Windows.Forms.ListView TBCListView;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Button button_ElvUI;
        private System.Windows.Forms.Label Label_ElvUI_UpdateAvailable;
        private System.Windows.Forms.Label label_ElvUIVersion;
    }
}

