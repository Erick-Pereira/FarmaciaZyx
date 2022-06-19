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
    public partial class FormCadastroCliente : Form
    {
        TipoClienteBLL tipoClienteBLL = new TipoClienteBLL();
        public FormCadastroCliente()
        {
            InitializeComponent();
            cmbTipoCliente.DataSource = tipoClienteBLL.GetAll().Dados;
            cmbTipoCliente.DisplayMember = "Nome";
            cmbTipoCliente.ValueMember = "ID";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string cpf = mtxtCpf.Text;
            string rg = mtxtRg.Text;
            string telefone1 = mtxtTelefone1.Text;
            string telefone2 = mtxtTelefone2.Text;
            int tipoCliente = (cmbTipoCliente.SelectedIndex)+1;
            Cliente cliente = new Cliente(nome,rg,cpf,telefone1,telefone2,email, tipoCliente);
            ClienteBLL clienteBLL = new ClienteBLL();
            Response response = clienteBLL.Insert(cliente);
            MessageBox.Show(response.Message);
        }
    }
}
