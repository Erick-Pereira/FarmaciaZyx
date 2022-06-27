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
    public partial class FormInformacoesAdicionaisEntrada : Form
    {
        public FormInformacoesAdicionaisEntrada()
        {
            InitializeComponent();
        }
        ProdutoBLL ProdutoBLL = new ProdutoBLL();
        FornecedorBLL fornecedorBLL = new FornecedorBLL();
        FuncionarioBLL funcionarioBLL = new FuncionarioBLL();
        private void FormInformacoesAdicionaisEntrada_Load(object sender, EventArgs e)
        {

            Entrada entrada = (Entrada)StaticItem.item;
            txtFornecedor.Text = fornecedorBLL.GetByID(entrada.FornecedorID).Item.RazaoSocial;
            txtData.Text = entrada.DataEntrada.ToString();
            txtFuncionario.Text = funcionarioBLL.GetByID(entrada.FuncionarioId).Item.Nome;
            txtID.Text = entrada.ID.ToString();
            txtValorTotal.Text = entrada.Valor.ToString();

            for (int i = 0; i < entrada.produtosEntradas.Count; i++)
            {
                SingleResponse<Produto> singleResponseProduto = ProdutoBLL.GetByID(entrada.produtosEntradas[i].ProdutoId);
                dgvProdutosSaida.Rows.Add();
                dgvProdutosSaida.Rows[i].Cells["SaidaProduto"].Value = singleResponseProduto.Item.Nome;
                dgvProdutosSaida.Rows[i].Cells["SaidaQuantidade"].Value = entrada.produtosEntradas[i].Quantidade;
                dgvProdutosSaida.Rows[i].Cells["SaidaValorUnitario"].Value = entrada.produtosEntradas[i].ValorUnitario;
            }

        }
    }
}
