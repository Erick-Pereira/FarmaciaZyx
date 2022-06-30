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
    public partial class FormRegistroEntrada : Form
    {
        FornecedorBLL fornecedorBLL = new FornecedorBLL();
        ProdutoBLL produtoBLL = new ProdutoBLL();
        TipoUnidadeBLL TipoUnidadeBLL = new TipoUnidadeBLL();
        List<Produto> produtos = new List<Produto>();
        List<Produto> produtosWithValorAndEstoque = new List<Produto>();

        public FormRegistroEntrada()
        {
            InitializeComponent();
        }

        private void btnCadastrarNovoFornecedor_Click(object sender, EventArgs e)
        {
            FormCadastroFornecedor formCadastroFornecedor = new FormCadastroFornecedor();
            formCadastroFornecedor.ShowDialog();
            cmbFornecedor.DataSource = fornecedorBLL.GetAll().Dados;
            cmbFornecedor.DisplayMember = "RazaoSocial";
            cmbFornecedor.ValueMember = "ID";
        }

        private void btnCadastroNovoProduto_Click(object sender, EventArgs e)
        {
            FormCadastroProduto formCadastroProduto = new FormCadastroProduto();
            formCadastroProduto.ShowDialog();
            cmbProduto.DataSource = produtoBLL.GetAll().Dados;
            cmbProduto.DisplayMember = "Nome";
            cmbProduto.ValueMember = "ID";
        }


        private void FormRegistroEntrada_Load(object sender, EventArgs e)
        {
            cmbFornecedor.DataSource = fornecedorBLL.GetAll().Dados;
            cmbFornecedor.DisplayMember = "RazaoSocial";
            cmbFornecedor.ValueMember = "ID";
            cmbProduto.DataSource = produtoBLL.GetAll().Dados;
            cmbProduto.DisplayMember = "Nome";
            cmbProduto.ValueMember = "ID";
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

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Produto produto = (Produto)cmbProduto.SelectedItem;
            TipoUnidade tipoUnidade = TipoUnidadeBLL.GetById(produto.TipoUnidadeId).Item;
            if (tipoUnidade != null)
            {
                txtUnidade.Text = tipoUnidade.Nome;
                nudQtde.DecimalPlaces = tipoUnidade.CasasDecimais;
                nudQtde.Value = 1;
                nudValorUnitario.Value = 1;
            }
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            Produto produto = produtoBLL.GetByID(Convert.ToInt32(cmbProduto.SelectedValue)).Item;
            bool hasFound = false;
            if (produto != null)
            {
                produto.QtdEstoque = (double)nudQtde.Value;
                produto.Valor = (double)nudValorUnitario.Value;
                for (int i = 0; i < produtos.Count; i++)
                {
                    if(produto.ID == produtos[i].ID)
                    {
                        hasFound = true;
                        produtos[i].QtdEstoque += produto.QtdEstoque;
                        if(produtos[i].Valor != produto.Valor)
                        {
                            produtos[i].Valor = produtoBLL.CalculateNewValueWithProdutos(produtos[i], produto);
                        }
                        break;
                    }
                }
                if(!hasFound)
                { produtos.Add(produto);
               
                dgvProdutosEntrada.Rows.Add();
                }
                double valor = 0;
                for (int i = 0; i < produtos.Count; i++)
                {
                    valor += Math.Round((produtos[i].QtdEstoque * produtos[i].Valor), 2);
                    dgvProdutosEntrada.Rows[i].Cells["ProdutosEntradaID"].Value = produtos[i].ID;
                    dgvProdutosEntrada.Rows[i].Cells["ProdutosEntradaNome"].Value = produtos[i].Nome;
                    dgvProdutosEntrada.Rows[i].Cells["ProdutosEntradaUn"].Value = TipoUnidadeBLL.GetById(produtos[i].TipoUnidadeId).Item.Nome;
                    dgvProdutosEntrada.Rows[i].Cells["ProdutosEntradaQtde"].Value = produtos[i].QtdEstoque;
                    dgvProdutosEntrada.Rows[i].Cells["ProdutosEntradaValor"].Value = produtos[i].Valor;
                    dgvProdutosEntrada.Rows[i].Cells["ProdutosEntradaTotal"].Value = (produtos[i].QtdEstoque * produtos[i].Valor);
                }
                txtNumItens.Text = produtos.Count.ToString();
                txtTotalPago.Text = (valor).ToString();
            }
        }

        private void btnRetirarProduto_Click(object sender, EventArgs e)
        {
            if (dgvProdutosEntrada.CurrentCell == null)
            {
                MessageBox.Show("Não é possivel retirar um produto não selecionado");
                return;
            }
            int rowindex = dgvProdutosEntrada.CurrentCell.RowIndex;
            produtos.RemoveAt(rowindex);
            double valor = 0;
            dgvProdutosEntrada.Rows.RemoveAt(rowindex);
            for (int i = 0; i < produtos.Count; i++)
            {
                dgvProdutosEntrada.Rows[i].Cells["ProdutosEntradaID"].Value = produtos[i].ID;
                dgvProdutosEntrada.Rows[i].Cells["ProdutosEntradaNome"].Value = produtos[i].Nome;
                dgvProdutosEntrada.Rows[i].Cells["ProdutosEntradaUn"].Value = TipoUnidadeBLL.GetById(produtos[i].TipoUnidadeId).Item.Nome;
                dgvProdutosEntrada.Rows[i].Cells["ProdutosEntradaQtde"].Value = produtos[i].QtdEstoque;
                dgvProdutosEntrada.Rows[i].Cells["ProdutosEntradaValor"].Value = produtos[i].Valor;
                dgvProdutosEntrada.Rows[i].Cells["ProdutosEntradaTotal"].Value = (produtos[i].QtdEstoque * produtos[i].Valor);
                valor += (produtos[i].QtdEstoque * produtos[i].Valor);
            }
            txtNumItens.Text = produtos.Count.ToString();
            txtTotalPago.Text = (valor).ToString();
        }

        private void btnRegistrarEntrada_Click(object sender, EventArgs e)
        {
            if (cmbFornecedor.SelectedIndex != -1)
            {
                if (produtos.Count != 0)
                {
                    Entrada entrada = new Entrada();
                    List<ProdutosEntrada> produtosentradas = new List<ProdutosEntrada>();
                    
                    double valor = 0;
                    for (int i = 0; i < produtos.Count; i++)
                    {
                        ProdutosEntrada produtosentrada = new ProdutosEntrada();
                        produtosentrada.ProdutoId = produtos[i].ID;
                        produtosentrada.Quantidade = produtos[i].QtdEstoque;
                        produtosentrada.ValorUnitario = produtos[i].Valor;
                        produtosentradas.Add(produtosentrada);
                        valor += (produtos[i].QtdEstoque * produtos[i].Valor);
                    }
                    entrada.produtosEntradas = produtosentradas;
                    entrada.DataEntrada = dtpDataEntrada.Value;
                    entrada.Valor = valor;
                    entrada.FornecedorID = Convert.ToInt32(cmbFornecedor.SelectedValue);
                    entrada.FuncionarioId = FuncionarioLogin.id;
                    EntradaBLL entradabll = new EntradaBLL();
                    StringBuilder stringbuilder = new StringBuilder();
                    for (int i = 0; i < produtos.Count; i++)
                    {
                        produtosWithValorAndEstoque.Add(produtoBLL.GetByID(produtos[i].ID).Item);
                        produtosWithValorAndEstoque[i].QtdEstoque += produtos[i].QtdEstoque;
                    }
                    DataResponse<Produto> dataresponse = produtoBLL.CalculateNewValue(produtos);
                    Response response = entradabll.Insert(entrada);
                    if (response.HasSuccess)
                    {
                        for (int i = 0; i < dataresponse.Dados.Count; i++)
                        {
                            produtosWithValorAndEstoque[i].Valor = Math.Round(dataresponse.Dados[i].Valor, 2);
                            produtoBLL.UpdateValueAndInventory(produtosWithValorAndEstoque[i]);
                        }
                    }
                    MessageBox.Show(response.Message);
                    dgvProdutosEntrada.Rows.Clear();
                    produtos.Clear();
                }
                else
                {
                    MessageBox.Show("não é possivel registrar uma entrada se não há Produtos");
                }
            }
            else
            {
                MessageBox.Show("não é possivel registrar uma entrada se não há Fornecedor");
            }
        }
    }
}