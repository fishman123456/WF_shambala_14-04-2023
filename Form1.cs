namespace WF_shambala_14_04_2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateColor();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }
        public void UpdateColor()
        {
            this.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            this.label1.Text = "B - " + trackBar1.Value.ToString();
            progressBar1.Value = trackBar1.Value + trackBar2.Value + trackBar3.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            // progressBar1.Value = Convert.ToInt32 (BackColor.ToArgb());
        }
    }
}