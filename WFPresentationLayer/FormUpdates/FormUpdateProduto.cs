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
        LaboratorioBLL laboratorioBLL = new LaboratorioBLL();
        TipoUnidadeBLL tipoUnidadeBLL = new TipoUnidadeBLL();
        Produto produto = (Produto)StaticItem.item;


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
                ProdutoBLL produtorBLL = new ProdutoBLL();
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

        private void btnCadastrarLaboratorio_Click(object sender, EventArgs e)
        {
            panelCadastroLaboratorio.Visible = true;
            panelCadastroLaboratorio.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
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





