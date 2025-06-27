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

namespace tela_login
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0)
            {
                if (textBox2.TextLength > 0 || textBox3.TextLength > 0)
                {
                    if (textBox2.Text == textBox3.Text)
                    {
                        string dadoscriarconta = $"{textBox1.Text};{textBox2.Text}\n";
                        File.AppendAllText("usuarios.txt", dadoscriarconta);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        label5.Text = "Usuario criado com sucesso";
                    }
                    else label5.Text = "Suas senhas sao discrepantes. Por favor, verifique-as e tente Novamente";
                }
                else label5.Text = "O campo 'senha' ou 'confirmar senha' esta vazio. Por favor, insira uma senha válida e tente novamente";
            }
            else label5.Text = "O campo 'email' senha esta vazio. Por favor, insira um email válido e tente novamente";
        }
        public void Login(object sender, EventArgs e)
        {
            Form1 homeForm = new Form1();
            homeForm.Show();
            this.Hide();
        }
    }
}
