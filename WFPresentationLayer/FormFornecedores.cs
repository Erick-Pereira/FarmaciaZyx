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
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktopFornecedores.Controls.Add(childForm);
            panelDesktopFornecedores.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void FormFuncionarios_Load(object sender, EventArgs e)
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

        private void btnCadastroFornecedor_Click(object sender, EventArgs e)
        {
            panelDesktopFornecedores.BringToFront();
            OpenChildForm(new FormCadastroFornecedor());
        }
    }
}
