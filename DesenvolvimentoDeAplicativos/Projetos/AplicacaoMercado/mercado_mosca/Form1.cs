using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mercado_mosca
{
    public partial class Form1 : FormBase
    {
        public Form1()
        {
            InitializeComponent();
            ExibirImagemAleatoriaSeNecessario();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Camera homeForm = new Camera();
            homeForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 homeForm = new Form4();
            homeForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Monitor homeForm = new Monitor();
            homeForm.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Bola homeForm = new Bola();
            homeForm.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Ar homeForm = new Ar();
            homeForm.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            FoneHz homeForm = new FoneHz();
            homeForm.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Sabre homeForm = new Sabre();
            homeForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = Application.OpenForms["Form5"] as Form5;
            if (form5 == null)
            {
                form5 = new Form5();
                form5.Show();
            }
            else
            {
                form5.Show();
            }
            this.Hide();
        }
    }
}
