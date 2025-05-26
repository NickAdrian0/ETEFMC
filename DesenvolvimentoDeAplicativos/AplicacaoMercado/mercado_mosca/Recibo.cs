using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mercado_mosca
{
    public partial class Recibo : Form
    {
        public Recibo(ListBox.ObjectCollection produtos, string precoTotal)
        {
            InitializeComponent();
            AtualizarRecibo(produtos, precoTotal);
        }

        private void AtualizarRecibo(ListBox.ObjectCollection produtos, string precoTotal)
        {
            listBoxRecibo.Items.Clear();
            foreach (var item in produtos)
            {
                listBoxRecibo.Items.Add(item);
            }

            lblPrecoTotal.Text = precoTotal;
        }

        private void listBoxRecibo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            SalvarReciboEmTxt();
            this.Close();
        }

        private void SalvarReciboEmTxt()
        {
            string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "recibo.txt");

            try
            {
                using (StreamWriter writer = new StreamWriter(caminhoArquivo))
                {
                    writer.WriteLine("===== RECIBO =====");
                    writer.WriteLine("Produtos comprados:");

                    foreach (var item in listBoxRecibo.Items)
                    {
                        writer.WriteLine(item.ToString());
                    }

                    writer.WriteLine("\n" + lblPrecoTotal.Text);
                    writer.WriteLine("==================");

                    MessageBox.Show($"Recibo salvo em: {caminhoArquivo}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o recibo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalvarReciboComo();
        }

        private void SalvarReciboComo()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Arquivo de Texto (*.txt)|*.txt";
                saveFileDialog.Title = "Salvar Recibo";
                saveFileDialog.FileName = "recibo.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            writer.WriteLine("===== RECIBO =====");
                            writer.WriteLine("Itens Comprados:");

                            foreach (var item in listBoxRecibo.Items)
                            {
                                writer.WriteLine(item.ToString());
                            }

                            writer.WriteLine("\n" + lblPrecoTotal.Text);
                            writer.WriteLine("==================");

                            MessageBox.Show($"Recibo salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao salvar o recibo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            Form2 homeForm = new Form2();
            homeForm.Show();
            this.Hide();
        }
    }
}