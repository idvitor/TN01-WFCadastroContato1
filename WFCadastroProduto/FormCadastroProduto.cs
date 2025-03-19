using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCadastroProduto
{
    public partial class FormCadastroProduto : Form
    {
        public FormCadastroProduto()
        {
            InitializeComponent();
        }
        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                Erro("O Codigo não pode estar vazio!");
                return;
            }

            if (string.IsNullOrEmpty(txtNomeProduto.Text))
            {
                Erro("O Nome do Produto não pode estar vazio!");
                return;
            }

            if (string.IsNullOrEmpty(rtbObservacao.Text))
            {
                Erro("Adcione Observação!");
                return;
            }
            if (string.IsNullOrEmpty(cbxCategoria.Text))
            {
                Erro("Adcione a Categoria!");
                return;
            }
            if (string.IsNullOrEmpty(nudPreco.Text))
            {
                Erro("Adcione o Preço!");
                return;
            }
            if (string.IsNullOrEmpty(dtpVencimento.Text))
            {
                Erro("Adcione a Data de Vencimento!");
                return;
            }

            Produto prod = new Produto();
            prod.Codigo = Convert.ToInt32(txtCodigo.Text);
            prod.Categoria = cbxCategoria.Text;
            prod.Nome = txtNomeProduto.Text;
            prod.Preco = Convert.ToDouble(nudPreco.Value);
            prod.DataVencimento = DateTime.Now;
            prod.Observacao = rtbObservacao.Text;

            Produto.ListaProdutos.Add(prod);
            Close();

            FormListaProduto form = new FormListaProduto();
            form.ShowDialog();
        }

        private void FormCadastroProduto_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = "00" + (Produto.ListaProdutos.Count + 1);
            txtCodigo.Enabled = false;
        }
    }
}
