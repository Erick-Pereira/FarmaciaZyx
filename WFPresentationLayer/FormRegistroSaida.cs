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

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            Produto produto = produtorBLL.GetByID(Convert.ToInt32(cmbProduto.SelectedValue)).Item;
            if (produto != null)
            {

                produto.QtdEstoque = (double)nudQtde.Value;
                produtos.Add(produto);
                dgvProdutosSaida.Rows.Add();
                for (int i = 0; i < produtos.Count; i++)
                {
                    dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaID"].Value = produtos[i].ID;
                    dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaNome"].Value = produtos[i].Nome;
                    dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaUn"].Value = TipoUnidadeBLL.GetById(produtos[i].TipoUnidadeId).Item.Nome;
                    dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaQtde"].Value = produtos[i].QtdEstoque;
                    dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaValor"].Value = produtos[i].Valor;
                }
            }
        }

        private void btnRetirarProduto_Click(object sender, EventArgs e)
        {
            if (dgvProdutosSaida.CurrentCell == null)
            {
                MessageBox.Show("Não é possivel retirar um produto não selecionado");
                return;
            }
            int rowindex = dgvProdutosSaida.CurrentCell.RowIndex;
            int columnindex = dgvProdutosSaida.CurrentCell.ColumnIndex;
            //MessageBox.Show(dgvProdutos.Rows[rowindex].Cells[columnindex].Value.ToString());
            produtos.RemoveAt(rowindex);
            dgvProdutosSaida.Rows.RemoveAt(rowindex);
            for (int i = 0; i < produtos.Count; i++)
            {
                dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaID"].Value = produtos[i].ID;
                dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaNome"].Value = produtos[i].Nome;
                dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaUn"].Value = TipoUnidadeBLL.GetById(produtos[i].TipoUnidadeId).Item.Nome;
                dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaQtde"].Value = produtos[i].QtdEstoque;
                dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaValor"].Value = produtos[i].Valor;
            }
        }
    }
}

