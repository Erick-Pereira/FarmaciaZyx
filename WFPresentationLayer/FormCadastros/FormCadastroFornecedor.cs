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
        FornecedorValidator fornecedorValidator = new FornecedorValidator();
        FornecedorBLL fornecedorBLL = new FornecedorBLL();
        public FormCadastroFornecedor()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Response response = new Response();
            string razaoSocial = txtRazaoSocial.Text;
            string cnpj = mtxtCnpj.Text;
            cnpj = cnpj.Replace(",", ".");
            string nomeContato = txtNomeContato.Text;
            string telefone = mtxtTelefone.Text;
            string email = txtEmail.Text;
            Fornecedor fornecedor = new Fornecedor(razaoSocial, cnpj, nomeContato, telefone, email);
            response = fornecedorValidator.Validate(fornecedor);
            if (response.HasSuccess)
            {
                response = fornecedorBLL.Insert(fornecedor);
                if (response.HasSuccess)
                {
                    txtRazaoSocial.Text = "";
                    mtxtCnpj.Text = "";
                    txtNomeContato.Text = "";
                    mtxtTelefone.Text = "";
                    txtEmail.Text = "";
                }
            }
            MessageBox.Show(response.Message);
        }
    }
}
