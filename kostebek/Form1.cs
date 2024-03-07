using NAudio.Wave;
using System.Media;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace kostebek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cursor customCursor = new Cursor("Cursor1.ico");

            this.Cursor = customCursor;

            // arkaplan müziði 
            stream1 = new AudioFileReader("C:\\Users\\ismail\\source\\repos\\kostebek\\kostebek\\bin\\Debug\\net6.0-windows\\backmusic.wav");
            out1 = new();
            out1.Init(stream1);
            if (out1.PlaybackState is PlaybackState.Playing) out1.Stop();
            stream1.CurrentTime = new TimeSpan(0L);
            out1.Play();

        }
        private WaveStream stream1;
        private WaveOut out1;

        // skor sayacý
        int a = 0;

        // köstebekleri gösteren timer 
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int kosturet = random.Next(1, 6);

            switch (kosturet)
            {
                case 1: ilkkost.Visible = true; break;
                case 2: ikincikost.Visible = true; break;
                case 3: ucuncukost.Visible = true; break;
                case 4: dorduncukost.Visible = true; break;
                case 5: besincikost.Visible = true; break;
            }

            timer1.Stop();
            timer2.Start();
        }


        //köstebekleri gizleyen timer
        private void timer2_Tick(object sender, EventArgs e)
        {
            ilkkost.Visible = false;
            ikincikost.Visible = false;
            ucuncukost.Visible = false;
            dorduncukost.Visible = false;
            besincikost.Visible = false;


            // bonk resmini sýfýrlar
            string imagePath = "C:\\Users\\ismail\\source\\repos\\kostebek\\kostebek\\bin\\Debug\\net6.0-windows\\kostebek.png";
            string imagePath2 = "C:\\Users\\ismail\\source\\repos\\kostebek\\kostebek\\bin\\Debug\\net6.0-windows\\kostebek.png";
            string imagePath3 = "C:\\Users\\ismail\\source\\repos\\kostebek\\kostebek\\bin\\Debug\\net6.0-windows\\kostebek.png";
            string imagePath4 = "C:\\Users\\ismail\\source\\repos\\kostebek\\kostebek\\bin\\Debug\\net6.0-windows\\kostebek.png";
            string imagePath5 = "C:\\Users\\ismail\\source\\repos\\kostebek\\kostebek\\bin\\Debug\\net6.0-windows\\kostebek.png";
            ilkkost.Image = new System.Drawing.Bitmap(imagePath);
            ikincikost.Image = new System.Drawing.Bitmap(imagePath2);
            ucuncukost.Image = new System.Drawing.Bitmap(imagePath3);
            dorduncukost.Image = new System.Drawing.Bitmap(imagePath4);
            besincikost.Image = new System.Drawing.Bitmap(imagePath5);

            timer1.Start();
            timer2.Stop();


        }
        private bool form3Acildi = false;

        //oyunu bitiren timer
        private void timer3_Tick(object sender, EventArgs e)
        {
            // süre artýþý
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 2;
            }
            // oyunu süre dolunca kapatýr
            else if (progressBar1.Value == 100 && !form3Acildi)
            {
                form3Acildi = true;
                int veri = a;
                out1.Stop();
                timer3.Stop();
                Form3 form3 = new Form3();
                form3.Setveri(veri);
                form3.Show();
                this.Hide();
            }


        }



        private void ilkkost_Click(object sender, EventArgs e)
        {
            a += 1;
            label4.Text = a.ToString();
            string sesDosyaYolu = "C:\\Users\\ismail\\source\\repos\\kostebek\\kostebek\\bin\\Debug\\net6.0-windows\\bonk.wav";

            string imagePath = "C:\\Users\\ismail\\source\\repos\\kostebek\\kostebek\\bin\\Debug\\net6.0-windows\\kostbonked.png";
            ilkkost.Image = new System.Drawing.Bitmap(imagePath);


            SoundPlayer soundPlayer = new SoundPlayer();

            soundPlayer.SoundLocation = sesDosyaYolu;
            soundPlayer.Play();
        }

        private void ikincikost_Click(object sender, EventArgs e)
        {
            a += 1;
            label4.Text = a.ToString();
            string sesDosyaYolu = "C:\\Users\\ismail\\source\\repos\\kostebek\\kostebek\\bin\\Debug\\net6.0-windows\\bonk.wav";


            string imagePath = "C:\\Users\\ismail\\source\\repos\\kostebek\\kostebek\\bin\\Debug\\net6.0-windows\\kostbonked.png";
            ikincikost.Image = new System.Drawing.Bitmap(imagePath);

            SoundPlayer soundPlayer = new SoundPlayer();

            soundPlayer.SoundLocation = sesDosyaYolu;
            soundPlayer.Play();
        }

        private void ucuncukost_Click(object sender, EventArgs e)
        {
            a += 1;
            label4.Text = a.ToString();
            string sesDosyaYolu = "C:\\Users\\ismail\\source\\repos\\kostebek\\kostebek\\bin\\Debug\\net6.0-windows\\bonk.wav";

            string imagePath = "C:\\Users\\ismail\\source\\repos\\kostebek\\kostebek\\bin\\Debug\\net6.0-windows\\kostbonked.png";
            ucuncukost.Image = new System.Drawing.Bitmap(imagePath);

            SoundPlayer soundPlayer = new SoundPlayer();

            soundPlayer.SoundLocation = sesDosyaYolu;
            soundPlayer.Play();
        }

        private void dorduncukost_Click(object sender, EventArgs e)
        {
            a += 1;
            label4.Text = a.ToString();
            string sesDosyaYolu = "C:\\Users\\ismail\\source\\repos\\kostebek\\kostebek\\bin\\Debug\\net6.0-windows\\bonk.wav";

            string imagePath = "C:\\Users\\ismail\\source\\repos\\kostebek\\kostebek\\bin\\Debug\\net6.0-windows\\kostbonked.png";
            dorduncukost.Image = new System.Drawing.Bitmap(imagePath);

            SoundPlayer soundPlayer = new SoundPlayer();

            soundPlayer.SoundLocation = sesDosyaYolu;
            soundPlayer.Play();
        }

        private void besincikost_Click(object sender, EventArgs e)
        {
            a += 1;
            label4.Text = a.ToString();
            string sesDosyaYolu = "C:\\Users\\ismail\\source\\repos\\kostebek\\kostebek\\bin\\Debug\\net6.0-windows\\bonk.wav";

            string imagePath = "C:\\Users\\ismail\\source\\repos\\kostebek\\kostebek\\bin\\Debug\\net6.0-windows\\kostbonked.png";
            besincikost.Image = new System.Drawing.Bitmap(imagePath);

            SoundPlayer soundPlayer = new SoundPlayer();

            soundPlayer.SoundLocation = sesDosyaYolu;
            soundPlayer.Play();


        }



        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }


    }
}