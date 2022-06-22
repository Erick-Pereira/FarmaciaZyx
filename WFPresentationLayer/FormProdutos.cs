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
    public partial class FormProdutos : Form
    {
        private Form currentChildForm;


        List<Produto> produtos = new List<Produto>();
        ProdutorBLL produtorBLL = new ProdutorBLL();
        TipoUnidadeBLL tipoUnidadeBLL = new TipoUnidadeBLL();
        LaboratorioBLL laboratorioBLL = new LaboratorioBLL();
        public FormProdutos()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm)
        {
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktopProdutos.Controls.Add(childForm);
            panelDesktopProdutos.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            panelDesktopProdutos.BringToFront();
            OpenChildForm(new FormCadastroProduto());
            
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {
            produtos = produtorBLL.GetAll().Dados;
            for (int i = 0; i < produtos.Count; i++)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[i].Cells["ProdutosID"].Value = produtos[i].ID;
                dgvProdutos.Rows[i].Cells["ProdutosNome"].Value = produtos[i].Nome;
                dgvProdutos.Rows[i].Cells["ProdutosQtdEstoque"].Value = produtos[i].QtdEstoque;
                dgvProdutos.Rows[i].Cells["ProdutosDescricao"].Value = produtos[i].Descricao;
                dgvProdutos.Rows[i].Cells["ProdutosLaboratorio"].Value = laboratorioBLL.GetByID(produtos[i].LaboratorioId).Item.Nome;
                dgvProdutos.Rows[i].Cells["ProdutosTipoUnidade"].Value = tipoUnidadeBLL.GetById(produtos[i].TipoUnidadeId).Item.Nome;
                dgvProdutos.Rows[i].Cells["ProdutosValor"].Value = produtos[i].Valor;
            }
        }

        private void btnDeleteProduto_Click(object sender, EventArgs e)
        {


            if (dgvProdutos.CurrentCell == null)
            {
                MessageBox.Show("Não é possivel retirar um produto não selecionado");
                return;
            }
            int rowindex = dgvProdutos.CurrentCell.RowIndex;
            int columnindex = dgvProdutos.CurrentCell.ColumnIndex;
            produtorBLL.Delete(Convert.ToInt32(dgvProdutos.Rows[rowindex].Cells[columnindex].Value));
            dgvProdutos.Rows.RemoveAt(rowindex);
        }
    }
}
