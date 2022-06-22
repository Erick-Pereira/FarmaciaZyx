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
    public partial class FormFuncionarios : Form
    {
        private Form currentChildForm;


        TipoFuncionarioBLL tipoFuncionarioBLL = new TipoFuncionarioBLL();
        List<Funcionario> funcionarios = new List<Funcionario>();
        FuncionarioBLL funcionarioBLL = new FuncionarioBLL();
        public FormFuncionarios()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm)
        {
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktopFuncionarios.Controls.Add(childForm);
            panelDesktopFuncionarios.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void FormFuncionarios_Load(object sender, EventArgs e)
        {

            funcionarios = funcionarioBLL.GetAll().Dados;
            for (int i = 0; i < funcionarios.Count; i++)
            {
                dgvFuncionarios.Rows.Add();
                dgvFuncionarios.Rows[i].Cells["FuncionariosID"].Value = funcionarios[i].ID;
                dgvFuncionarios.Rows[i].Cells["FuncionariosNome"].Value = funcionarios[i].Nome;
                dgvFuncionarios.Rows[i].Cells["FuncionariosCPF"].Value = funcionarios[i].CPF;
                dgvFuncionarios.Rows[i].Cells["FuncionariosRG"].Value = funcionarios[i].RG;
                dgvFuncionarios.Rows[i].Cells["FuncionariosTelefone"].Value = funcionarios[i].Telefone;
                dgvFuncionarios.Rows[i].Cells["FuncionariosEmail"].Value = funcionarios[i].Email;
                dgvFuncionarios.Rows[i].Cells["FuncionariosTipoFuncionario"].Value = tipoFuncionarioBLL.GetByID(funcionarios[i].TipoFuncionarioId).Item.Nome;
            }
        }

        private void btnCadastroFuncionario_Click(object sender, EventArgs e)
        {
            panelDesktopFuncionarios.BringToFront();
            OpenChildForm(new FormCadastroFuncionario());
        }

        private void btnDeleteFuncionario_Click(object sender, EventArgs e)
        {
            if (dgvFuncionarios.CurrentCell == null)
            {
                MessageBox.Show("Não é possivel deletar um funcionario não selecionado");
                return;
            }
            string message = "Você realmente quer excluir este Funcionario?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int rowindex = dgvFuncionarios.CurrentCell.RowIndex;
                int columnindex = dgvFuncionarios.CurrentCell.ColumnIndex;
                funcionarioBLL.Delete(Convert.ToInt32(dgvFuncionarios.Rows[rowindex].Cells[columnindex].Value));
                dgvFuncionarios.Rows.RemoveAt(rowindex);
            }
        }
    }
}
