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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            textBox2.KeyPress += textBox2_KeyPress;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            textBox7.KeyPress += textBox7_KeyPress;
        }
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
            private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 homeForm = new Form2();
            homeForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0 && textBox2.TextLength != 0 && textBox3.TextLength != 0 &&
                textBox4.TextLength != 0 && textBox5.TextLength != 0 && textBox6.TextLength != 0 && textBox7.TextLength != 0)
            {
                if (textBox3.Text == textBox4.Text)
                {
                    string dadoscriarconta = $"{textBox1.Text};{textBox2.Text};{textBox3.Text};{textBox4.Text};{textBox5.Text};{textBox6.Text};{textBox7.Text}\n";
                    File.AppendAllText("clienteInfo.txt", dadoscriarconta);

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    label9.Text = "Usuário criado com sucesso";
                }
                else
                {
                    label9.Text = "Suas senhas são discrepantes. Por favor, verifique-as e tente novamente";
                }
            }
            else
            {
                label9.Text = "Algum campo está vazio. Por favor, insira suas credenciais e tente novamente";
            }
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
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
