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
    public partial class FormHistoricoSaida : Form
    {
        public FormHistoricoSaida()
        {
            InitializeComponent();
        }
        DataResponse<SaidaView> dataResponse = new DataResponse<SaidaView>();
        SaidaBLL saidaBLL = new SaidaBLL();
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
        private void FormHistoricoSaida_Load(object sender, EventArgs e)
        {
            dataResponse = saidaBLL.GetAll();
            for (int i = 0; i < dataResponse.Dados.Count; i++)
            {
                dgvSaidas.Rows.Add();
                dgvSaidas.Rows[i].Cells["SaidaID"].Value = dataResponse.Dados[i].ID;
                dgvSaidas.Rows[i].Cells["SaidaCliente"].Value = dataResponse.Dados[i].Cliente;
                dgvSaidas.Rows[i].Cells["SaidaFuncionario"].Value = dataResponse.Dados[i].Funcionario;
                dgvSaidas.Rows[i].Cells["SaidaData"].Value = dataResponse.Dados[i].DataSaida;
                dgvSaidas.Rows[i].Cells["SaidaValor"].Value = dataResponse.Dados[i].Valor;
                dgvSaidas.Rows[i].Cells["SaidaFormaPagamento"].Value = dataResponse.Dados[i].FormaPagamento;
                dgvSaidas.Rows[i].Cells["SaidaValorTotal"].Value = dataResponse.Dados[i].ValorTotal;
                dgvSaidas.Rows[i].Cells["SaidaDesconto"].Value = dataResponse.Dados[i].Desconto;
            }
        }

        private void btnTabelaSaida_Click(object sender, EventArgs e)
        {
            btnInformacoesSaida.Enabled = true;
            btnInformacoesSaida.Visible = true;
            if (currentChildForm != null)
            {
                panelDesktopEntradas.SendToBack();
                currentChildForm.Close();
                dgvSaidas.Rows.Clear();
                dataResponse = saidaBLL.GetAll();
                for (int i = 0; i < dataResponse.Dados.Count; i++)
                {
                    dgvSaidas.Rows.Add();
                    dgvSaidas.Rows[i].Cells["SaidaID"].Value = dataResponse.Dados[i].ID;
                    dgvSaidas.Rows[i].Cells["SaidaCliente"].Value = dataResponse.Dados[i].Cliente;
                    dgvSaidas.Rows[i].Cells["SaidaFuncionario"].Value = dataResponse.Dados[i].Funcionario;
                    dgvSaidas.Rows[i].Cells["SaidaData"].Value = dataResponse.Dados[i].DataSaida;
                    dgvSaidas.Rows[i].Cells["SaidaValor"].Value = dataResponse.Dados[i].Valor;
                    dgvSaidas.Rows[i].Cells["SaidaFormaPagamento"].Value = dataResponse.Dados[i].FormaPagamento;
                    dgvSaidas.Rows[i].Cells["SaidaValorTotal"].Value = dataResponse.Dados[i].ValorTotal;
                    dgvSaidas.Rows[i].Cells["SaidaDesconto"].Value = dataResponse.Dados[i].Desconto;
                }
            }
        }

        private void btnInformacoesSaida_Click(object sender, EventArgs e)
        {
            if (dgvSaidas.CurrentCell == null)
            {
                MessageBox.Show("Não é possivel ver as informações adicionais de uma Saida não selecionada");
                return;
            }
            string message = "Você realmente  ver as informações adicionais desta Saida?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int rowindex = dgvSaidas.CurrentCell.RowIndex;
                int index = Convert.ToInt32(dgvSaidas.Rows[rowindex].Cells[0].Value);
                btnInformacoesSaida.Enabled = false;
                btnInformacoesSaida.Visible = false;
                StaticItem.item = saidaBLL.GetByID(index).Item;
                panelDesktopEntradas.BringToFront();
                OpenChildForm(new FormInformacoesAdicionaisSaida());
            }
        }
    }
}
