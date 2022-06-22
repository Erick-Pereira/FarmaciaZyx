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
        

        private void FormRegistroEntrada_Load(object sender, EventArgs e)
        {
            
            cmbFornecedor.DataSource = fornecedorBLL.GetAll().Dados;
            cmbFornecedor.DisplayMember = "RazaoSocial";
            cmbFornecedor.ValueMember = "ID";
            cmbProduto.DataSource = produtorBLL.GetAll().Dados;
            cmbProduto.DisplayMember = "Nome";
            cmbProduto.ValueMember = "ID";
            if (cmbProduto.SelectedItem != null)
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
            if (produto != null)
            {
                produto.QtdEstoque = (double)nudQtde.Value;
                produtos.Add(produto);
                dgvProdutosEntrada.Rows.Add();
                for (int i = 0; i < produtos.Count; i++)
                {
                    dgvProdutosEntrada.Rows[i].Cells["ProdutosEntradaID"].Value = produtos[i].ID;
                    dgvProdutosEntrada.Rows[i].Cells["ProdutosEntradaNome"].Value = produtos[i].Nome;
                    dgvProdutosEntrada.Rows[i].Cells["ProdutosEntradaUn"].Value = TipoUnidadeBLL.GetById(produtos[i].TipoUnidadeId).Item.Nome;
                    dgvProdutosEntrada.Rows[i].Cells["ProdutosEntradaQtde"].Value = produtos[i].QtdEstoque;
                    dgvProdutosEntrada.Rows[i].Cells["ProdutosEntradaValor"].Value = produtos[i].Valor;
                }
            }
            //** // create columns automatically //**
            //produto.QtdEstoque -= (double)nudQtde.Value;
            //produtorBLL.Update(produto);
            //DataTable dt = new DataTable();
            //dt = produto;
        }

        private void btnRetirarProduto_Click(object sender, EventArgs e)
        {
            if (dgvProdutosEntrada.CurrentCell == null)
            {
                MessageBox.Show("Não é possivel retirar um produto não selecionado");
                return;
            }
            int rowindex = dgvProdutosEntrada.CurrentCell.RowIndex;
            int columnindex = dgvProdutosEntrada.CurrentCell.ColumnIndex;
            //MessageBox.Show(dgvProdutos.Rows[rowindex].Cells[columnindex].Value.ToString());
            produtos.RemoveAt(rowindex);
            dgvProdutosEntrada.Rows.RemoveAt(rowindex);
            for (int i = 0; i < produtos.Count; i++)
            {
                dgvProdutosEntrada.Rows[i].Cells["ProdutosEntradaID"].Value = produtos[i].ID;
                dgvProdutosEntrada.Rows[i].Cells["ProdutosEntradaNome"].Value = produtos[i].Nome;
                dgvProdutosEntrada.Rows[i].Cells["ProdutosEntradaUn"].Value = TipoUnidadeBLL.GetById(produtos[i].TipoUnidadeId).Item.Nome;
                dgvProdutosEntrada.Rows[i].Cells["ProdutosEntradaQtde"].Value = produtos[i].QtdEstoque;
                dgvProdutosEntrada.Rows[i].Cells["ProdutosEntradaValor"].Value = produtos[i].Valor;
            }
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
