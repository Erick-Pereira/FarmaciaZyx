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
    public partial class FormUpdateCliente : Form
    {
        TipoClienteBLL tipoClienteBLL = new TipoClienteBLL();
        public FormUpdateCliente()
        {
            InitializeComponent();
        }
        Cliente cliente = (Cliente)StaticItem.item;
        private void FormUpdateCliente_Load(object sender, EventArgs e)
        {
            cmbTipoCliente.DataSource = tipoClienteBLL.GetAll().Dados;
            cmbTipoCliente.DisplayMember = "Nome";
            cmbTipoCliente.ValueMember = "ID";
            txtNome.Text = cliente.Nome;
            mtxtCpf.Text = cliente.CPF;
            mtxtTelefone1.Text = cliente.Telefone1;
            mtxtTelefone2.Text = cliente.Telefone2;
            mtxtRg.Text = cliente.RG;
            txtEmail.Text = cliente.Email;
            cmbTipoCliente.SelectedValue = cliente.TipoClienteId;           
        }

        private void btnUpdateCliente_Click(object sender, EventArgs e)
        {
            Cliente update = new Cliente();
            update.ID = cliente.ID;
            update.Nome = txtNome.Text;
            update.CPF = mtxtCpf.Text;
            update.Telefone1 = mtxtTelefone1.Text;
            update.RG = mtxtRg.Text;
            update.Telefone2 = mtxtTelefone2.Text;
            update.Email = txtEmail.Text;
            update.CPF = update.CPF.Replace(",", ".");
            update.RG = update.RG.Replace(",", ".");
            update.TipoClienteId = Convert.ToInt32(cmbTipoCliente.SelectedValue);
            ClienteValidator clienteValidator = new ClienteValidator();
            Response response = clienteValidator.Validate(update);
            if (response.HasSuccess)
            {
                ClienteBLL clienteBLL = new ClienteBLL();
                Response response1 = clienteBLL.Update(update);
                MessageBox.Show(response1.Message);
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }
    }
}
