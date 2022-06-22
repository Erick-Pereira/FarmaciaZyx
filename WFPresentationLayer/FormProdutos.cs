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
                dgvFuncionarios.Rows.Add();
                dgvFuncionarios.Rows[i].Cells["ProdutosID"].Value = produtos[i].ID;
                dgvFuncionarios.Rows[i].Cells["ProdutosNome"].Value = produtos[i].Nome;
                dgvFuncionarios.Rows[i].Cells["ProdutosQtdEstoque"].Value = produtos[i].QtdEstoque;
                dgvFuncionarios.Rows[i].Cells["ProdutosLaboratorio"].Value = tipoUnidadeBLL.GetById(produtos[i].TipoUnidadeId).Item.Nome;
                dgvFuncionarios.Rows[i].Cells["ProdutosTipoUnidade"].Value = produtos[i].Descricao;
                dgvFuncionarios.Rows[i].Cells["ProdutosValor"].Value = produtos[i].Valor;
            }
        }
    }
}
