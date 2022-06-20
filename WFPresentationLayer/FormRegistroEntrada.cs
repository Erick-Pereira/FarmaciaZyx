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
        FornecedorBLL fornecedorBLL = new FornecedorBLL();
        ProdutorBLL produtorBLL = new ProdutorBLL();
        TipoUnidadeBLL unidadeBLL = new TipoUnidadeBLL();
        List<Produto> produtosEntrada = new List<Produto>();
        public FormRegistroEntrada()
        {
            InitializeComponent();
            cmbFornecedor.DataSource = fornecedorBLL.GetAll().Dados;
            cmbFornecedor.DisplayMember = "RazaoSocial";
            cmbFornecedor.ValueMember = "ID";
            cmbProduto.DataSource = produtorBLL.GetAll().Dados;
            cmbProduto.DisplayMember = "Nome";
            cmbProduto.ValueMember = "ID";           
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
            List<Produto> displayedValues = new List<Produto>();
            foreach (Produto ci in cmbProduto.Items)
                displayedValues.Add(ci);
            txtUnidade.Text = unidadeBLL.GetById(displayedValues[cmbProduto.SelectedIndex].TipoUnidadeId).Item.Nome;
            if (txtUnidade.Text == "UN")
            {
                nudQtde.DecimalPlaces = 0;
            }
            if (txtUnidade.Text == "KG")
            {
                nudQtde.DecimalPlaces = 2;
            }
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Produto> displayedValues = new List<Produto>();
            foreach (Produto ci in cmbProduto.Items)
                displayedValues.Add(ci);
            txtUnidade.Text = unidadeBLL.GetById(displayedValues[cmbProduto.SelectedIndex].TipoUnidadeId).Item.Nome;
            if(txtUnidade.Text == "UN")
            {
                nudQtde.DecimalPlaces = 0;
            }
            if (txtUnidade.Text == "KG")
            {
                nudQtde.DecimalPlaces = 2;
            }
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            List<Produto> displayedValues = new List<Produto>();
            foreach (Produto ci in cmbProduto.Items)
            displayedValues.Add(ci);
            Produto produto = produtorBLL.GetByID(displayedValues[cmbProduto.SelectedIndex].ID).Item;
            produtosEntrada.Add(produto);
            //produto.QtdEstoque -= (double)nudQtde.Value;
            //produtorBLL.Update(produto);
            //DataTable dt = new DataTable();
            //dt = produto;
            dgvProdutos.Rows.Add();
            int cont = produtosEntrada.Count-1;
                dgvProdutos.Rows[cont].Cells["Column1"].Value = produto.ID;
                 dgvProdutos.Rows[cont].Cells["Column2"].Value = produto.Nome;
                dgvProdutos.Rows[cont].Cells["Column3"].Value = unidadeBLL.GetById(produto.TipoUnidadeId).Item.Nome;
                dgvProdutos.Rows[cont].Cells["Column4"].Value = (double)nudQtde.Value;
                dgvProdutos.Rows[cont].Cells["Column5"].Value = 0;

        }
    }
}
