
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabClassic = new System.Windows.Forms.TabPage();
            this.ClassicListView = new System.Windows.Forms.ListView();
            this.tabRetail = new System.Windows.Forms.TabPage();
            this.RetailListView = new System.Windows.Forms.ListView();
            this.Label_GamePath = new System.Windows.Forms.Label();
            this.Button_BrowsPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.Button_OpenSearch = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.LabelUpdating = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabClassic.SuspendLayout();
            this.tabRetail.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabClassic);
            this.tabControl1.Controls.Add(this.tabRetail);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(-3, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 465);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabClassic
            // 
            this.tabClassic.Controls.Add(this.LabelUpdating);
            this.tabClassic.Controls.Add(this.ClassicListView);
            this.tabClassic.Location = new System.Drawing.Point(4, 22);
            this.tabClassic.Name = "tabClassic";
            this.tabClassic.Padding = new System.Windows.Forms.Padding(3);
            this.tabClassic.Size = new System.Drawing.Size(774, 439);
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
            this.ClassicListView.ForeColor = System.Drawing.Color.Black;
            this.ClassicListView.FullRowSelect = true;
            this.ClassicListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ClassicListView.HideSelection = false;
            this.ClassicListView.Location = new System.Drawing.Point(-4, 0);
            this.ClassicListView.Name = "ClassicListView";
            this.ClassicListView.Size = new System.Drawing.Size(778, 443);
            this.ClassicListView.TabIndex = 0;
            this.ClassicListView.UseCompatibleStateImageBehavior = false;
            this.ClassicListView.View = System.Windows.Forms.View.Details;
            // 
            // tabRetail
            // 
            this.tabRetail.Controls.Add(this.RetailListView);
            this.tabRetail.Location = new System.Drawing.Point(4, 22);
            this.tabRetail.Name = "tabRetail";
            this.tabRetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabRetail.Size = new System.Drawing.Size(774, 439);
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
            this.RetailListView.FullRowSelect = true;
            this.RetailListView.HideSelection = false;
            this.RetailListView.Location = new System.Drawing.Point(-4, 0);
            this.RetailListView.Name = "RetailListView";
            this.RetailListView.Size = new System.Drawing.Size(778, 443);
            this.RetailListView.TabIndex = 0;
            this.RetailListView.UseCompatibleStateImageBehavior = false;
            this.RetailListView.View = System.Windows.Forms.View.Details;
            // 
            // Label_GamePath
            // 
            this.Label_GamePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label_GamePath.AutoEllipsis = true;
            this.Label_GamePath.BackColor = System.Drawing.Color.Black;
            this.Label_GamePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_GamePath.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_GamePath.ForeColor = System.Drawing.Color.White;
            this.Label_GamePath.Location = new System.Drawing.Point(39, 519);
            this.Label_GamePath.MinimumSize = new System.Drawing.Size(350, 25);
            this.Label_GamePath.Name = "Label_GamePath";
            this.Label_GamePath.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Label_GamePath.Size = new System.Drawing.Size(351, 25);
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
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "World of Warcraft root path";
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
            this.RefreshButton.Location = new System.Drawing.Point(751, 9);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(25, 25);
            this.RefreshButton.TabIndex = 1;
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.GetAddonManifest);
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
            this.ButtonDelete.Location = new System.Drawing.Point(620, 504);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(40, 40);
            this.ButtonDelete.TabIndex = 7;
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.RefreshButton);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 482);
            this.panel1.TabIndex = 8;
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
            // 
            // LabelUpdating
            // 
            this.LabelUpdating.BackColor = System.Drawing.Color.Black;
            this.LabelUpdating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelUpdating.ForeColor = System.Drawing.Color.White;
            this.LabelUpdating.Location = new System.Drawing.Point(292, 162);
            this.LabelUpdating.Name = "LabelUpdating";
            this.LabelUpdating.Size = new System.Drawing.Size(182, 58);
            this.LabelUpdating.TabIndex = 1;
            this.LabelUpdating.Text = "Updating selected addons...";
            this.LabelUpdating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelUpdating.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SMOSK_2._0.Properties.Resources.Wall_color;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.Button_OpenSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_BrowsPath);
            this.Controls.Add(this.Label_GamePath);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "SMOSK-C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabClassic.ResumeLayout(false);
            this.tabRetail.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabClassic;
        private System.Windows.Forms.TabPage tabRetail;
        private System.Windows.Forms.ListView ClassicListView;
        private System.Windows.Forms.ListView RetailListView;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label Label_GamePath;
        private System.Windows.Forms.Button Button_BrowsPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_OpenSearch;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Label LabelUpdating;
    }
}

