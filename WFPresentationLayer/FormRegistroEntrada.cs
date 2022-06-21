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
        TipoUnidadeBLL unidadeBLL = new TipoUnidadeBLL();
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
            TipoUnidade tipoUnidade = unidadeBLL.GetById(produto.TipoUnidadeId).Item;
            if (tipoUnidade != null)
            {
                txtUnidade.Text = tipoUnidade.Nome;
                nudQtde.DecimalPlaces = tipoUnidade.CasasDecimais;
            }
           
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Produto produto = (Produto)cmbProduto.SelectedItem;
            TipoUnidade tipoUnidade = unidadeBLL.GetById(produto.TipoUnidadeId).Item;
            if (tipoUnidade != null)
            {
                txtUnidade.Text = tipoUnidade.Nome;
                nudQtde.DecimalPlaces = tipoUnidade.CasasDecimais;
            }
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {

            Produto produto = produtorBLL.GetByID(Convert.ToInt32(cmbProduto.SelectedValue)).Item;
            produtos.Add(produto);
            //produto.QtdEstoque -= (double)nudQtde.Value;
            //produtorBLL.Update(produto);
            //DataTable dt = new DataTable();
            //dt = produto;
            dgvProdutos.Rows.Add();
            dgvProdutos.Rows[produtos.Count].Cells["Column1"].Value = produto.ID;
            dgvProdutos.Rows[produtos.Count].Cells["Column2"].Value = produto.Nome;
            dgvProdutos.Rows[produtos.Count].Cells["Column3"].Value = unidadeBLL.GetById(produto.TipoUnidadeId).Item.Nome;
            dgvProdutos.Rows[produtos.Count].Cells["Column4"].Value = (double)nudQtde.Value;
            dgvProdutos.Rows[produtos.Count].Cells["Column5"].Value = 0;

        }

        private void btnRetirarProduto_Click(object sender, EventArgs e)
        {
            produtos.RemoveAt(Convert.ToInt32(dgvProdutos.SelectedRows)); ;
        }
    }
}
