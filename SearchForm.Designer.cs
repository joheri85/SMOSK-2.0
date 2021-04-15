
namespace SMOSK_2._0
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.SearchFormListView = new System.Windows.Forms.ListView();
            this.Search_Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GameVersionSelector = new System.Windows.Forms.ComboBox();
            this.progressBarInstalling = new System.Windows.Forms.ProgressBar();
            this.ButtonInstallSelected = new System.Windows.Forms.Button();
            this.LabelInstalling = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchFormListView
            // 
            this.SearchFormListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchFormListView.AutoArrange = false;
            this.SearchFormListView.BackColor = System.Drawing.Color.Black;
            this.SearchFormListView.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchFormListView.ForeColor = System.Drawing.Color.White;
            this.SearchFormListView.FullRowSelect = true;
            this.SearchFormListView.HideSelection = false;
            this.SearchFormListView.Location = new System.Drawing.Point(12, 61);
            this.SearchFormListView.Name = "SearchFormListView";
            this.SearchFormListView.Size = new System.Drawing.Size(776, 353);
            this.SearchFormListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.SearchFormListView.TabIndex = 0;
            this.SearchFormListView.UseCompatibleStateImageBehavior = false;
            this.SearchFormListView.View = System.Windows.Forms.View.Details;
            // 
            // Search_Input
            // 
            this.Search_Input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_Input.BackColor = System.Drawing.Color.Black;
            this.Search_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Search_Input.ForeColor = System.Drawing.Color.White;
            this.Search_Input.Location = new System.Drawing.Point(12, 35);
            this.Search_Input.Name = "Search_Input";
            this.Search_Input.Size = new System.Drawing.Size(776, 20);
            this.Search_Input.TabIndex = 1;
            this.Search_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_Input_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search CuresForge for addons";
            // 
            // GameVersionSelector
            // 
            this.GameVersionSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GameVersionSelector.BackColor = System.Drawing.Color.Black;
            this.GameVersionSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GameVersionSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GameVersionSelector.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameVersionSelector.ForeColor = System.Drawing.Color.White;
            this.GameVersionSelector.FormattingEnabled = true;
            this.GameVersionSelector.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.GameVersionSelector.Items.AddRange(new object[] {
            "Classic",
            "TBC",
            "Retail"});
            this.GameVersionSelector.Location = new System.Drawing.Point(667, 8);
            this.GameVersionSelector.Name = "GameVersionSelector";
            this.GameVersionSelector.Size = new System.Drawing.Size(121, 21);
            this.GameVersionSelector.TabIndex = 3;
            this.GameVersionSelector.SelectedIndexChanged += new System.EventHandler(this.GameVersionSelector_SelectedIndexChanged);
            // 
            // progressBarInstalling
            // 
            this.progressBarInstalling.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarInstalling.BackColor = System.Drawing.Color.Black;
            this.progressBarInstalling.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBarInstalling.Location = new System.Drawing.Point(574, 420);
            this.progressBarInstalling.Name = "progressBarInstalling";
            this.progressBarInstalling.Size = new System.Drawing.Size(182, 23);
            this.progressBarInstalling.Step = 1;
            this.progressBarInstalling.TabIndex = 6;
            this.progressBarInstalling.Visible = false;
            // 
            // ButtonInstallSelected
            // 
            this.ButtonInstallSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonInstallSelected.BackColor = System.Drawing.Color.Black;
            this.ButtonInstallSelected.BackgroundImage = global::SMOSK_2._0.Properties.Resources.Context_update2;
            this.ButtonInstallSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonInstallSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonInstallSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInstallSelected.ForeColor = System.Drawing.Color.White;
            this.ButtonInstallSelected.Location = new System.Drawing.Point(762, 420);
            this.ButtonInstallSelected.Name = "ButtonInstallSelected";
            this.ButtonInstallSelected.Size = new System.Drawing.Size(26, 23);
            this.ButtonInstallSelected.TabIndex = 10;
            this.ButtonInstallSelected.UseVisualStyleBackColor = false;
            this.ButtonInstallSelected.Click += new System.EventHandler(this.ButtonInstallSelected_Click);
            // 
            // LabelInstalling
            // 
            this.LabelInstalling.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelInstalling.BackColor = System.Drawing.Color.Black;
            this.LabelInstalling.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInstalling.ForeColor = System.Drawing.Color.White;
            this.LabelInstalling.Location = new System.Drawing.Point(12, 61);
            this.LabelInstalling.Name = "LabelInstalling";
            this.LabelInstalling.Size = new System.Drawing.Size(776, 353);
            this.LabelInstalling.TabIndex = 11;
            this.LabelInstalling.Text = "Placeholdertext";
            this.LabelInstalling.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelInstalling.Visible = false;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SMOSK_2._0.Properties.Resources.wallpaper_seamless;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelInstalling);
            this.Controls.Add(this.ButtonInstallSelected);
            this.Controls.Add(this.progressBarInstalling);
            this.Controls.Add(this.GameVersionSelector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search_Input);
            this.Controls.Add(this.SearchFormListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView SearchFormListView;
        private System.Windows.Forms.TextBox Search_Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox GameVersionSelector;
        private System.Windows.Forms.ProgressBar progressBarInstalling;
        private System.Windows.Forms.Button ButtonInstallSelected;
        private System.Windows.Forms.Label LabelInstalling;
    }
}