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
    public partial class EventsForm : Form
    {
        SortedDictionary<DateTime, List<Event>> eventsByDate = new SortedDictionary<DateTime, List<Event>>();
        Dictionary<string, int> searchFrequency = new Dictionary<string, int>();

        public EventsForm()
        {
            InitializeComponent();
            SeedEvents();
            DisplayAllEvents();
        }

        private void SeedEvents()
        {
            AddEvent(new Event { Title = "Youth Summit", Category = "Education", Date = DateTime.Today.AddDays(1), Description = "Empowering youth with knowledge" });
            AddEvent(new Event { Title = "Farmers Market", Category = "Commerce", Date = DateTime.Today.AddDays(3), Description = "Support local farmers" });
        }

        private void AddEvent(Event e)
        {
            if (!eventsByDate.ContainsKey(e.Date))
                eventsByDate[e.Date] = new List<Event>();

            eventsByDate[e.Date].Add(e);
        }

        private void DisplayAllEvents()
        {
            lstEvents.Items.Clear();
            foreach (var day in eventsByDate)
            {
                foreach (var evt in day.Value)
                    lstEvents.Items.Add(evt);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var category = txtCategory.Text.Trim();
            var date = dtpDate.Value.Date;
            var results = SearchEvents(category, date);

            lstEvents.Items.Clear();
            foreach (var evt in results)
                lstEvents.Items.Add(evt);

            ShowRecommendations();
        }

        private List<Event> SearchEvents(string category, DateTime date)
        {
            List<Event> results = new List<Event>();

            foreach (var kvp in eventsByDate)
            {
                if (kvp.Key.Date == date)
                {
                    foreach (var e in kvp.Value)
                    {
                        if (e.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
                            results.Add(e);
                    }
                }
            }

            if (searchFrequency.ContainsKey(category))
                searchFrequency[category]++;
            else
                searchFrequency[category] = 1;

            return results;
        }

        private void ShowRecommendations()
        {
            lstRecommendations.Items.Clear();

            if (searchFrequency.Count == 0) return;

            var topCategory = searchFrequency.OrderByDescending(k => k.Value).First().Key;

            foreach (var kvp in eventsByDate)
            {
                foreach (var e in kvp.Value)
                {
                    if (e.Category == topCategory)
                        lstRecommendations.Items.Add($"Recommended: {e}");
                }
            }
        }
    }
}
