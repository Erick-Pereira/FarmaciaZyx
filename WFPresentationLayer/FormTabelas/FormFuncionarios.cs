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
    public partial class FormFuncionarios : Form
    {
        


        TipoFuncionarioBLL tipoFuncionarioBLL = new TipoFuncionarioBLL();
        List<FuncionarioView> funcionarios = new List<FuncionarioView>();
        FuncionarioBLL funcionarioBLL = new FuncionarioBLL();
        EnderecoBLL EnderecoBLL = new EnderecoBLL();
        public FormFuncionarios()
        {
            InitializeComponent();
        }
        private Form currentChildForm;
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
            panelDesktopFuncionarios.Controls.Add(childForm);
            panelDesktopFuncionarios.Tag = childForm;
            panelDesktopFuncionarios.BringToFront();
            childForm.Show();
        }
        private void FormFuncionarios_Load(object sender, EventArgs e)
        {
            funcionarios = funcionarioBLL.GetAllFuncionarioView().Dados;
            for (int i = 0; i < funcionarios.Count; i++)
            {
                dgvFuncionarios.Rows.Add();
                dgvFuncionarios.Rows[i].Cells["FuncionariosID"].Value = funcionarios[i].ID;
                dgvFuncionarios.Rows[i].Cells["FuncionariosNome"].Value = funcionarios[i].Nome;
                dgvFuncionarios.Rows[i].Cells["FuncionariosCPF"].Value = funcionarios[i].CPF;
                dgvFuncionarios.Rows[i].Cells["FuncionariosRG"].Value = funcionarios[i].RG;
                dgvFuncionarios.Rows[i].Cells["FuncionariosTelefone"].Value = funcionarios[i].Telefone;
                dgvFuncionarios.Rows[i].Cells["FuncionariosEmail"].Value = funcionarios[i].Email;
                dgvFuncionarios.Rows[i].Cells["FuncionariosTipoFuncionario"].Value = funcionarios[i].TipoFuncionario;
            }
        }

        private void btnCadastroFuncionario_Click(object sender, EventArgs e)
        {
            btnCadastroFuncionario.Enabled = false;
            btnDeleteFuncionario.Enabled = false;
            btnUpdateFuncionario.Enabled = false;
            btnCadastroFuncionario.Visible = false;
            btnDeleteFuncionario.Visible = false;
            btnUpdateFuncionario.Visible = false;
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
                int index = Convert.ToInt32(dgvFuncionarios.Rows[rowindex].Cells[0].Value);
                if (index == FuncionarioLogin.id)
                {
                    MessageBox.Show("Você não pode se apagar.");
                }
                else
                {

                    Response response = new Response();
                    int enderecoId = funcionarioBLL.GetByID(index).Item.EnderecoId;
                    DataResponse<Funcionario> dataResponseFuncionario = funcionarioBLL.GetAllByEnderecoId(enderecoId);
                    if(dataResponseFuncionario.Dados.Count != 1)
                    {
                        response = funcionarioBLL.Delete(index);
                    }
                    response = funcionarioBLL.Delete(index);
                    if (response.HasSuccess)
                    {
                        EnderecoBLL.Delete(enderecoId);
                    }
                    
                    dgvFuncionarios.Rows.RemoveAt(rowindex);
                    MessageBox.Show(response.Message);
                }
               
            }
        }

        private void btnUpdateFuncionario_Click(object sender, EventArgs e)
        {
            if (dgvFuncionarios.CurrentCell == null)
            {
                MessageBox.Show("Não é possivel fazer o update um Funcionario não selecionado");
                return;
            }
            string message = "Você realmente Fazer o update deste Funcionario?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                btnCadastroFuncionario.Enabled = false;
                btnDeleteFuncionario.Enabled = false;
                btnUpdateFuncionario.Enabled = false;
                btnCadastroFuncionario.Visible = false;
                btnDeleteFuncionario.Visible = false;
                btnUpdateFuncionario.Visible = false;
                int rowindex = dgvFuncionarios.CurrentCell.RowIndex;
                int index = Convert.ToInt32(dgvFuncionarios.Rows[rowindex].Cells[0].Value);
                StaticItem.item = funcionarioBLL.GetByID(index).Item;
                OpenChildForm(new FormUpdateFuncionario());
            }
        }

        private void btnTabelaFuncionarios_Click(object sender, EventArgs e)
        {
            btnCadastroFuncionario.Enabled = true;
            btnDeleteFuncionario.Enabled = true;
            btnUpdateFuncionario.Enabled = true;
            btnCadastroFuncionario.Visible = true;
            btnDeleteFuncionario.Visible = true;
            btnUpdateFuncionario.Visible = true;
            if (currentChildForm != null)
            {
                panelDesktopFuncionarios.SendToBack();
                currentChildForm.Close();
                funcionarios = funcionarioBLL.GetAllFuncionarioView().Dados;
                dgvFuncionarios.Rows.Clear();
                for (int i = 0; i < funcionarios.Count; i++)
                {
                    dgvFuncionarios.Rows.Add();
                    dgvFuncionarios.Rows[i].Cells["FuncionariosID"].Value = funcionarios[i].ID;
                    dgvFuncionarios.Rows[i].Cells["FuncionariosNome"].Value = funcionarios[i].Nome;
                    dgvFuncionarios.Rows[i].Cells["FuncionariosCPF"].Value = funcionarios[i].CPF;
                    dgvFuncionarios.Rows[i].Cells["FuncionariosRG"].Value = funcionarios[i].RG;
                    dgvFuncionarios.Rows[i].Cells["FuncionariosTelefone"].Value = funcionarios[i].Telefone;
                    dgvFuncionarios.Rows[i].Cells["FuncionariosEmail"].Value = funcionarios[i].Email;
                    dgvFuncionarios.Rows[i].Cells["FuncionariosTipoFuncionario"].Value = funcionarios[i].TipoFuncionario;
                }
            }
        }
    }
}
