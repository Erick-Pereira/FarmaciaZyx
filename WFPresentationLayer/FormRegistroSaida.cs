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
    public partial class FormRegistroSaida : Form
    {
        ClienteBLL clienteBLL = new ClienteBLL();
        ProdutoBLL produtoBLL = new ProdutoBLL();
        TipoUnidadeBLL TipoUnidadeBLL = new TipoUnidadeBLL();
        List<Produto> produtos = new List<Produto>();
        FormaPagamentoBLL formaPagamentoBLL = new FormaPagamentoBLL();

        public FormRegistroSaida()
        {
            InitializeComponent();
        }
        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Produto produto = (Produto)cmbProduto.SelectedItem;
            TipoUnidade tipoUnidade = TipoUnidadeBLL.GetById(produto.TipoUnidadeId).Item;
            if (tipoUnidade != null)
            {
                txtUnidade.Text = tipoUnidade.Nome;
                nudQtde.DecimalPlaces = tipoUnidade.CasasDecimais;
                nudQtde.Value = 1;
            }
        }

        private void FormRegistroSaida_Load(object sender, EventArgs e)
        {
            cmbCliente.DataSource = clienteBLL.GetAll().Dados;
            cmbCliente.DisplayMember = "Nome";
            cmbCliente.ValueMember = "ID";
            cmbProduto.DataSource = produtoBLL.GetAll().Dados;
            cmbProduto.DisplayMember = "Nome";
            cmbProduto.ValueMember = "ID";
            cmbFormaPamento.DataSource = formaPagamentoBLL.GetAll().Dados;
            cmbFormaPamento.DisplayMember = "Nome";
            cmbFormaPamento.ValueMember = "ID";
            if (cmbProduto.SelectedItem != null)
            {
                Produto produto = (Produto)cmbProduto.SelectedItem;
                TipoUnidade tipoUnidade = TipoUnidadeBLL.GetById(produto.TipoUnidadeId).Item;
                if (tipoUnidade != null)
                {
                    txtUnidade.Text = tipoUnidade.Nome;
                    nudQtde.DecimalPlaces = tipoUnidade.CasasDecimais;
                    nudQtde.Value = 1;
                }
            }
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            Produto produto = produtoBLL.GetByID(Convert.ToInt32(cmbProduto.SelectedValue)).Item;
            if (produto != null)
            {
                produto.QtdEstoque = (double)nudQtde.Value;
                produtos.Add(produto);
                dgvProdutosSaida.Rows.Add();
                double valor = 0;
                double descontoPorc = 0;
                double descontoRS = 0;
                for (int i = 0; i < produtos.Count; i++)
                {
                    dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaID"].Value = produtos[i].ID;
                    dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaNome"].Value = produtos[i].Nome;
                    dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaUn"].Value = TipoUnidadeBLL.GetById(produtos[i].TipoUnidadeId).Item.Nome;
                    dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaQtde"].Value = produtos[i].QtdEstoque;
                    dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaValor"].Value = produtos[i].Valor;
                    dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaTotal"].Value = (produtos[i].QtdEstoque * produtos[i].Valor);
                    valor += (produtos[i].QtdEstoque * produtos[i].Valor);
                }
                txtNumItens.Text = produtos.Count.ToString();
                txtTotalPago.Text = (valor - descontoRS).ToString();
                txtValor.Text = valor.ToString();
                txtDescontoPorc.Text = descontoPorc.ToString();
                txtDescontoRs.Text = descontoRS.ToString();
            }
        }

        private void btnRetirarProduto_Click(object sender, EventArgs e)
        {
            if (dgvProdutosSaida.CurrentCell == null)
            {
                MessageBox.Show("Não é possivel retirar um produto não selecionado");
                return;
            }
            int rowindex = dgvProdutosSaida.CurrentCell.RowIndex;
            int columnindex = dgvProdutosSaida.CurrentCell.ColumnIndex;
            produtos.RemoveAt(rowindex);
            dgvProdutosSaida.Rows.RemoveAt(rowindex);
            double valor = 0;
            double descontoPorc = 0;
            double descontoRS = 0;
            for (int i = 0; i < produtos.Count; i++)
            {
                dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaID"].Value = produtos[i].ID;
                dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaNome"].Value = produtos[i].Nome;
                dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaUn"].Value = TipoUnidadeBLL.GetById(produtos[i].TipoUnidadeId).Item.Nome;
                dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaQtde"].Value = produtos[i].QtdEstoque;
                dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaValor"].Value = produtos[i].Valor;
                dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaTotal"].Value = (produtos[i].QtdEstoque * produtos[i].Valor);
                valor += (produtos[i].QtdEstoque * produtos[i].Valor);
            }
            txtNumItens.Text = produtos.Count.ToString();
            txtTotalPago.Text = (valor - descontoRS).ToString();
            txtValor.Text = valor.ToString();
            txtDescontoPorc.Text = descontoPorc.ToString();
            txtDescontoRs.Text = descontoRS.ToString();
        }

        private void btnRegistrarVenda_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex != -1)
            {
                if (produtos.Count != 0)
                {
                    Saida saida = new Saida();
                    List<ProdutoSaida> produtoSaidas = new List<ProdutoSaida>();
                    double Valor = 0;
                    for (int i = 0; i < produtos.Count; i++)
                    {
                        ProdutoSaida produtoSaida = new ProdutoSaida();
                        produtoSaida.ProdutoId = produtos[i].ID;
                        produtoSaida.Quantidade = produtos[i].QtdEstoque;
                        produtoSaida.ValorUnitario = produtos[i].Valor;
                        produtoSaidas.Add(produtoSaida);
                        Valor += (produtos[i].QtdEstoque * produtos[i].Valor);
                    }
                    saida.produtosSaidas = produtoSaidas;
                    saida.DataSaida = dtpDataSaida.Value;
                    saida.Valor = Valor;
                    saida.Desconto = 0;
                    saida.FormaPagamento = Convert.ToInt32(cmbFormaPamento.SelectedValue);
                    saida.ValorTotal = Valor - saida.Desconto;
                    saida.ClienteId = Convert.ToInt32(cmbCliente.SelectedValue);
                    saida.FuncionarioId = FuncionarioLogin.id;
                    SaidaBLL saidaBLL = new SaidaBLL();
                    StringBuilder stringBuilder = new StringBuilder();
                    DataResponse<Produto> dataResponse = produtoBLL.CalculateInventory(produtos);
                    if (dataResponse.HasSuccess)
                    {
                        Response response = saidaBLL.Insert(saida);
                        if (response.HasSuccess)
                        {
                            for (int i = 0; i < produtos.Count; i++)
                            {
                                produtoBLL.UpdateValueAndInventory(dataResponse.Dados[i]);
                                Produto pro = dataResponse.Dados[i];
                                stringBuilder.AppendLine(pro.Nome + " || " + pro.QtdEstoque + " || " + pro.Valor);
                            }
                            dgvProdutosSaida.Rows.Clear();
                            produtos.Clear();
                        }
                        MessageBox.Show(response.Message);
                    }
                    else
                    {
                        MessageBox.Show(dataResponse.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Não é possivel fazer a venda se não há Produtos");
                }
            }
            else
            {
                MessageBox.Show("Não é possivel fazer a venda se não há Cliente");
            }
        }

        private void cmbProduto_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            nudQtde.Value = 1;
        }

        private void btnCadastroNovoCliente_Click(object sender, EventArgs e)
        {
            FormCadastroCliente formCadastroCliente = new FormCadastroCliente();
            formCadastroCliente.ShowDialog();
        }
    }
}

