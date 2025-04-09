using System;

namespace MunicipalServiceApp2
{
    partial class ServiceRequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceRequestForm));
            this.lblText = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbRequestType = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtRequestDesc = new System.Windows.Forms.TextBox();
            this.btnSubmitRequest = new System.Windows.Forms.Button();
            this.lblPending = new System.Windows.Forms.Label();
            this.lstRequests = new System.Windows.Forms.ListBox();
            this.btnProcessNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblText.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(106, 29);
            this.lblText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(577, 30);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Municipal Service Requests";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblType.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(106, 80);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(296, 30);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "\tRequest Type:";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbRequestType
            // 
            this.cmbRequestType.FormattingEnabled = true;
            this.cmbRequestType.Items.AddRange(new object[] {
            "Road Repair",
            "Water Leak",
            "Electricity Outage",
            "Garbage Collection",
            "",
            "",
            "Emergency (for priority demo)"});
            this.cmbRequestType.Location = new System.Drawing.Point(106, 125);
            this.cmbRequestType.Name = "cmbRequestType";
            this.cmbRequestType.Size = new System.Drawing.Size(732, 24);
            this.cmbRequestType.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescription.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(106, 166);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(266, 30);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtRequestDesc
            // 
            this.txtRequestDesc.Location = new System.Drawing.Point(108, 212);
            this.txtRequestDesc.Multiline = true;
            this.txtRequestDesc.Name = "txtRequestDesc";
            this.txtRequestDesc.Size = new System.Drawing.Size(729, 43);
            this.txtRequestDesc.TabIndex = 5;
            // 
            // btnSubmitRequest
            // 
            this.btnSubmitRequest.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSubmitRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitRequest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmitRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSubmitRequest.Location = new System.Drawing.Point(335, 273);
            this.btnSubmitRequest.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmitRequest.Name = "btnSubmitRequest";
            this.btnSubmitRequest.Size = new System.Drawing.Size(220, 58);
            this.btnSubmitRequest.TabIndex = 8;
            this.btnSubmitRequest.Text = "Submit Request";
            this.btnSubmitRequest.UseVisualStyleBackColor = false;
            this.btnSubmitRequest.Click += new System.EventHandler(this.btnSubmitRequest_Click);
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPending.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPending.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPending.Location = new System.Drawing.Point(106, 372);
            this.lblPending.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(378, 30);
            this.lblPending.TabIndex = 9;
            this.lblPending.Text = "Pending Requests";
            this.lblPending.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstRequests
            // 
            this.lstRequests.FormattingEnabled = true;
            this.lstRequests.ItemHeight = 16;
            this.lstRequests.Location = new System.Drawing.Point(102, 419);
            this.lstRequests.Name = "lstRequests";
            this.lstRequests.Size = new System.Drawing.Size(734, 36);
            this.lstRequests.TabIndex = 10;
            // 
            // btnProcessNext
            // 
            this.btnProcessNext.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnProcessNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcessNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProcessNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnProcessNext.Location = new System.Drawing.Point(335, 479);
            this.btnProcessNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcessNext.Name = "btnProcessNext";
            this.btnProcessNext.Size = new System.Drawing.Size(220, 58);
            this.btnProcessNext.TabIndex = 11;
            this.btnProcessNext.Text = "Process Next Request";
            this.btnProcessNext.UseVisualStyleBackColor = false;
            // 
            // ServiceRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(976, 619);
            this.Controls.Add(this.btnProcessNext);
            this.Controls.Add(this.lstRequests);
            this.Controls.Add(this.lblPending);
            this.Controls.Add(this.btnSubmitRequest);
            this.Controls.Add(this.txtRequestDesc);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.cmbRequestType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblText);
            this.Name = "ServiceRequestForm";
            this.Text = "ServiceRequestForm";
            this.Load += new System.EventHandler(this.ServiceRequestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ServiceRequestForm_Load(object sender, EventArgs e)
        {
            // Initialize form components or load data
            cmbRequestType.SelectedIndex = 0; // Set default selection for combo box
            lstRequests.Items.Clear(); // Clear any existing items in the list box
        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbRequestType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtRequestDesc;
        private System.Windows.Forms.Button btnSubmitRequest;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.ListBox lstRequests;
        private System.Windows.Forms.Button btnProcessNext;
    }
}