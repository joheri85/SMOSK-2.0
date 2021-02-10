
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
            this.SearchFormListView = new System.Windows.Forms.ListView();
            this.Search_Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchFormListView
            // 
            this.SearchFormListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchFormListView.AutoArrange = false;
            this.SearchFormListView.BackColor = System.Drawing.Color.Black;
            this.SearchFormListView.ForeColor = System.Drawing.Color.White;
            this.SearchFormListView.FullRowSelect = true;
            this.SearchFormListView.HideSelection = false;
            this.SearchFormListView.Location = new System.Drawing.Point(12, 61);
            this.SearchFormListView.Name = "SearchFormListView";
            this.SearchFormListView.Size = new System.Drawing.Size(776, 353);
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
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SMOSK_2._0.Properties.Resources.wallpaper_seamless;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search_Input);
            this.Controls.Add(this.SearchFormListView);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView SearchFormListView;
        private System.Windows.Forms.TextBox Search_Input;
        private System.Windows.Forms.Label label1;
    }
}