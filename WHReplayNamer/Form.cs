using System;
using System.Windows.Forms;

namespace WHReplayNamer
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            this.playerFaction.SelectedIndex = 0;
            this.opposingFaction.SelectedIndex = 0;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string playerFaction = this.playerFaction.GetItemText(this.playerFaction.SelectedItem);
            string opposingFaction = this.opposingFaction.GetItemText(this.opposingFaction.SelectedItem);
            string notes = this.notes.Text;
            DateTime now = DateTime.Now;
            string timeString = now.ToString("MMMM dd yyyy HHmm");
            string replayString = playerFaction + " vs " + opposingFaction + " - " + timeString;
            if (notes.Length > 0)
            {
                replayString += " - " + notes;
            }
            Clipboard.SetText(replayString);
            MessageBox.Show(replayString, "Copied to clipboard.");
        }
    }
}
