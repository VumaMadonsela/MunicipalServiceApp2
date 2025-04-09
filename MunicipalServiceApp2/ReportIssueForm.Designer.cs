using System;

namespace MunicipalServiceApp2
{
    partial class ReportIssueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportIssueForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblIssueTitle = new System.Windows.Forms.Label();
            this.txtIssueTitle = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblLetest = new System.Windows.Forms.Label();
            this.lstIssues = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Wide Latin", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(89, 29);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(390, 35);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Report an Issue";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIssueTitle
            // 
            this.lblIssueTitle.AutoSize = true;
            this.lblIssueTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblIssueTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIssueTitle.Font = new System.Drawing.Font("Wide Latin", 16F, System.Drawing.FontStyle.Bold);
            this.lblIssueTitle.Location = new System.Drawing.Point(89, 88);
            this.lblIssueTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIssueTitle.Name = "lblIssueTitle";
            this.lblIssueTitle.Size = new System.Drawing.Size(281, 35);
            this.lblIssueTitle.TabIndex = 3;
            this.lblIssueTitle.Text = "Issue Title:";
            this.lblIssueTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtIssueTitle
            // 
            this.txtIssueTitle.Location = new System.Drawing.Point(89, 136);
            this.txtIssueTitle.Name = "txtIssueTitle";
            this.txtIssueTitle.Size = new System.Drawing.Size(815, 22);
            this.txtIssueTitle.TabIndex = 4;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDesc.Font = new System.Drawing.Font("Wide Latin", 16F, System.Drawing.FontStyle.Bold);
            this.lblDesc.Location = new System.Drawing.Point(89, 179);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(313, 35);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "\tDescription:";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(89, 235);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(817, 44);
            this.txtDescription.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSubmit.Location = new System.Drawing.Point(377, 286);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(220, 58);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // lblLetest
            // 
            this.lblLetest.AutoSize = true;
            this.lblLetest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLetest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetest.Font = new System.Drawing.Font("Wide Latin", 16F, System.Drawing.FontStyle.Bold);
            this.lblLetest.Location = new System.Drawing.Point(89, 361);
            this.lblLetest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLetest.Name = "lblLetest";
            this.lblLetest.Size = new System.Drawing.Size(345, 35);
            this.lblLetest.TabIndex = 9;
            this.lblLetest.Text = "Latest Issues:";
            this.lblLetest.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstIssues
            // 
            this.lstIssues.FormattingEnabled = true;
            this.lstIssues.ItemHeight = 16;
            this.lstIssues.Location = new System.Drawing.Point(89, 414);
            this.lstIssues.Name = "lstIssues";
            this.lstIssues.Size = new System.Drawing.Size(822, 36);
            this.lstIssues.TabIndex = 10;
            // 
            // ReportIssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(976, 619);
            this.Controls.Add(this.lstIssues);
            this.Controls.Add(this.lblLetest);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtIssueTitle);
            this.Controls.Add(this.lblIssueTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "ReportIssueForm";
            this.Text = "ReportIssueForm";
            this.Load += new System.EventHandler(this.ReportIssueForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ReportIssueForm_Load(object sender, EventArgs e)
        {
            // Example implementation
            // Initialize form components or load data here
            this.Text = "Report Issue Form";
            
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblIssueTitle;
        private System.Windows.Forms.TextBox txtIssueTitle;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblLetest;
        private System.Windows.Forms.ListBox lstIssues;
    }
}