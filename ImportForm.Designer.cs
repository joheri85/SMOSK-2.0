
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.ImportFormListView = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.ImportProgressbar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(12, 23);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(452, 20);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Scan";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ImportProgressbar
            // 
            this.ImportProgressbar.Location = new System.Drawing.Point(13, 406);
            this.ImportProgressbar.Name = "ImportProgressbar";
            this.ImportProgressbar.Size = new System.Drawing.Size(694, 32);
            this.ImportProgressbar.TabIndex = 7;
            this.ImportProgressbar.Visible = false;
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SMOSK_2._0.Properties.Resources.Wall_color;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ImportProgressbar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.ImportFormListView);
            this.Name = "ImportForm";
            this.Text = "ImportForm";
            this.Load += new System.EventHandler(this.ImportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListView ImportFormListView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar ImportProgressbar;
    }
}