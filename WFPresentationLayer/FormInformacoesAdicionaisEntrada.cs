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
        EntradaView entrada= new EntradaView();
        public FormInformacoesAdicionaisEntrada(EntradaView _entradaView)
        {
            entrada = _entradaView;
            InitializeComponent();
        }
        EntradaBLL entradaBLL = new EntradaBLL();
        private void FormInformacoesAdicionaisEntrada_Load(object sender, EventArgs e)
        {
            entrada.produtosEntradas = entradaBLL.GetAllByEntraID(entrada.ID).Dados;
            txtFornecedor.Text = entrada.Fornecedor;
            txtData.Text = entrada.DataEntrada.ToString();
            txtFuncionario.Text = entrada.Funcionario;
            txtID.Text = entrada.ID.ToString();
            txtValorTotal.Text = entrada.Valor.ToString();
            for (int i = 0; i < entrada.produtosEntradas.Count; i++)
            {
                dgvProdutosSaida.Rows.Add();
                dgvProdutosSaida.Rows[i].Cells["EntradaProduto"].Value = entrada.produtosEntradas[i].Produto.Nome;
                dgvProdutosSaida.Rows[i].Cells["EntradaQuantidade"].Value = entrada.produtosEntradas[i].Quantidade;
                dgvProdutosSaida.Rows[i].Cells["EntradaValorUnitario"].Value = entrada.produtosEntradas[i].ValorUnitario;
            }

        }
    }
}
