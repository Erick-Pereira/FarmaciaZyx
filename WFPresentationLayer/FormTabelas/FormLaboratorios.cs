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
    public partial class FormLaboratorios : Form
    {
        public FormLaboratorios()
        {
            InitializeComponent();
        }


        private Form currentChildForm;
        List<Laboratorio> laboratorios = new List<Laboratorio>();
        LaboratorioBLL laboratorioBLL = new LaboratorioBLL();
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
            panelDesktopLaboratorios.Controls.Add(childForm);
            panelDesktopLaboratorios.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        private void btnTabelaLaboratorios_Click(object sender, EventArgs e)
        {
            btnCadastroLaboratorio.Enabled = true;
            btnDeleteLaboratorio.Enabled = true;
            btnUpdateLaboratorio.Enabled = true;
            btnCadastroLaboratorio.Visible = true;
            btnDeleteLaboratorio.Visible = true;
            btnUpdateLaboratorio.Visible = true;
            if (currentChildForm != null)
            {
                panelDesktopLaboratorios.SendToBack();
                currentChildForm.Close();
                laboratorios = laboratorioBLL.GetAll().Dados;
                dgvLaboratorios.Rows.Clear();
                for (int i = 0; i < laboratorios.Count; i++)
                {
                    dgvLaboratorios.Rows.Add();
                    dgvLaboratorios.Rows[i].Cells["laboratoriosID"].Value = laboratorios[i].ID;
                    dgvLaboratorios.Rows[i].Cells["laboratoriosNome"].Value = laboratorios[i].Nome;

                }
            }
        }


        private void btnCadastroLaboratorio_Click(object sender, EventArgs e)
        {
            btnCadastroLaboratorio.Enabled = false;
            btnDeleteLaboratorio.Enabled = false;
            btnUpdateLaboratorio.Enabled = false;
            btnCadastroLaboratorio.Visible = false;
            btnDeleteLaboratorio.Visible = false;
            btnUpdateLaboratorio.Visible = false;
            panelDesktopLaboratorios.BringToFront();
            OpenChildForm(new FormCadastroLaboratorio());
        }

        private void btnUpdateLaboratorio_Click(object sender, EventArgs e)
        {

            if (dgvLaboratorios.CurrentCell == null)
            {
                MessageBox.Show("Não é possivel fazer o update um Laboratorio não selecionado");
                return;
            }
            string message = "Você realmente Fazer o update deste Laboratorio?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                btnCadastroLaboratorio.Enabled = false;
                btnDeleteLaboratorio.Enabled = false;
                btnUpdateLaboratorio.Enabled = false;
                btnCadastroLaboratorio.Visible = false;
                btnDeleteLaboratorio.Visible = false;
                btnUpdateLaboratorio.Visible = false;
                int rowindex = dgvLaboratorios.CurrentCell.RowIndex;
                OpenChildForm(new FormUpdateLaboratorio(laboratorioBLL.GetByID(Convert.ToInt32(dgvLaboratorios.Rows[rowindex].Cells[0].Value)).Item));
            }
        }

        private void btnDeleteLaboratorio_Click(object sender, EventArgs e)
        {
            if (dgvLaboratorios.CurrentCell == null)
            {
                MessageBox.Show("Não é possivel deletar um Laboratorio não selecionado");
                return;
            }
            string message = "Você realmente quer excluir este Laboratorio?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int rowindex = dgvLaboratorios.CurrentCell.RowIndex;
                Response response = laboratorioBLL.Delete(Convert.ToInt32(dgvLaboratorios.Rows[rowindex].Cells[0].Value));
                if (response.HasSuccess)
                {
                    dgvLaboratorios.Rows.RemoveAt(rowindex);
                }
                MessageBox.Show(response.Message);
            }
        }

        private void FormLaboratorios_Load(object sender, EventArgs e)
        {

            laboratorios = laboratorioBLL.GetAll().Dados;
            for (int i = 0; i < laboratorios.Count; i++)
            {
                dgvLaboratorios.Rows.Add();
                dgvLaboratorios.Rows[i].Cells["LaboratoriosID"].Value = laboratorios[i].ID;
                dgvLaboratorios.Rows[i].Cells["LaboratoriosNome"].Value = laboratorios[i].Nome;
            }
        }
    }
}



