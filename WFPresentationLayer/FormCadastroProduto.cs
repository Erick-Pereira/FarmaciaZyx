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
        public FormCadastroProduto()
        {
            InitializeComponent();
            cmbLaboratorio.DataSource = laboratorioBLL.GetAll().Dados;
            cmbLaboratorio.DisplayMember = "Nome";
            cmbLaboratorio.ValueMember = "ID";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            ProdutorBLL produtorBLL = new ProdutorBLL();
            string nome = txtNome.Text;
            string descricao = txtDescricao.Text;
            int laboratorio = (cmbLaboratorio.SelectedIndex)+1;
            double qtdEstoque = (double)nudQtdEstoque.Value;
            Produto produto = new Produto(nome, descricao, laboratorio, qtdEstoque);
            Response response = produtorBLL.CreateProduto(produto);
            MessageBox.Show(response.Message);
        }
    }
}
