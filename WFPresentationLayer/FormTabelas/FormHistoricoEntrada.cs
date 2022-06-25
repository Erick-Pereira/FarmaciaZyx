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
    public partial class FormHistoricoEntrada : Form
    {
        public FormHistoricoEntrada()
        {
            InitializeComponent();
        }

        EntradaBLL entradaBLL = new EntradaBLL();
        FuncionarioBLL funcionarioBLL = new FuncionarioBLL();
        FornecedorBLL fornecedorBLL = new FornecedorBLL();

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
            panelDesktopEntradas.Controls.Add(childForm);
            panelDesktopEntradas.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void FormHistoricoEntrada_Load(object sender, EventArgs e)
        {
            DataResponse<Entrada> dataResponse = entradaBLL.GetAll();
            for (int i = 0; i < dataResponse.Dados.Count; i++)
            {
                dgvEntradas.Rows.Add();
                dgvEntradas.Rows[i].Cells["EntradaID"].Value = dataResponse.Dados[i].ID;
                dgvEntradas.Rows[i].Cells["EntradaFornecedor"].Value = fornecedorBLL.GetByID(dataResponse.Dados[i].FornecedorID).Item.RazaoSocial;
                dgvEntradas.Rows[i].Cells["EntradaFuncionario"].Value = funcionarioBLL.GetByID(dataResponse.Dados[i].FuncionarioId).Item.Nome;
                dgvEntradas.Rows[i].Cells["EntradaData"].Value = dataResponse.Dados[i].DataEntrada;
                dgvEntradas.Rows[i].Cells["EntradaValor"].Value = dataResponse.Dados[i].Valor;
            }
        }

        private void btnTabelaFuncionarios_Click(object sender, EventArgs e)
        {
            btnInformacoesEntrada.Enabled = true;
            if (currentChildForm != null)
            {
                panelDesktopEntradas.SendToBack();
                currentChildForm.Close();
                dgvEntradas.Rows.Clear();
                DataResponse<Entrada> dataResponse = entradaBLL.GetAll();
                for (int i = 0; i < dataResponse.Dados.Count; i++)
                {
                    dgvEntradas.Rows.Add();
                    dgvEntradas.Rows[i].Cells["EntradaID"].Value = dataResponse.Dados[i].ID;
                    dgvEntradas.Rows[i].Cells["EntradaFornecedor"].Value = fornecedorBLL.GetByID(dataResponse.Dados[i].FornecedorID).Item.RazaoSocial;
                    dgvEntradas.Rows[i].Cells["EntradaFuncionario"].Value = funcionarioBLL.GetByID(dataResponse.Dados[i].FuncionarioId).Item.Nome;
                    dgvEntradas.Rows[i].Cells["EntradaData"].Value = dataResponse.Dados[i].DataEntrada;
                    dgvEntradas.Rows[i].Cells["EntradaValor"].Value = dataResponse.Dados[i].Valor;
                    // dgvEntradas.Rows[i].Cells["FuncionariosTipoFuncionario"].Value = .GetByID(funcionarios[i].TipoFuncionarioId).Item.Nome;
                }
            }
        }

        private void btnInformacoesEntrada_Click(object sender, EventArgs e)
        {
            panelDesktopEntradas.BringToFront();
            OpenChildForm(new FormInformacoesAdicionaisEntrada());
        }
    }
}
