using System;
using System.Windows.Forms;

namespace MunicipalServiceApp2
{
    partial class AnalyticsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalyticsForm));
            this.lblText = new System.Windows.Forms.Label();
            this.lvStats = new System.Windows.Forms.ListView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.Metric = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblText.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(248, 28);
            this.lblText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(440, 30);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "Analytics Dashboard\r\n";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblText.Click += new System.EventHandler(this.lblText_Click);
            // 
            // lvStats
            // 
            this.lvStats.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Metric,
            this.Value});
            this.lvStats.HideSelection = false;
            this.lvStats.Location = new System.Drawing.Point(248, 87);
            this.lvStats.Name = "lvStats";
            this.lvStats.Size = new System.Drawing.Size(440, 195);
            this.lvStats.TabIndex = 3;
            this.lvStats.UseCompatibleStateImageBehavior = false;
            this.lvStats.View = System.Windows.Forms.View.Details;
            this.lvStats.SelectedIndexChanged += new System.EventHandler(this.lvStats_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRefresh.Location = new System.Drawing.Point(355, 321);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(220, 58);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh Analytics";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // Metric
            // 
            this.Metric.Width = 122;
            // 
            // Value
            // 
            this.Value.Width = 128;
            // 
            // AnalyticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(976, 619);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lvStats);
            this.Controls.Add(this.lblText);
            this.Name = "AnalyticsForm";
            this.Text = "AnalyticsForm";
            this.Load += new System.EventHandler(this.AnalyticsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void AnalyticsForm_Load(object sender, EventArgs e)
        {
            // Initialize the ListView with some sample data
            lvStats.Items.Add(new ListViewItem(new[] { "Total Users", "1500" }));
            lvStats.Items.Add(new ListViewItem(new[] { "Active Sessions", "300" }));
            lvStats.Items.Add(new ListViewItem(new[] { "Error Rate", "0.5%" }));
        }

        private void lblText_Click(object sender, EventArgs e)
        {
            // Handle label click event, for example, show a message box
            MessageBox.Show("Analytics Dashboard clicked!");
        }

        private void lvStats_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle list view item selection change event
            if (lvStats.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvStats.SelectedItems[0];
                MessageBox.Show($"Selected Metric: {selectedItem.Text}, Value: {selectedItem.SubItems[1].Text}");
            }
        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.ListView lvStats;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ColumnHeader Metric;
        private System.Windows.Forms.ColumnHeader Value;
    }
}