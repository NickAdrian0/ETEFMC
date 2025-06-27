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
    public partial class Form5 : Form
    {
        private Dictionary<string, (int quantidade, decimal precoUnitario)> carrinho = new Dictionary<string, (int, decimal)>();
        private TextBox txtRemoverQtd;

        public Form5()
        {
            InitializeComponent();
            btnRemover.Visible = false;

            txtRemoverQtd = new TextBox();
            txtRemoverQtd.Location = new System.Drawing.Point(btnRemover.Right + 10, btnRemover.Top); 
            txtRemoverQtd.Width = 40;
            txtRemoverQtd.KeyPress += TxtRemoverQtd_KeyPress;
            txtRemoverQtd.TextChanged += TxtRemoverQtd_TextChanged;
            Controls.Add(txtRemoverQtd);
        }

        public void AdicionarProdutoNaListBox(string nomeProduto, int quantidade, decimal precoUnitario)
        {
            try
            {
                if (carrinho.ContainsKey(nomeProduto))
                {
                    carrinho[nomeProduto] = (carrinho[nomeProduto].quantidade + quantidade, precoUnitario);
                }
                else
                {
                    carrinho[nomeProduto] = (quantidade, precoUnitario);
                }

                AtualizarListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void AtualizarListBox()
        {
            listBoxProdutos.Items.Clear();
            decimal precoTotal = 0;
            bool temNegativo = false;

            foreach (var item in carrinho)
            {
                string nomeProduto = item.Key;
                int quantidade = item.Value.quantidade;
                decimal precoUnitario = item.Value.precoUnitario;
                decimal precoProduto = quantidade * precoUnitario;

                if (precoProduto < 0)
                {
                    listBoxProdutos.Items.Add($"{nomeProduto} - {quantidade}x - Total: Sem Estoque");
                    temNegativo = true;
                }
                else
                {
                    listBoxProdutos.Items.Add($"{nomeProduto} - {quantidade}x - Total: R$ {precoProduto:F2}");
                    precoTotal += precoProduto;
                }
            }

            if (temNegativo || precoTotal < 0)
            {
                txtPrecoTotal.Text = "Sem Estoque";
            }
            else
            {
                txtPrecoTotal.Text = $"Preço Total: R$ {precoTotal:F2}";
            }

            btnRemover.Visible = listBoxProdutos.Items.Count > 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 homeForm = new Form1();
            homeForm.Show();
            this.Hide();
        }

        private void listBoxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemover.Enabled = listBoxProdutos.SelectedIndex != -1;
        }

        private void TxtRemoverQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void TxtRemoverQtd_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtRemoverQtd.Text.Trim(), out int valor) && valor > 0)
            {
                btnRemover.Text = valor == 1 ? "Remover 1 unidade" : $"Remover {valor} unidades";
            }
            else
            {
                btnRemover.Text = "Remover";
            }
        }

        private void btnRemover_Click_1(object sender, EventArgs e)
        {
            if (listBoxProdutos.SelectedIndex != -1)
            {
                string itemSelecionado = listBoxProdutos.SelectedItem.ToString();
                string[] partes = itemSelecionado.Split('-');
                string nomeProduto = partes[0].Trim();

                if (!carrinho.ContainsKey(nomeProduto))
                {
                    MessageBox.Show("Produto não encontrado no carrinho.");
                    return;
                }

                int quantidadeAtual = carrinho[nomeProduto].quantidade;
                decimal precoUnitario = carrinho[nomeProduto].precoUnitario;

                if ((quantidadeAtual <= 0) && string.IsNullOrWhiteSpace(txtRemoverQtd.Text))
                {
                    carrinho.Remove(nomeProduto);
                    AtualizarListBox();
                    MessageBox.Show("Produto removido por estar sem estoque.");
                    return;
                }

                if (!int.TryParse(txtRemoverQtd.Text.Trim(), out int qtdRemover) || qtdRemover <= 0)
                {
                    MessageBox.Show("Digite uma quantidade válida para remover.");
                    return;
                }

                if (qtdRemover > quantidadeAtual)
                {
                    MessageBox.Show("Você está tentando remover mais do que possui no carrinho.");
                    return;
                }

                int novaQuantidade = quantidadeAtual - qtdRemover;

                if (novaQuantidade > 0)
                {
                    carrinho[nomeProduto] = (novaQuantidade, precoUnitario);
                }
                else
                {
                    carrinho.Remove(nomeProduto);
                }

                AtualizarListBox();
                txtRemoverQtd.Clear();
            }
            else
            {
                MessageBox.Show("Selecione um produto para remover.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBoxProdutos.Items.Count == 0)
            {
                MessageBox.Show("O carrinho está vazio!");
                return;
            }

            if (txtPrecoTotal.Text == "Sem Estoque")
            {
                MessageBox.Show("Não há essa quantidade de produtos no estoque.");
                return;
            }

            string precoTotal = txtPrecoTotal.Text;
            Recibo reciboForm = new Recibo(listBoxProdutos.Items, precoTotal);
            reciboForm.Show();
            this.Hide();
        }
    }
}