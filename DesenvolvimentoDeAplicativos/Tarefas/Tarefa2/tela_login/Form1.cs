using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web;

namespace tela_login
{

    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void ButtonEnableOff()
        {
            if (textBox1.TextLength > 0 && textBox2.TextLength > 0) button1.Enabled = true;
            else button1.Enabled = false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ButtonEnableOff();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ButtonEnableOff();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] linhas = File.ReadAllLines("usuarios.txt");
            foreach (string linha in linhas)
            {
                string[] dados = linha.Split(';');
                if (dados.Length == 2 && dados[0] == textBox1.Text && dados[1] == textBox2.Text)
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    label4.Text = "Login feito com sucesso";
                    break;

                }
                label4.Text = "O email ou senha digitados estao errados. Por favor, tente novamente";
            }
        }

        public void SingUp(object sender, EventArgs e)
        {
            Form2 homeForm = new Form2();
            homeForm.Show();
            this.Hide();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !textBox2.UseSystemPasswordChar;
        }
    }
}

