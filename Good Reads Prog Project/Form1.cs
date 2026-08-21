namespace Good_Reads_Prog_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void minSideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Form1 nyForm = new Form1();
            nyForm.Show();
            this.Hide();*/
        }

        private void anbefalingerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anbefalinger nyForm = new Anbefalinger();
            nyForm.Show();
            this.Hide();
        }

        private void plusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label_In_Progress_Click(object sender, EventArgs e)
        {

        }

        private void label_TBR_Click(object sender, EventArgs e)
        {

        }

        private void label_Read_Click(object sender, EventArgs e)
        {

        }

        private void listBox_In_Progress_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox_TBR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox_Read_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
