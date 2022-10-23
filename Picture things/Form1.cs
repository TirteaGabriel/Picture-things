namespace Picture_things
{
    public partial class Form1 : Form
    {
        Bitmap source;
        Bitmap dest;
        Color c1, c2, cr;
        Random rnd=new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            source = new Bitmap(@"../../../Resources\\polistiren-expandat-8-cm-eps-80-adeplast_8997_1_16322222634257.jpg");
            pictureBox1.Image = source;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dest = new Bitmap(source.Width, source.Height);
            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    c1 = source.GetPixel(i, j);
                    int R = (c1.B);
                    int G = (c1.R);
                    int B = (c1.G);
                    cr=Color.FromArgb(R, G, B);
                    dest.SetPixel(i,j,cr);
                }
            }

                pictureBox2.Image = dest;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dest = new Bitmap(source.Width, source.Height);
            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    c1 = source.GetPixel(i, j);
                    int R = (c1.R);
                    int G = (c1.G);
                    int B = (c1.B);
                    if (R <= 200)
                        R += 50;
                    if (G <= 200)
                        G += 50;
                    if (B <= 200)
                        B += 50;
                    cr = Color.FromArgb(R, G, B);
                    dest.SetPixel(i, j, cr);
                }
            }
            pictureBox2.Image = dest;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dest = new Bitmap(source.Width, source.Height);
            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    c1 = source.GetPixel(i, j);
                    int R = (c1.R);
                    int G = (c1.G);
                    int B = (c1.B);
                    if (R < G)
                        B = G - R;
                    else
                        B = R - G;
                    if (G < B)
                        R = B - G;
                    else
                        R = G - B;
                    if (B < R)
                        G = R - B;
                    else
                        G = B - R;
                    cr = Color.FromArgb(R, G, B);
                    dest.SetPixel(i, j, cr);
                }
            }
            pictureBox2.Image = dest;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dest = new Bitmap(source.Width, source.Height);
            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    c1 = source.GetPixel(i, j);
                    int R = (c1.R);
                    int G = (c1.G);
                    int B = (c1.B);
                    if (R < 150)
                        R += 60;
                    else
                        R -= 60;
                    if (G < 150)
                        G += 60;
                    else
                        G -= 60;
                    if (B < 150)
                        B += 60;
                    else
                        B -= 60;

                    cr = Color.FromArgb(R, G, B);
                    dest.SetPixel(i, j, cr);
                }
            }
            pictureBox2.Image = dest;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dest = new Bitmap(source.Width, source.Height);
            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    c1 = source.GetPixel(i, j);
                    int R = (c1.R);
                    int G = (c1.G);
                    int B = (c1.B);
                    int aux;
                    aux = R;
                    R = G;
                    G = B;
                    B = aux;
                    cr = Color.FromArgb(R, G, B);
                    dest.SetPixel(i, j, cr);
                }
            }
            pictureBox2.Image = dest;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dest = new Bitmap(source.Width, source.Height);
            for (int i = 0; i < dest.Width; i += 2)
            {
                for (int j = 1; j < dest.Height - 1; j += 2)
                {
                    c1 = source.GetPixel(i, j);
                    dest.SetPixel(i / 2, j / 2, c1);
                }
            }
            pictureBox2.Image = dest;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dest = new Bitmap(source.Width, source.Height);
            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    c1 = source.GetPixel(i, j);
                    int R = rnd.Next(0, 255);
                    int G = rnd.Next(0, 255);
                    int B = rnd.Next(0, 255);
                    
                    cr = Color.FromArgb(R, G, B);
                    dest.SetPixel(i, j, cr);
                }
            }
            pictureBox2.Image = dest;

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