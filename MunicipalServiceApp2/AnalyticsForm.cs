using System;
using System.Collections;
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
    public partial class AnalyticsForm : Form
    {
        private HashSet<string> uniqueRequestTypes = new HashSet<string>();
        private Hashtable requestTypeCounts = new Hashtable();

        // Simulated data source - replace with real app data later
        public List<string> submittedRequestTypes = new List<string>();

       
        public AnalyticsForm()
        {
            InitializeComponent();
            submittedRequestTypes = ServiceRequestForm.submittedTypes;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshAnalytics();
        }

        private void RefreshAnalytics()
        {
            uniqueRequestTypes.Clear();
            requestTypeCounts.Clear();

            foreach (var type in submittedRequestTypes)
            {
                uniqueRequestTypes.Add(type);

                if (requestTypeCounts.ContainsKey(type))
                    requestTypeCounts[type] = (int)requestTypeCounts[type] + 1;
                else
                    requestTypeCounts[type] = 1;
            }

            DisplayAnalytics();
        }

        private void DisplayAnalytics()
        {
            lvStats.Items.Clear();

            lvStats.Items.Add(new ListViewItem(new[] { "Unique Request Types", uniqueRequestTypes.Count.ToString() }));

            foreach (DictionaryEntry entry in requestTypeCounts)
            {
                lvStats.Items.Add(new ListViewItem(new[] {
                $"Requests of type '{entry.Key}'", entry.Value.ToString()
            }));
            }
        }
    }
}

