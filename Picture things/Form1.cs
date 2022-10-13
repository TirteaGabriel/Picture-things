namespace Picture_things
{
    public partial class Form1 : Form
    {
        Bitmap source;
        Bitmap dest;
        Color c1, c2, cr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            source = new Bitmap(@"C:\\Users\\Republique of Gamers\\Desktop\\C#\\Picture things\\Picture things\\Resources\\polistiren-expandat-8-cm-eps-80-adeplast_8997_1_16322222634257.jpg");
            pictureBox1.Image = source;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dest = new Bitmap(source.Width * 2 - 1, source.Height * 2 - 1);
            for (int i = 0; i < source.Width; i++)
            {
                for(int j=0;j<source.Height;j++)
                {
                    c1= source.GetPixel(i,j);
                    dest.SetPixel(i*2,j*2,c1);
                }
            }
            for (int i = 0; i < dest.Width; i += 2)
            {
                for (int j = 1; j < dest.Height-1; j += 2)
                {
                    c1 = dest.GetPixel(i, j - 1);
                    c2 = dest.GetPixel(i, j + 1);
                    int R = (c1.R + c2.R) / 2;
                    int G = (c1.G + c2.G) / 2;
                    int B = (c1.B + c2.B) / 2;
                    cr = Color.FromArgb(R, G, B); ;
                    dest.SetPixel(i, j, cr);
                }
            }
            for(int i=1;i<dest.Width;i+=2)
            {
                for (int j = 0; j<dest.Height; j++)
                {
                    c1=dest.GetPixel(i-1, j);
                    c2 = dest.GetPixel(i + 1, j);
                    int R = (c1.R + c2.R) / 2;
                    int G = (c1.G + c2.G) / 2;
                    int B = (c1.B + c2.B) / 2;
                    cr = Color.FromArgb(R, G, B);
                    dest.SetPixel(i, j, cr);
                }
            }

            pictureBox2.Image = dest;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }
    }
}