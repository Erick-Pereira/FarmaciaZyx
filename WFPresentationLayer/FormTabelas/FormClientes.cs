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
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
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
            btnCadastroCliente.Enabled = false;
            btnDeleteCliente.Enabled = false;
            btnUpdateCliente.Enabled = false;
            btnCadastroCliente.Visible = false;
            btnDeleteCliente.Visible = false;
            btnUpdateCliente.Visible = false;
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
                dgvClientes.Rows[i].Cells["ClientesPontos"].Value = clientes[i].Pontos;
                dgvClientes.Rows[i].Cells["ClientesEmail"].Value = clientes[i].Email;
                dgvClientes.Rows[i].Cells["ClientesTipoCliente"].Value = tipoClienteBLL.GetByID(clientes[i].TipoClienteId).Item.Nome;
            }
        }

        private void btnDeleteCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentCell == null)
            {
                MessageBox.Show("Não é possivel deletar um cliente não selecionado");
                return;
            }
            string message = "Você realmente quer excluir este Cliente?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int rowindex = dgvClientes.CurrentCell.RowIndex;
                Response response = clienteBLL.Delete(Convert.ToInt32(dgvClientes.Rows[rowindex].Cells[0].Value));
                if (response.HasSuccess)
                {
                    dgvClientes.Rows.RemoveAt(rowindex);
                }
                MessageBox.Show(response.Message);
            }
        }

        private void btnUpdateCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentCell == null)
            {
                MessageBox.Show("Não é possivel fazer o Update um cliente não selecionado");
                return;
            }
            string message = "Você realmente Fazer o Update deste Cliente?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                btnCadastroCliente.Enabled = false;
                btnDeleteCliente.Enabled = false;
                btnUpdateCliente.Enabled = false;
                btnCadastroCliente.Visible = false;
                btnDeleteCliente.Visible = false;
                btnUpdateCliente.Visible = false;
                panelDesktopClientes.BringToFront();
                int rowindex = dgvClientes.CurrentCell.RowIndex;
                int columnindex = dgvClientes.CurrentCell.ColumnIndex;
                StaticItem.item = clienteBLL.GetByID(Convert.ToInt32(dgvClientes.Rows[rowindex].Cells[0].Value)).Item;
                OpenChildForm(new FormUpdateCliente());
            }
        }


        private void btnTabelaClientes_Click(object sender, EventArgs e)
        {
            btnCadastroCliente.Enabled = true;
            btnDeleteCliente.Enabled = true;
            btnUpdateCliente.Enabled = true;
            btnCadastroCliente.Visible = true;
            btnDeleteCliente.Visible = true;
            btnUpdateCliente.Visible = true;
            if(currentChildForm!= null)
            {
                panelDesktopClientes.SendToBack();
                currentChildForm.Close();
                clientes = clienteBLL.GetAll().Dados;
                dgvClientes.Rows.Clear();
                for (int i = 0; i < clientes.Count; i++)
                {
                    dgvClientes.Rows.Add();
                    dgvClientes.Rows[i].Cells["ClientesID"].Value = clientes[i].ID;
                    dgvClientes.Rows[i].Cells["ClientesNome"].Value = clientes[i].Nome;
                    dgvClientes.Rows[i].Cells["ClientesCPF"].Value = clientes[i].CPF;
                    dgvClientes.Rows[i].Cells["ClientesRG"].Value = clientes[i].RG;
                    dgvClientes.Rows[i].Cells["ClientesTelefone1"].Value = clientes[i].Telefone1;
                    dgvClientes.Rows[i].Cells["ClientesTelefone2"].Value = clientes[i].Telefone2;
                    dgvClientes.Rows[i].Cells["ClientesPontos"].Value = clientes[i].Pontos;
                    dgvClientes.Rows[i].Cells["ClientesEmail"].Value = clientes[i].Email;
                    dgvClientes.Rows[i].Cells["ClientesTipoCliente"].Value = tipoClienteBLL.GetByID(clientes[i].TipoClienteId).Item.Nome;
                }
            }
        }
    }
}