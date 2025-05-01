namespace Final_Project
{
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Play_Game game = new Play_Game();
            game.Show();
            Close();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            Statistics stats = new Statistics();
            stats.Show();
            stats.Closed += (s, a) => { Show(); };
            Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
