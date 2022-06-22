using BusinessLogicalLayer;
using Entities;
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
    public partial class FormClientes : Form
    {
        private Form currentChildForm;
        TipoClienteBLL tipoClienteBLL = new TipoClienteBLL();
        List<Cliente> clientes = new List<Cliente>();
        ClienteBLL clienteBLL = new ClienteBLL();
        public FormClientes()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm)
        {
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktopClientes.Controls.Add(childForm);
            panelDesktopClientes.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            panelDesktopClientes.BringToFront();
            OpenChildForm(new FormCadastroCliente());
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {


            clientes = clienteBLL.GetAll().Dados;
            for (int i = 0; i < clientes.Count; i++)
            {
                dgvClientes.Rows.Add();
                dgvClientes.Rows[i].Cells["ClientesID"].Value = clientes[i].ID;
                dgvClientes.Rows[i].Cells["ClientesNome"].Value = clientes[i].Nome;
                dgvClientes.Rows[i].Cells["ClientesCPF"].Value = clientes[i].CPF;
                dgvClientes.Rows[i].Cells["ClientesRG"].Value = clientes[i].RG;
                dgvClientes.Rows[i].Cells["ClientesTelefone1"].Value = clientes[i].Telefone1;
                dgvClientes.Rows[i].Cells["ClientesTelefone2"].Value = clientes[i].Telefone2;
                dgvClientes.Rows[i].Cells["FuncionariosTelefone"].Value = clientes[i].Pontos;
                dgvClientes.Rows[i].Cells["FuncionariosEmail"].Value = clientes[i].Email;
                dgvClientes.Rows[i].Cells["ClientesTipoCliente"].Value = tipoClienteBLL.GetByID(clientes[i].TipoClienteId).Item.Nome;
            }
        }
    }
}
