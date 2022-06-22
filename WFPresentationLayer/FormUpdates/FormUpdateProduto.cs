using BusinessLogicalLayer;
using Entities;
using Shared;
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
    public partial class FormUpdateProduto : Form
    {
        public FormUpdateProduto()
        {
            InitializeComponent();
        }
        private Form currentChildForm;
        LaboratorioBLL laboratorioBLL = new LaboratorioBLL();
        TipoUnidadeBLL tipoUnidadeBLL = new TipoUnidadeBLL();
        Produto produto = (Produto)StaticItem.item;
        private void OpenChildForm(Form childForm)
        {
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelCadastroLaboratorio.Controls.Add(childForm);
            panelCadastroLaboratorio.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void FormUpdateProduto_Load(object sender, EventArgs e)
        {
            cmbLaboratorio.DataSource = laboratorioBLL.GetAll().Dados;
            cmbLaboratorio.DisplayMember = "Nome";
            cmbLaboratorio.ValueMember = "ID";
            cmbUnidade.DataSource = tipoUnidadeBLL.GetAll().Dados;
            cmbUnidade.DisplayMember = "Nome";
            cmbUnidade.ValueMember = "ID";
            txtNome.Text = produto.Nome;
            txtDescricao.Text = produto.Descricao;
            cmbLaboratorio.SelectedValue = produto.LaboratorioId;
            nudValor.Value = (decimal)produto.Valor;
            //nudValor.Text = produto.QtdEstoque;
            cmbUnidade.SelectedValue = produto.TipoUnidadeId;
        }
        private void btnCadastrarLaboratorio_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCadastroLaboratorio());
        }

        private void btnUpdateProduto_Click(object sender, EventArgs e)
        {
            Produto update = new Produto();
            update.ID = produto.ID;
            update.Nome = txtNome.Text;
            update.Descricao = txtDescricao.Text;
            update.LaboratorioId = Convert.ToInt32(cmbLaboratorio.SelectedValue);
            update.Valor = (double)nudValor.Value;
            update.TipoUnidadeId = Convert.ToInt32(cmbUnidade.SelectedValue);
            ProdutoValidator produtoValidator = new ProdutoValidator();
            Response response = produtoValidator.Validate(update);
            if (response.HasSuccess)
            {
                ProdutorBLL produtorBLL = new ProdutorBLL();
                Response response1 = produtorBLL.Update(update);
                MessageBox.Show(response1.Message);
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }
        private void cmbLaboratorio_MouseClick(object sender, MouseEventArgs e)
        {
            cmbLaboratorio.DataSource = laboratorioBLL.GetAll().Dados;
            cmbLaboratorio.DisplayMember = "Nome";
            cmbLaboratorio.ValueMember = "ID";
        }
    }
}





