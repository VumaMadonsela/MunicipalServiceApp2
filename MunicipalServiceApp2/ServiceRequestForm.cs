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
    public partial class ServiceRequestForm : Form
    {
        // Priority queue simulation using SortedDictionary
        private SortedDictionary<int, Queue<string>> priorityRequests = new SortedDictionary<int, Queue<string>>();

        // 🔍 Track submitted types for analytics
        public static List<string> submittedTypes = new List<string>();

        public ServiceRequestForm()
        {
            InitializeComponent();
            PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            cmbRequestType.Items.AddRange(new string[]
            {
                "Road Repair",
                "Water Leak",
                "Electricity Outage",
                "Garbage Collection",
                "Emergency"
            });
            cmbRequestType.SelectedIndex = 0;
        }

        private int GetPriority(string type)
        {
            return type == "Emergency" ? 0 : 1;
        }

        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            string type = cmbRequestType.SelectedItem.ToString();
            string desc = txtRequestDesc.Text.Trim();

            if (string.IsNullOrEmpty(desc))
            {
                MessageBox.Show("Please provide a description.");
                return;
            }

            int priority = GetPriority(type);
            string request = $"[{DateTime.Now:HH:mm}] {type}: {desc}";

            if (!priorityRequests.ContainsKey(priority))
                priorityRequests[priority] = new Queue<string>();

            priorityRequests[priority].Enqueue(request);

            // ✅ Track request type for analytics
            submittedTypes.Add(type);

            UpdateRequestList();
            txtRequestDesc.Clear();
        }

        private void UpdateRequestList()
        {
            lstRequests.Items.Clear();
            foreach (var pair in priorityRequests)
            {
                foreach (var request in pair.Value)
                    lstRequests.Items.Add($"Priority {pair.Key}: {request}");
            }
        }

        private void btnProcessNext_Click(object sender, EventArgs e)
        {
            foreach (var pair in priorityRequests)
            {
                if (pair.Value.Count > 0)
                {
                    string next = pair.Value.Dequeue();
                    MessageBox.Show($"Processing:\n{next}", "Service Request Processed");

                    if (pair.Value.Count == 0)
                        priorityRequests.Remove(pair.Key);

                    break;
                }
            }

            UpdateRequestList();
        }
    }
}

