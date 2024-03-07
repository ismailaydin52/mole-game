using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kostebek
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
          
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        public void Setveri(int veri)
        {
            label1.Text = veri.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
       }
    }
}
