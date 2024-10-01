namespace PaintProgramProject
{
    public partial class Form1 : Form
    {
        Bitmap MyBitMap;
        bool isMouseDown;
        public Form1()
        {
            InitializeComponent();
            MyBitMap = new Bitmap(Size.Width, Size.Height);
            isMouseDown = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouseDown) return;

            Graphics graphics = Graphics.FromImage(MyBitMap);
            Pen redP = new Pen(Color.Red, 10);

            graphics.DrawLine(redP, e.X, e.Y, e.X+1, e.Y+1);
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.DrawImageUnscaled(MyBitMap, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = Graphics.FromImage(MyBitMap);
            graphics.Clear(Color.Transparent);
            Refresh();
        }
    }
}