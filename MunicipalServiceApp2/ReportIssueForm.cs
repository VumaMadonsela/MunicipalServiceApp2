using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalServiceApp2
{
    public partial class ReportIssueForm : Form
    {
        private Queue<string> issueQueue = new Queue<string>();

        public ReportIssueForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string title = txtIssueTitle.Text.Trim();
            string desc = txtDescription.Text.Trim();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(desc))
            {
                MessageBox.Show("Please fill in both fields.");
                return;
            }

            string issueReport = $"[{DateTime.Now.ToShortTimeString()}] {title}: {desc}";
            issueQueue.Enqueue(issueReport);

            UpdateIssueList();

            // Clear inputs
            txtIssueTitle.Clear();
            txtDescription.Clear();
        }

        private void UpdateIssueList()
        {
            lstIssues.Items.Clear();
            foreach (var issue in issueQueue)
            {
                lstIssues.Items.Add(issue);
            }
        }
    }
}
