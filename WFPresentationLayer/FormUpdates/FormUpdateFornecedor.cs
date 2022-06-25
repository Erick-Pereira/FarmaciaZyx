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
    public partial class FormUpdateFornecedor : Form
    {
        public FormUpdateFornecedor()
        {
            InitializeComponent();
        }
        FornecedorValidator fornecedorValidator = new FornecedorValidator();
        FornecedorBLL fornecedorBLL = new FornecedorBLL();


        Fornecedor fornecedor = (Fornecedor)StaticItem.item;

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Fornecedor update = new Fornecedor();
            update.ID = fornecedor.ID;
            update.NomeContato = txtNomeContato.Text;
            update.RazaoSocial = txtRazaoSocial.Text;
            update.CNPJ = mtxtCnpj.Text;
            update.Telefone = mtxtTelefone.Text;
            update.Email = txtEmail.Text;
            update.CNPJ = update.CNPJ.Replace(",", ".");
            Response response = fornecedorValidator.Validate(update);
            if (response.HasSuccess)
            {
                response = fornecedorBLL.Update(update);
            }
                MessageBox.Show(response.Message);
           
        }

        private void FormUpdateFornecedor_Load(object sender, EventArgs e)
        {
            txtRazaoSocial.Text = fornecedor.RazaoSocial;
            txtNomeContato.Text = fornecedor.NomeContato;
            mtxtCnpj.Text = fornecedor.CNPJ;
            mtxtTelefone.Text = fornecedor.Telefone;
            txtEmail.Text = fornecedor.Email;
        }
    }
}