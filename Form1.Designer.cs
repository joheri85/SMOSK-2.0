
namespace SMOSK_2._0
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabClassic = new System.Windows.Forms.TabPage();
            this.ClassicListView = new System.Windows.Forms.ListView();
            this.tabRetail = new System.Windows.Forms.TabPage();
            this.RetailListView = new System.Windows.Forms.ListView();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.DetailsBox = new System.Windows.Forms.RichTextBox();
            this.Label_GamePath = new System.Windows.Forms.Label();
            this.Button_BrowsPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabClassic.SuspendLayout();
            this.tabRetail.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 428);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabClassic
            // 
            this.tabClassic.Controls.Add(this.ClassicListView);
            this.tabClassic.Location = new System.Drawing.Point(4, 22);
            this.tabClassic.Name = "tabClassic";
            this.tabClassic.Padding = new System.Windows.Forms.Padding(3);
            this.tabClassic.Size = new System.Drawing.Size(768, 402);
            this.tabClassic.TabIndex = 0;
            this.tabClassic.Text = "Classic";
            this.tabClassic.UseVisualStyleBackColor = true;
            // 
            // ClassicListView
            // 
            this.ClassicListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassicListView.FullRowSelect = true;
            this.ClassicListView.HideSelection = false;
            this.ClassicListView.Location = new System.Drawing.Point(6, 6);
            this.ClassicListView.Name = "ClassicListView";
            this.ClassicListView.Size = new System.Drawing.Size(756, 390);
            this.ClassicListView.TabIndex = 0;
            this.ClassicListView.UseCompatibleStateImageBehavior = false;
            this.ClassicListView.View = System.Windows.Forms.View.Details;
            this.ClassicListView.Click += new System.EventHandler(this.ClassicListView_Click);
            // 
            // tabRetail
            // 
            this.tabRetail.Controls.Add(this.RetailListView);
            this.tabRetail.Location = new System.Drawing.Point(4, 25);
            this.tabRetail.Name = "tabRetail";
            this.tabRetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabRetail.Size = new System.Drawing.Size(768, 399);
            this.tabRetail.TabIndex = 1;
            this.tabRetail.Text = "Retail";
            this.tabRetail.UseVisualStyleBackColor = true;
            // 
            // RetailListView
            // 
            this.RetailListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RetailListView.FullRowSelect = true;
            this.RetailListView.HideSelection = false;
            this.RetailListView.Location = new System.Drawing.Point(6, 6);
            this.RetailListView.Name = "RetailListView";
            this.RetailListView.Size = new System.Drawing.Size(756, 387);
            this.RetailListView.TabIndex = 0;
            this.RetailListView.UseCompatibleStateImageBehavior = false;
            this.RetailListView.View = System.Windows.Forms.View.Details;
            this.RetailListView.Click += new System.EventHandler(this.RetailListView_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshButton.BackgroundImage = global::SMOSK_2._0.Properties.Resources.refresh;
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshButton.Location = new System.Drawing.Point(763, 3);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(25, 25);
            this.RefreshButton.TabIndex = 1;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.GetAddonManifest);
            // 
            // DetailsBox
            // 
            this.DetailsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DetailsBox.BackColor = System.Drawing.SystemColors.Control;
            this.DetailsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetailsBox.Enabled = false;
            this.DetailsBox.Location = new System.Drawing.Point(12, 436);
            this.DetailsBox.Name = "DetailsBox";
            this.DetailsBox.Size = new System.Drawing.Size(691, 58);
            this.DetailsBox.TabIndex = 2;
            this.DetailsBox.Text = "";
            // 
            // Label_GamePath
            // 
            this.Label_GamePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label_GamePath.AutoEllipsis = true;
            this.Label_GamePath.AutoSize = true;
            this.Label_GamePath.Location = new System.Drawing.Point(43, 525);
            this.Label_GamePath.Name = "Label_GamePath";
            this.Label_GamePath.Size = new System.Drawing.Size(0, 13);
            this.Label_GamePath.TabIndex = 3;
            this.Label_GamePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Button_BrowsPath
            // 
            this.Button_BrowsPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_BrowsPath.Location = new System.Drawing.Point(12, 519);
            this.Button_BrowsPath.Name = "Button_BrowsPath";
            this.Button_BrowsPath.Size = new System.Drawing.Size(25, 25);
            this.Button_BrowsPath.TabIndex = 4;
            this.Button_BrowsPath.Text = "...";
            this.Button_BrowsPath.UseVisualStyleBackColor = true;
            this.Button_BrowsPath.Click += new System.EventHandler(this.Button_BrowsPath_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "World of Warcraft root path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.Button_BrowsPath);
            this.Controls.Add(this.Label_GamePath);
            this.Controls.Add(this.DetailsBox);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SMOSK-C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabClassic.ResumeLayout(false);
            this.tabRetail.ResumeLayout(false);
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
        private System.Windows.Forms.RichTextBox DetailsBox;
        private System.Windows.Forms.Label Label_GamePath;
        private System.Windows.Forms.Button Button_BrowsPath;
        private System.Windows.Forms.Label label1;
    }
}

