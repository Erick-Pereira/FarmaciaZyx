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
        ProdutoBLL ProdutoBLL = new ProdutoBLL();
        ClienteBLL clienteBLL = new ClienteBLL();
        FormaPagamentoBLL formaPagamentoBLL = new FormaPagamentoBLL();
        FuncionarioBLL funcionarioBLL = new FuncionarioBLL();
        SaidaBLL saidaBLL = new SaidaBLL();
        private void FormInformacoesAdicionaisEntrada_Load(object sender, EventArgs e)
        {
            Saida saida = (Saida)StaticItem.item;
            txtCliente.Text = clienteBLL.GetByID(saida.ClienteId).Item.Nome;
            txtData.Text = saida.DataSaida.ToString();
            txtDesconto.Text = saida.Desconto.ToString();
            txtFormaPagamento.Text = formaPagamentoBLL.GetById(saida.FormaPagamento).Item.Nome;
            txtFuncionario.Text = funcionarioBLL.GetByID(saida.FuncionarioId).Item.Nome;
            txtID.Text = saida.ID.ToString();
            txtValor.Text = saida.Valor.ToString();
            txtValorTotal.Text = saida.ValorTotal.ToString();

            for (int i = 0; i < saida.produtosSaidas.Count; i++)
            {
                SingleResponse<Produto> singleResponseProduto = ProdutoBLL.GetByID(saida.produtosSaidas[i].ProdutoId);
                dgvProdutosSaida.Rows.Add();
                dgvProdutosSaida.Rows[i].Cells["SaidaProduto"].Value = singleResponseProduto.Item.Nome;
                dgvProdutosSaida.Rows[i].Cells["SaidaQuantidade"].Value = saida.produtosSaidas[i].Quantidade;
                dgvProdutosSaida.Rows[i].Cells["SaidaValorUnitario"].Value = saida.produtosSaidas[i].ValorUnitario;
            }

        }
    }
}
