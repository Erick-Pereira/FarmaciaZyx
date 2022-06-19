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
        public FormCadastroProduto()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            ProdutorBLL produtorBLL = new ProdutorBLL();
            string nome = txtNome.Text;
            string descricao = txtDescricao.Text;
            string laboratorio = txtLaboratorio.Text;
            double qtdEstoque = (double)nudQtdEstoque.Value;
            Produto produto = new Produto(nome, descricao, laboratorio, qtdEstoque);
            Response response = produtorBLL.CreateProduto(produto);
            MessageBox.Show(response.Message);
        }
    }
}
