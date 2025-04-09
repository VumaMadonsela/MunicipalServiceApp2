using System;
using System.Windows.Forms;

namespace MunicipalServiceApp2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblText = new System.Windows.Forms.Label();
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnRequests = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblText.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(245, 9);
            this.lblText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(506, 30);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Municipal Service Menu";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblText.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnReportIssues
            // 
            this.btnReportIssues.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnReportIssues.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportIssues.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReportIssues.Location = new System.Drawing.Point(382, 78);
            this.btnReportIssues.Margin = new System.Windows.Forms.Padding(4);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new System.Drawing.Size(220, 58);
            this.btnReportIssues.TabIndex = 1;
            this.btnReportIssues.Text = "\tReport Issues";
            this.btnReportIssues.UseVisualStyleBackColor = false;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEvents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEvents.Location = new System.Drawing.Point(382, 161);
            this.btnEvents.Margin = new System.Windows.Forms.Padding(4);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(220, 58);
            this.btnEvents.TabIndex = 2;
            this.btnEvents.Text = "\tEvents n Announcements";
            this.btnEvents.UseVisualStyleBackColor = false;
            // 
            // btnRequests
            // 
            this.btnRequests.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRequests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRequests.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRequests.Location = new System.Drawing.Point(382, 240);
            this.btnRequests.Margin = new System.Windows.Forms.Padding(4);
            this.btnRequests.Name = "btnRequests";
            this.btnRequests.Size = new System.Drawing.Size(220, 58);
            this.btnRequests.TabIndex = 3;
            this.btnRequests.Text = "Service Request\r\n\r\n";
            this.btnRequests.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(976, 619);
            this.Controls.Add(this.btnRequests);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnReportIssues);
            this.Controls.Add(this.lblText);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "btnReportIssues";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportIssueForm reportIssueForm = new ReportIssueForm();
            reportIssueForm.Show();  // This will show the new form
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EventsForm eventform = new EventsForm();
            eventform.Show();  
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceRequestForm serviceRequestForm = new ServiceRequestForm();
            serviceRequestForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AnalyticsForm analyticsForm = new AnalyticsForm();
            analyticsForm.Show();  
        }
        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnRequests;
    }
}

