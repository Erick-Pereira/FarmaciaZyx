using BusinessLogicalLayer;
using DataAccessLayer;
using Entities;
using Entities.Filters;
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
            DataResponse<EntradaView> dataResponse = entradaBLL.GetAll();
            for (int i = 0; i < dataResponse.Dados.Count; i++)
            {
                dgvEntradas.Rows.Add();
                dgvEntradas.Rows[i].Cells["EntradaID"].Value = dataResponse.Dados[i].ID;
                dgvEntradas.Rows[i].Cells["EntradaFornecedor"].Value = dataResponse.Dados[i].Fornecedor;
                dgvEntradas.Rows[i].Cells["EntradaFuncionario"].Value = dataResponse.Dados[i].Funcionario;
                dgvEntradas.Rows[i].Cells["EntradaData"].Value = dataResponse.Dados[i].DataEntrada;
                dgvEntradas.Rows[i].Cells["EntradaValor"].Value = dataResponse.Dados[i].Valor;
            }
        }

        private void btnTabelaFuncionarios_Click(object sender, EventArgs e)
        {
            btnInformacoesEntrada.Enabled = true;
            btnInformacoesEntrada.Visible = true;
            if (currentChildForm != null)
            {
                panelDesktopEntradas.SendToBack();
                currentChildForm.Close();
                dgvEntradas.Rows.Clear();
                DataResponse<EntradaView> dataResponse = entradaBLL.GetAll();
                for (int i = 0; i < dataResponse.Dados.Count; i++)
                {
                    dgvEntradas.Rows.Add();
                    dgvEntradas.Rows[i].Cells["EntradaID"].Value = dataResponse.Dados[i].ID;
                    dgvEntradas.Rows[i].Cells["EntradaFornecedor"].Value = dataResponse.Dados[i].Fornecedor;
                    dgvEntradas.Rows[i].Cells["EntradaFuncionario"].Value = dataResponse.Dados[i].Funcionario;
                    dgvEntradas.Rows[i].Cells["EntradaData"].Value = dataResponse.Dados[i].DataEntrada;
                    dgvEntradas.Rows[i].Cells["EntradaValor"].Value = dataResponse.Dados[i].Valor;
                }
            }
        }

        private void btnInformacoesEntrada_Click(object sender, EventArgs e)
        {
            if (dgvEntradas.CurrentCell == null)
            {
                MessageBox.Show("Não é possivel ver as informações adicionais de uma Entrada não selecionada");
                return;
            }
            string message = "Você realmente  ver as informações adicionais desta Entrada?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int rowindex = dgvEntradas.CurrentCell.RowIndex;
                int index = Convert.ToInt32(dgvEntradas.Rows[rowindex].Cells[0].Value);
                btnInformacoesEntrada.Enabled = false;
                btnInformacoesEntrada.Visible = false;
                panelDesktopEntradas.BringToFront();
                OpenChildForm(new FormInformacoesAdicionaisEntrada(entradaBLL.GetByID(index).Item));
            }
        }

        private void btnFiltrarDatas_Click(object sender, EventArgs e)
        {
            dgvEntradas.Rows.Clear();
            FiltersEntrada filtersEntrada = new FiltersEntrada();
            string inicio= dtpDataEntrada.Value.ToString("MM/dd/yyyy 12:00");
            filtersEntrada.Inicio = DateTime.Parse(inicio);
            string fim =dtpDataSaída.Value.ToString("MM/dd/yyyy 23:59");
            filtersEntrada.Fim = DateTime.Parse(fim);
            DataResponse<EntradaView> dataResponse = entradaBLL.GetByDate(filtersEntrada);
            for (int i = 0; i < dataResponse.Dados.Count; i++)
            {
                dgvEntradas.Rows.Add();
                dgvEntradas.Rows[i].Cells["EntradaID"].Value = dataResponse.Dados[i].ID;
                dgvEntradas.Rows[i].Cells["EntradaFornecedor"].Value = dataResponse.Dados[i].Fornecedor;
                dgvEntradas.Rows[i].Cells["EntradaFuncionario"].Value = dataResponse.Dados[i].Funcionario;
                dgvEntradas.Rows[i].Cells["EntradaData"].Value = dataResponse.Dados[i].DataEntrada;
                dgvEntradas.Rows[i].Cells["EntradaValor"].Value = dataResponse.Dados[i].Valor;
            }
        }
    }
}
