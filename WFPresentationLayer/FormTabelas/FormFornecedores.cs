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
    public partial class FormFornecedores : Form
    {
        public FormFornecedores()
        {
            InitializeComponent();
        }

        private Form currentChildForm;


        FornecedorBLL fornecedorBLL = new FornecedorBLL();
        List<Fornecedor> fornecedores = new List<Fornecedor>();
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
            panelDesktopFornecedores.Controls.Add(childForm);
            panelDesktopFornecedores.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCadastroFornecedor_Click(object sender, EventArgs e)
        {
            btnCadastroFornecedor.Enabled = false;
            btnDeleteFornecedor.Enabled = false;
            btnUpdateFornecedor.Enabled = false;
            btnCadastroFornecedor.Visible = false;
            btnDeleteFornecedor.Visible = false;
            btnUpdateFornecedor.Visible = false;
            panelDesktopFornecedores.BringToFront();
            OpenChildForm(new FormCadastroFornecedor());
        }

        private void FormFornecedores_Load(object sender, EventArgs e)
        {
            fornecedores = fornecedorBLL.GetAll().Dados;
            for (int i = 0; i < fornecedores.Count; i++)
            {
                dgvFornecedores.Rows.Add();
                dgvFornecedores.Rows[i].Cells["FornecedoresID"].Value = fornecedores[i].ID;
                dgvFornecedores.Rows[i].Cells["FornecedoresRazaoSocial"].Value = fornecedores[i].RazaoSocial;
                dgvFornecedores.Rows[i].Cells["FornecedoresCNPJ"].Value = fornecedores[i].CNPJ;
                dgvFornecedores.Rows[i].Cells["FornecedoresNomeContato"].Value = fornecedores[i].NomeContato;
                dgvFornecedores.Rows[i].Cells["FornecedoresTelefone"].Value = fornecedores[i].Telefone;
                dgvFornecedores.Rows[i].Cells["FornecedoresEmail"].Value = fornecedores[i].Email;

            }
        }

        private void btnDeleteFornecedor_Click(object sender, EventArgs e)
        {
            if (dgvFornecedores.CurrentCell == null)
            {
                MessageBox.Show("Não é possivel deletar um fornecedor não selecionado");
                return;
            }

            string message = "Você realmente quer excluir este Fornecedor?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int rowindex = dgvFornecedores.CurrentCell.RowIndex;
                Response response = fornecedorBLL.Delete(Convert.ToInt32(dgvFornecedores.Rows[rowindex].Cells[0].Value));
                if (response.HasSuccess)
                {
                    dgvFornecedores.Rows.RemoveAt(rowindex);
                }
                MessageBox.Show(response.Message);
            }
        }

        private void btnUpdateFornecedor_Click(object sender, EventArgs e)
        {
            if (dgvFornecedores.CurrentCell == null)
            {
                MessageBox.Show("Não é possivel fazer o update um Fornecedor não selecionado");
                return;
            }
            string message = "Você realmente Fazer o update deste Fornecedor?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {

                btnCadastroFornecedor.Enabled = false;
                btnDeleteFornecedor.Enabled = false;
                btnUpdateFornecedor.Enabled = false;
                btnCadastroFornecedor.Visible = false;
                btnDeleteFornecedor.Visible = false;
                btnUpdateFornecedor.Visible = false;
                int rowindex = dgvFornecedores.CurrentCell.RowIndex;
                int columnindex = dgvFornecedores.CurrentCell.ColumnIndex;
                StaticItem.item = fornecedorBLL.GetByID(Convert.ToInt32(dgvFornecedores.Rows[rowindex].Cells[0].Value)).Item;
                OpenChildForm(new FormUpdateFornecedor());
            }
        }

        private void btnTabelaFornecedores_Click(object sender, EventArgs e)
        {

            btnCadastroFornecedor.Enabled = true;
            btnDeleteFornecedor.Enabled = true;
            btnUpdateFornecedor.Enabled = true;
            btnCadastroFornecedor.Visible = true;
            btnDeleteFornecedor.Visible = true;
            btnUpdateFornecedor.Visible = true;
            if (currentChildForm != null)
            {
                panelDesktopFornecedores.SendToBack();
                currentChildForm.Close();
                fornecedores = fornecedorBLL.GetAll().Dados;
                dgvFornecedores.Rows.Clear();
                for (int i = 0; i < fornecedores.Count; i++)
                {
                    dgvFornecedores.Rows.Add();
                    dgvFornecedores.Rows[i].Cells["FornecedoresID"].Value = fornecedores[i].ID;
                    dgvFornecedores.Rows[i].Cells["FornecedoresRazaoSocial"].Value = fornecedores[i].RazaoSocial;
                    dgvFornecedores.Rows[i].Cells["FornecedoresCNPJ"].Value = fornecedores[i].CNPJ;
                    dgvFornecedores.Rows[i].Cells["FornecedoresNomeContato"].Value = fornecedores[i].NomeContato;
                    dgvFornecedores.Rows[i].Cells["FornecedoresTelefone"].Value = fornecedores[i].Telefone;
                    dgvFornecedores.Rows[i].Cells["FornecedoresEmail"].Value = fornecedores[i].Email;

                }
            }
        }
    }
}
