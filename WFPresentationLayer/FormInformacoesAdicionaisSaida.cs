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
    public partial class FormInformacoesAdicionaisSaida : Form
    {
        public FormInformacoesAdicionaisSaida()
        {
            InitializeComponent();
        }
        SaidaBLL saidaBLL = new SaidaBLL();
        private void FormInformacoesAdicionaisSaida_Load(object sender, EventArgs e)
        {
            SaidaView saida = (SaidaView)StaticItem.item;
            saida.produtosSaidas = saidaBLL.GetAllProdutosSaidaViewBySaidaID(saida.ID).Dados;
            txtCliente.Text = saida.Cliente;
            txtData.Text = saida.DataSaida.ToString();
            txtDesconto.Text = saida.Desconto.ToString();
            txtFormaPagamento.Text = saida.FormaPagamento;
            txtFuncionario.Text = saida.Funcionario;
            txtID.Text = saida.ID.ToString();
            txtValor.Text = saida.Valor.ToString();
            txtValorTotal.Text = saida.ValorTotal.ToString();

            for (int i = 0; i < saida.produtosSaidas.Count; i++)
            {
                dgvProdutosSaida.Rows.Add();
                dgvProdutosSaida.Rows[i].Cells["SaidaProduto"].Value = saida.produtosSaidas[i].Produto.Nome;
                dgvProdutosSaida.Rows[i].Cells["SaidaQuantidade"].Value = saida.produtosSaidas[i].Quantidade;
                dgvProdutosSaida.Rows[i].Cells["SaidaValorUnitario"].Value = saida.produtosSaidas[i].ValorUnitario;
            }
        }
    }
}
