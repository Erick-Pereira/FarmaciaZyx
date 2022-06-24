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
    public partial class FormCadastroProduto : Form
    {
        LaboratorioBLL laboratorioBLL = new LaboratorioBLL();
        TipoUnidadeBLL tipoUnidadeBLL = new TipoUnidadeBLL();
        public FormCadastroProduto()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ProdutoBLL produtorBLL = new ProdutoBLL();
            string nome = txtNome.Text;
            string descricao = txtDescricao.Text;
            int laboratorio = Convert.ToInt32(cmbLaboratorio.SelectedValue);
            double Valor = 0;
            int unidade = Convert.ToInt32(cmbUnidade.SelectedValue);
            Produto produto = new Produto(nome, descricao, laboratorio, unidade, Valor);
            Response response = produtorBLL.Insert(produto);
            MessageBox.Show(response.Message);
            if (response.HasSuccess)
            {
                panelCadastroLaboratorio.Visible = false;
                panelCadastroLaboratorio.Enabled = false;
                txtNome.Text = "";
                txtDescricao.Text = "";
                cmbLaboratorio.SelectedIndex = 0;
                cmbUnidade.SelectedIndex = 0;
            }
        }

        private void btnCadastrarLaboratorio_Click(object sender, EventArgs e)
        {
            panelCadastroLaboratorio.Visible = true;
            panelCadastroLaboratorio.Enabled = true;
        }

        private void FormCadastroProduto_Load(object sender, EventArgs e)
        {
            cmbLaboratorio.DataSource = laboratorioBLL.GetAll().Dados;
            cmbLaboratorio.DisplayMember = "Nome";
            cmbLaboratorio.ValueMember = "ID";
            cmbUnidade.DataSource = tipoUnidadeBLL.GetAll().Dados;
            cmbUnidade.DisplayMember = "Nome";
            cmbUnidade.ValueMember = "ID";
        }

        private void cmbLaboratorio_MouseClick(object sender, MouseEventArgs e)
        {
            cmbLaboratorio.DataSource = laboratorioBLL.GetAll().Dados;
            cmbLaboratorio.DisplayMember = "Nome";
            cmbLaboratorio.ValueMember = "ID";
        }

        private void btnCadastrarLaboratorio_Click_1(object sender, EventArgs e)
        {
            LaboratorioBLL laboratorioBLL = new LaboratorioBLL();
            string nome = txtLaboratorio.Text;
            string cnpj = mtxtCNPJ.Text;
            cnpj = cnpj.Replace(",", ".");
            Laboratorio laboratorio = new Laboratorio(nome, cnpj);
            LaboratorioValidator laboratorioValidator = new LaboratorioValidator();
            Response response = laboratorioValidator.Validate(laboratorio);
            if (response.HasSuccess)
            {
                response = laboratorioBLL.Insert(laboratorio);
                if (response.HasSuccess)
                {
                    txtLaboratorio.Text = "";
                    mtxtCNPJ.Text = "";
                }
            }
            MessageBox.Show(response.Message);
        }
    }
}
