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
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 255;
            UpdateColor();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            trackBar2.Minimum = 0;
            trackBar2.Maximum = 255;
            UpdateColor();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            trackBar3.Minimum = 0;
            trackBar3.Maximum = 255;
            UpdateColor();
        }
        public void UpdateColor()
        {
            this.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 0, 0);
        }
    }
}