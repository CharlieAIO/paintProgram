namespace PaintProgramProject
{
    public partial class Form1 : Form
    {
        Bitmap MyBitMap;
        bool MouseDown = false;
        public Form1()
        {
            InitializeComponent();
            MyBitMap = new Bitmap(Size.Width,Size.Height);
        }
    }
}