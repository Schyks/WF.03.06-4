using static System.Formats.Asn1.AsnWriter;

namespace Timer
{
    public partial class Form1 : Form
    {
        public int count = 0;
        public int max = 0;
        public int seconds = 0;
        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }
        private void InitializeGame()
        {
            count = 0;
            seconds = 5;
            button1.Text = "Start";
            textBox1.Text = "Time";
        }
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            count++;
            button1.Text = count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds--;
            textBox1.Text = seconds.ToString();
            if (seconds == 0)
            {
                record();
                timer1.Stop();
                MessageBox.Show($"Час вийшов! Набрано кліків: {count}\nМаксимальний рекорд: {max}");
                InitializeGame();
            }
        }
        private void record()
        {
            if (count >= max)
                max = count;
        }
    }
}

