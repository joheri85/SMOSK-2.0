
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabClassic = new System.Windows.Forms.TabPage();
            this.ClassicListView = new System.Windows.Forms.ListView();
            this.tabRetail = new System.Windows.Forms.TabPage();
            this.RetailListView = new System.Windows.Forms.ListView();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.DetailsBox = new System.Windows.Forms.RichTextBox();
            this.Label_GamePath = new System.Windows.Forms.Label();
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
            this.tabRetail.Location = new System.Drawing.Point(4, 22);
            this.tabRetail.Name = "tabRetail";
            this.tabRetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabRetail.Size = new System.Drawing.Size(768, 292);
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
            this.RetailListView.Size = new System.Drawing.Size(756, 280);
            this.RetailListView.TabIndex = 0;
            this.RetailListView.UseCompatibleStateImageBehavior = false;
            this.RetailListView.View = System.Windows.Forms.View.Details;
            this.RetailListView.Click += new System.EventHandler(this.RetailListView_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshButton.Location = new System.Drawing.Point(709, 446);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 98);
            this.RefreshButton.TabIndex = 1;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.GetAddonManifest);
            // 
            // DetailsBox
            // 
            this.DetailsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DetailsBox.BackColor = System.Drawing.SystemColors.Control;
            this.DetailsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetailsBox.Enabled = false;
            this.DetailsBox.Location = new System.Drawing.Point(12, 446);
            this.DetailsBox.Name = "DetailsBox";
            this.DetailsBox.Size = new System.Drawing.Size(691, 58);
            this.DetailsBox.TabIndex = 2;
            this.DetailsBox.Text = "";
            // 
            // Label_GamePath
            // 
            this.Label_GamePath.AutoSize = true;
            this.Label_GamePath.Location = new System.Drawing.Point(19, 531);
            this.Label_GamePath.Name = "Label_GamePath";
            this.Label_GamePath.Size = new System.Drawing.Size(0, 13);
            this.Label_GamePath.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.Label_GamePath);
            this.Controls.Add(this.DetailsBox);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

