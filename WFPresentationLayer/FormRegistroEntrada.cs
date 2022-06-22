using BusinessLogicalLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFPresentationLayer
{
    public partial class FormRegistroEntrada : Form
    {
        List<Produto> produtos = new List<Produto>();
        FornecedorBLL fornecedorBLL = new FornecedorBLL();
        ProdutorBLL produtorBLL = new ProdutorBLL();
        TipoUnidadeBLL TipoUnidadeBLL = new TipoUnidadeBLL();
        List<Produto> produtosEntrada = new List<Produto>();

        public FormRegistroEntrada()
        {
            InitializeComponent();
        }

        private void btnCadastrarNovoFornecedor_Click(object sender, EventArgs e)
        {
            FormCadastroFornecedor formCadastroFornecedor = new FormCadastroFornecedor();
            formCadastroFornecedor.ShowDialog();
            cmbFornecedor.DataSource = fornecedorBLL.GetAll().Dados;
            cmbFornecedor.DisplayMember = "RazaoSocial";
            cmbFornecedor.ValueMember = "ID";
        }

        private void btnCadastroNovoProduto_Click(object sender, EventArgs e)
        {
            FormCadastroProduto formCadastroProduto = new FormCadastroProduto();
            formCadastroProduto.ShowDialog();
            cmbProduto.DataSource = produtorBLL.GetAll().Dados;
            cmbProduto.DisplayMember = "Nome";
            cmbProduto.ValueMember = "ID";
        }
        //cmbUnidade.SelectedIndex = produtorBLL.GetByNome(cmbProduto.SelectedText).Item.TipoUnidadeId;

        private void FormRegistroEntrada_Load(object sender, EventArgs e)
        {
            cmbFornecedor.DataSource = fornecedorBLL.GetAll().Dados;
            cmbFornecedor.DisplayMember = "RazaoSocial";
            cmbFornecedor.ValueMember = "ID";
            cmbProduto.DataSource = produtorBLL.GetAll().Dados;
            cmbProduto.DisplayMember = "Nome";
            cmbProduto.ValueMember = "ID";
            Produto produto = (Produto)cmbProduto.SelectedItem;
            TipoUnidade tipoUnidade = TipoUnidadeBLL.GetById(produto.TipoUnidadeId).Item;
            if (tipoUnidade != null)
            {
                txtUnidade.Text = tipoUnidade.Nome;
                nudQtde.DecimalPlaces = tipoUnidade.CasasDecimais;
                nudQtde.Value = 1;
            }
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Produto produto = (Produto)cmbProduto.SelectedItem;
            TipoUnidade tipoUnidade = TipoUnidadeBLL.GetById(produto.TipoUnidadeId).Item;
            if (tipoUnidade != null)
            {
                txtUnidade.Text = tipoUnidade.Nome;
                nudQtde.DecimalPlaces = tipoUnidade.CasasDecimais;
                nudQtde.Value = 1;
            }
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            Produto produto = produtorBLL.GetByID(Convert.ToInt32(cmbProduto.SelectedValue)).Item;
            produto.QtdEstoque = (double)nudQtde.Value;
            produtos.Add(produto);
            dgvProdutos.Rows.Add();
            for (int i = 0; i < produtos.Count; i++)
            {
                dgvProdutos.Rows[i].Cells["ID"].Value = produtos[i].ID;
                dgvProdutos.Rows[i].Cells["Nome"].Value = produtos[i].Nome;
                dgvProdutos.Rows[i].Cells["Un"].Value = TipoUnidadeBLL.GetById(produtos[i].TipoUnidadeId).Item.Nome;
                dgvProdutos.Rows[i].Cells["Qtde"].Value = produtos[i].QtdEstoque;
                dgvProdutos.Rows[i].Cells["Valor"].Value = produtos[i].Valor;
            }

            //** // create columns automatically //**
            //produto.QtdEstoque -= (double)nudQtde.Value;
            //produtorBLL.Update(produto);
            //DataTable dt = new DataTable();
            //dt = produto;
        }

        private void btnRetirarProduto_Click(object sender, EventArgs e)
        {
            if(dgvProdutos.CurrentCell == null)
            {
                MessageBox.Show("Não é possivel retirar um produto não selecionado");
                return;
            }
            int rowindex = dgvProdutos.CurrentCell.RowIndex;
            int columnindex = dgvProdutos.CurrentCell.ColumnIndex;
            //MessageBox.Show(dgvProdutos.Rows[rowindex].Cells[columnindex].Value.ToString());
            produtos.RemoveAt(rowindex);
            dgvProdutos.Rows.RemoveAt(rowindex);
            for (int i = 0; i < produtos.Count; i++)
            {
                dgvProdutos.Rows[i].Cells["ID"].Value = produtos[i].ID;
                dgvProdutos.Rows[i].Cells["Nome"].Value = produtos[i].Nome;
                dgvProdutos.Rows[i].Cells["Un"].Value = TipoUnidadeBLL.GetById(produtos[i].TipoUnidadeId).Item.Nome;
                dgvProdutos.Rows[i].Cells["Qtde"].Value = produtos[i].QtdEstoque;
                dgvProdutos.Rows[i].Cells["Valor"].Value = produtos[i].Valor;
            }
            //produtos.Remove();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < produtos.Count; i++)
            {
                Produto pro = produtos[i];
                stringBuilder.AppendLine(pro.Nome);
            }

            MessageBox.Show(stringBuilder.ToString());
        }
    }
}
