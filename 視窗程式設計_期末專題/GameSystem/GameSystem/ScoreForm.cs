using System;
using System.Windows.Forms;

namespace GameSystem
{
    public partial class ScoreForm : Form
    {
        public ScoreForm()
        {
            InitializeComponent();
            LoadScores();
        }

        private void LoadScores()
        {
            lstScores.Items.Clear();
            foreach (var record in GameData.ScoreHistory)
            {
                lstScores.Items.Add(record);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            GameData.ScoreHistory.Clear();
            lstScores.Items.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

