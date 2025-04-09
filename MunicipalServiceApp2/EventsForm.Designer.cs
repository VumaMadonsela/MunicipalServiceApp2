using System;
using System.Windows.Forms;

namespace MunicipalServiceApp2
{
    partial class EventsForm
    {
       
        private System.ComponentModel.IContainer components = null;

      
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

       
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventsForm));
            this.lblHeader = new System.Windows.Forms.Label();
            this.lstEvents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblRecommend = new System.Windows.Forms.Label();
            this.lstRecommendations = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHeader.Font = new System.Drawing.Font("Wide Latin", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(142, 26);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(702, 35);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Local Event Announcements";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstEvents
            // 
            this.lstEvents.FormattingEnabled = true;
            this.lstEvents.ItemHeight = 16;
            this.lstEvents.Location = new System.Drawing.Point(142, 82);
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(699, 36);
            this.lstEvents.TabIndex = 2;
            this.lstEvents.SelectedIndexChanged += new System.EventHandler(this.lstEvents_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(142, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Category:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(142, 208);
            this.txtCategory.Multiline = true;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(698, 51);
            this.txtCategory.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.Font = new System.Drawing.Font("Wide Latin", 16F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(142, 277);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(141, 35);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(301, 285);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(226, 22);
            this.dtpDate.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSearch.Location = new System.Drawing.Point(142, 339);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(220, 58);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // lblRecommend
            // 
            this.lblRecommend.AutoSize = true;
            this.lblRecommend.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRecommend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRecommend.Font = new System.Drawing.Font("Wide Latin", 16F, System.Drawing.FontStyle.Bold);
            this.lblRecommend.Location = new System.Drawing.Point(142, 415);
            this.lblRecommend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecommend.Name = "lblRecommend";
            this.lblRecommend.Size = new System.Drawing.Size(450, 35);
            this.lblRecommend.TabIndex = 8;
            this.lblRecommend.Text = "Recommendation:";
            this.lblRecommend.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstRecommendations
            // 
            this.lstRecommendations.FormattingEnabled = true;
            this.lstRecommendations.ItemHeight = 16;
            this.lstRecommendations.Location = new System.Drawing.Point(142, 474);
            this.lstRecommendations.Name = "lstRecommendations";
            this.lstRecommendations.Size = new System.Drawing.Size(701, 52);
            this.lstRecommendations.TabIndex = 9;
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(976, 619);
            this.Controls.Add(this.lstRecommendations);
            this.Controls.Add(this.lblRecommend);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstEvents);
            this.Controls.Add(this.lblHeader);
            this.Name = "EventsForm";
            this.Text = "EventsForm";
            this.Load += new System.EventHandler(this.EventsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void EventsForm_Load(object sender, EventArgs e)
        {
         
            LoadEvents();
            LoadRecommendations();
        }

        private void LoadEvents()
        {
            // Example: Load events into lstEvents
            lstEvents.Items.Add("Church event");
            lstEvents.Items.Add("Concert for the Community");
            lstEvents.Items.Add("Sporting events");
        }

        private void LoadRecommendations()
        {
            // Example: Load recommendations into lstRecommendations
            lstRecommendations.Items.Add("Church event");
            lstRecommendations.Items.Add("Concert for the Communit");
            lstRecommendations.Items.Add("Sports events");
        }

        private void lstEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Example implementation
            ListBox listBox = sender as ListBox;
            if (listBox != null && listBox.SelectedItem != null)
            {
                string selectedItem = listBox.SelectedItem.ToString();
                // Handle the selected item
                MessageBox.Show("Selected item: " + selectedItem);
            }
        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ListBox lstEvents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblRecommend;
        private System.Windows.Forms.ListBox lstRecommendations;
    }
}