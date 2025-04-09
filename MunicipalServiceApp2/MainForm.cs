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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = "Municipal Service Menu";
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            var reportForm = new ReportIssueForm();
            reportForm.ShowDialog();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            var eventsForm = new EventsForm();
            eventsForm.ShowDialog();
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            var requestForm = new ServiceRequestForm();
            requestForm.ShowDialog();
        }
    }
}
