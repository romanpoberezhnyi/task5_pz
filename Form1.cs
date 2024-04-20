namespace task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            SolidBrush bg = new SolidBrush(Color.Blue);
            SolidBrush green = new SolidBrush(Color.Aqua);
            SolidBrush brown = new SolidBrush(Color.Brown);
            SolidBrush white = new SolidBrush(Color.White);
            SolidBrush yellow = new SolidBrush(Color.Yellow);

            graph.FillRectangle(bg, 0, 300, 3000, 100);
            graph.FillRectangle(green, -100, -200, 1000, 500);
            graph.FillEllipse(white, 300, -100, -40, 200);
            graph.FillEllipse(white, 400, -50, -30, 200);
            graph.FillEllipse(yellow, 800, -50, -200, 200);
            pictureBox1.Image = bmp;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Програма для малювання\n програма написана Побережним Романом Дмитровичем, студентом групи КН21-1\n варіант №20", "about program", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
