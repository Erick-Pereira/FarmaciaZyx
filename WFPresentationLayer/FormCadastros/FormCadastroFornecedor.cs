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
    public partial class FormCadastroFornecedor : Form
    {
        public FormCadastroFornecedor()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string razaoSocial = txtRazaoSocial.Text;
            string cnpj = mtxtCnpj.Text;
            string nomeContato = txtNomeContato.Text;
            string telefone = mtxtTelefone.Text;
            string email = txtEmail.Text;
            Fornecedor fornecedor = new Fornecedor(razaoSocial, cnpj, nomeContato, telefone, email);
            FornecedorBLL fornecedorBLL = new FornecedorBLL();
            Response response = fornecedorBLL.Insert(fornecedor);
            MessageBox.Show(response.Message);
            
        }
    }
}
