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
    public partial class FormRegistroSaida : Form
    {
        List<Produto> produtos = new List<Produto>();

        ClienteBLL clienteBLL = new ClienteBLL();
        ProdutorBLL produtorBLL = new ProdutorBLL();
        TipoUnidadeBLL TipoUnidadeBLL = new TipoUnidadeBLL();    

        public FormRegistroSaida()
        {
            InitializeComponent();

            //cmbUnidade.DataSource = TipoUnidadeBLL.GetAll().Dados;
            //cmbUnidade.DisplayMember = "Nome";
            //cmbUnidade.ValueMember = "ID";
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

        private void FormRegistroSaida_Load(object sender, EventArgs e)
        {
            cmbCliente.DataSource = clienteBLL.GetAll().Dados;
            cmbCliente.DisplayMember = "Nome";
            cmbCliente.ValueMember = "ID";
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
                dgvProdutos.Rows[i].Cells["Preço"].Value = produtos[i].Valor;
            }
        }
    }
}

