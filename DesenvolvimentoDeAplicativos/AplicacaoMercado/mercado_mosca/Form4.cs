using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static mercado_mosca.Form5;

namespace mercado_mosca
{
    public partial class Form4 : FormBase
    {
        public Form4()
        {
            InitializeComponent();
            ExibirImagemAleatoriaSeNecessario();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 homeForm = new Form1();
            homeForm.Show();
            this.Hide();
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Kit homeForm = new Kit();
            homeForm.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Sam homeForm = new Sam();
            homeForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FoneGato homeForm = new FoneGato();
            homeForm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Oculos homeForm = new Oculos();
            homeForm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Sonic homeForm = new Sonic();
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
