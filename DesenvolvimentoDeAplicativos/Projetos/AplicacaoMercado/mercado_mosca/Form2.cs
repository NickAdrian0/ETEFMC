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

namespace mercado_mosca
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            textBox2.KeyPress += textBox2_KeyPress;
            textBox1.KeyPress += textBox1_KeyPress;
            textBox2.TextChanged += textBox2_TextChanged;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; 
            }
        }
        public void ButtonEnableOff()
        {
            if (textBox1.TextLength > 0 && textBox2.TextLength > 0 && textBox3.TextLength > 0)
                bt1.Enabled = true;
            else
                bt1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ButtonEnableOff();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ButtonEnableOff();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            string textoNumerico = new string(textBox2.Text.Where(char.IsDigit).ToArray());

            if (textoNumerico.Length >= 11 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string textoNumerico = new string(textBox2.Text.Where(char.IsDigit).ToArray());

            if (textoNumerico.Length > 11)
                textoNumerico = textoNumerico.Substring(0, 11);

            if (textoNumerico.Length <= 3)
                textBox2.Text = textoNumerico;
            else if (textoNumerico.Length <= 6)
                textBox2.Text = $"{textoNumerico.Substring(0, 3)}.{textoNumerico.Substring(3)}";
            else if (textoNumerico.Length <= 9)
                textBox2.Text = $"{textoNumerico.Substring(0, 3)}.{textoNumerico.Substring(3, 3)}.{textoNumerico.Substring(6)}";
            else
                textBox2.Text = $"{textoNumerico.Substring(0, 3)}.{textoNumerico.Substring(3, 3)}.{textoNumerico.Substring(6, 3)}-{textoNumerico.Substring(9)}";

            textBox2.SelectionStart = textBox2.Text.Length;
            textBox2.SelectionLength = 0;

            ButtonEnableOff();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] linhas = File.ReadAllLines("clienteInfo.txt");

            foreach (string linha in linhas)
            {
                string[] dados = linha.Split(';');

                if (dados.Length == 7 && dados[0] == textBox1.Text && dados[1] == textBox2.Text && dados[2] == textBox3.Text)
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    label6.Text = "Login Feito com sucesso";
                    Form1 homeForm = new Form1();
                    homeForm.Show();
                    this.Hide();
                    return;
                }
            }

            label6.Text = "O nome, CPF ou senha inseridos estão errados. Por favor, tente novamente.";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 homeForm = new Form3();
            homeForm.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.UseSystemPasswordChar = !textBox3.UseSystemPasswordChar;
        }
    }
}