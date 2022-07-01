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
        Cliente cliente = new Cliente();
        double descontoPorcentagem = 0;

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
            bool hasFound = false;
            Produto produto = produtoBLL.GetByID(Convert.ToInt32(cmbProduto.SelectedValue)).Item;
            if (produto != null)
            {
                produto.QtdEstoque = (double)nudQtde.Value;
                for (int i = 0; i < produtos.Count; i++)
                {
                    if (produto.ID == produtos[i].ID)
                    {
                        hasFound = true;
                        produtos[i].QtdEstoque += produto.QtdEstoque;
                        break;
                    }
                }
                if (!hasFound)
                {
                    produtos.Add(produto);
                    dgvProdutosSaida.Rows.Add();
                }
                double valor = 0;
                double descontoPorc = descontoPorcentagem;
                for (int i = 0; i < produtos.Count; i++)
                {
                    valor += Math.Round((produtos[i].QtdEstoque * produtos[i].Valor),2);
                    dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaID"].Value = produtos[i].ID;
                    dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaNome"].Value = produtos[i].Nome;
                    dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaUn"].Value = TipoUnidadeBLL.GetById(produtos[i].TipoUnidadeId).Item.Nome;
                    dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaQtde"].Value = produtos[i].QtdEstoque;
                    dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaValor"].Value = produtos[i].Valor;
                    dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaTotal"].Value = (produtos[i].QtdEstoque * produtos[i].Valor);
                }
                double descontoRS = (valor * descontoPorc) / 100;
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
            produtos.RemoveAt(rowindex);
            dgvProdutosSaida.Rows.RemoveAt(rowindex);
            double valor = 0;
            double descontoPorc = descontoPorcentagem;
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
            double descontoRS = (valor * descontoPorc) / 100;
            txtNumItens.Text = produtos.Count.ToString();
            txtTotalPago.Text = (valor - descontoRS).ToString();
            txtValor.Text = valor.ToString();
            txtDescontoPorc.Text = descontoPorc.ToString();
            txtDescontoRs.Text = descontoRS.ToString();
        }

        private void btnRegistrarVenda_Click(object sender, EventArgs e)
        {
            if (cliente != null && cliente.ID !=0)
            {
            if (produtos.Count != 0)
            {
                Saida saida = new Saida();
                List<ProdutoSaida> produtoSaidas = new List<ProdutoSaida>();
                double valor = 0;
                for (int i = 0; i < produtos.Count; i++)
                {
                    ProdutoSaida produtoSaida = new ProdutoSaida();
                    produtoSaida.ProdutoId = produtos[i].ID;
                    produtoSaida.Quantidade = produtos[i].QtdEstoque;
                    produtoSaida.ValorUnitario = produtos[i].Valor;
                    produtoSaidas.Add(produtoSaida);
                    valor += Math.Round((produtos[i].QtdEstoque * produtos[i].Valor),2);
                }
                saida.produtosSaidas = produtoSaidas;
                saida.DataSaida = dtpDataSaida.Value;
                saida.Valor = valor;
                saida.Desconto = (valor * descontoPorcentagem) / 100;
                saida.FormaPagamento = Convert.ToInt32(cmbFormaPamento.SelectedValue);
                saida.ValorTotal = valor - saida.Desconto;
                saida.ClienteId = cliente.ID;
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
                        }
                        if(descontoPorcentagem>0 && cliente.TipoClienteId == 2)
                        {
                            clienteBLL.WithdrawPontos(cliente);
                        }
                        if (cliente.TipoClienteId == 2)
                        {
                            clienteBLL.GivePontos(cliente, valor - saida.Desconto);
                        }
                        dgvProdutosSaida.Rows.Clear();
                        produtos.Clear();
                            cliente = null;
                            txtNumItens.Text = "";
                            txtTotalPago.Text = "";
                            txtValor.Text = "";
                            txtDescontoPorc.Text = "";
                            txtDescontoRs.Text = "";
                            txtCliente.Text = "";
                            mtxtCpf.Text = "";
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
                MessageBox.Show("Não é possivel fazer uma venda se não há Cliente");
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

        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtxtCpf.Text))
            {
                string message = "Você realmente deseja adicionar o Cliente Padrão?";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    SingleResponse<Cliente> singleResponse = clienteBLL.GetByID(1);
                    cliente = singleResponse.Item;
                    txtCliente.Text = cliente.Nome;
                }
            }
            else
            {
                SingleResponse<Cliente> singleResponse = clienteBLL.GetByCPF(mtxtCpf.Text);
                if (!singleResponse.HasSuccess)
                {
                    string message = $"{singleResponse.Message} ,Você adicionar o Cliente Padrão?";
                    string title = "Close Window";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        singleResponse = clienteBLL.GetByID(1);
                        cliente = singleResponse.Item;
                        txtCliente.Text = cliente.Nome;
                    }
                }
                else
                {
                    string message = $"Você realmente adicionar o Cliente {singleResponse.Item.Nome}?";
                    string title = "Close Window";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        cliente = singleResponse.Item;
                        descontoPorcentagem = clienteBLL.VerifyIfHasDesconto(cliente);
                        txtCliente.Text = cliente.Nome;
                        double valor = 0;
                        double descontoPorc = descontoPorcentagem;
                        for (int i = 0; i < produtos.Count; i++)
                        {
                            valor += Math.Round((produtos[i].QtdEstoque * produtos[i].Valor), 2);
                            dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaID"].Value = produtos[i].ID;
                            dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaNome"].Value = produtos[i].Nome;
                            dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaUn"].Value = TipoUnidadeBLL.GetById(produtos[i].TipoUnidadeId).Item.Nome;
                            dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaQtde"].Value = produtos[i].QtdEstoque;
                            dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaValor"].Value = produtos[i].Valor;
                            dgvProdutosSaida.Rows[i].Cells["ProdutosSaidaTotal"].Value = (produtos[i].QtdEstoque * produtos[i].Valor);
                        }
                        double descontoRS = (valor * descontoPorc) / 100;
                        txtNumItens.Text = produtos.Count.ToString();
                        txtTotalPago.Text = (valor - descontoRS).ToString();
                        txtValor.Text = valor.ToString();
                        txtDescontoPorc.Text = descontoPorc.ToString();
                        txtDescontoRs.Text = descontoRS.ToString();
                    }
                }
            }

        }
    }
}

