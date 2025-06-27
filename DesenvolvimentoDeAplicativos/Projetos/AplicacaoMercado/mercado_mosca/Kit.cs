using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mercado_mosca
{
    public partial class Kit : FormBase
    {
        private Form5 form5;
        private bool updating = false;

        public Kit()
        {
            InitializeComponent();
            ExibirImagemAleatoriaSeNecessario();

            form5 = Application.OpenForms["Form5"] as Form5;
            if (form5 == null)
            {
                form5 = new Form5();
                form5.Show();
                form5.Hide();
            }

            tbq.KeyPress += Tbq_KeyPress;
            tbq.TextChanged += tbq_TextChanged;
        }

        private void Tbq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbq_TextChanged(object sender, EventArgs e)
        {
            if (updating)
                return;

            if (string.IsNullOrWhiteSpace(tbq.Text))
            {
                tbp.Text = "";
                return;
            }

            if (Regex.IsMatch(tbq.Text, @"^\d+$"))
            {
                if (tbq.Text.Length > 10 ||
                   (tbq.Text.Length == 10 && string.Compare(tbq.Text, "2147483647") > 0))
                {
                    tbp.Text = "Sem estoque";
                    return;
                }

                int quantidade = int.Parse(tbq.Text);

                decimal valor = 300m * quantidade;

                if (valor < 0)
                {
                    tbp.Text = "Sem estoque";
                    return;
                }

                tbp.Text = valor.ToString("C");
            }
            else
            {
                tbp.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nomeProduto = "Kit C#";
            decimal precoUnitario = 300.00m;

            if (tbp.Text == "Sem estoque")
            {
                MessageBox.Show("Não há essa quantidade de produtos no estoque.");
                return;
            }

            if (!Regex.IsMatch(tbq.Text, @"^\d+$"))
            {
                MessageBox.Show("Por favor, insira apenas números na quantidade.");
                return;
            }

            int quantidade = int.Parse(tbq.Text);
            decimal precoTotal = quantidade * precoUnitario;
            if (precoTotal < 0)
            {
                MessageBox.Show("Não há essa quantidade de produtos no estoque.");
                return;
            }

            if (form5 != null)
            {
                form5.AdicionarProdutoNaListBox(nomeProduto, quantidade, precoUnitario);
            }
            else
            {
                MessageBox.Show("Form5 não está aberto.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 homeForm = new Form4();
            homeForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (form5 != null && !form5.Visible)
            {
                form5.Show();
            }
            this.Hide();
        }
    }
}