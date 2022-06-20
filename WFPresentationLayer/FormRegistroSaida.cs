using BusinessLogicalLayer;
using Entities;
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
        ProdutorBLL produtorBLL = new ProdutorBLL();
        TipoUnidadeBLL TipoUnidadeBLL = new TipoUnidadeBLL();    

        public FormRegistroSaida()
        {
            InitializeComponent();
            cmbCliente.DataSource = clienteBLL.GetAll().Dados;
            cmbCliente.DisplayMember = "RazaoSocial";
            cmbCliente.ValueMember = "ID";
            cmbProduto.DataSource = produtorBLL.GetAll().Dados;
            cmbProduto.DisplayMember = "Nome";
            cmbProduto.ValueMember = "ID";
            //cmbUnidade.DataSource = TipoUnidadeBLL.GetAll().Dados;
            //cmbUnidade.DisplayMember = "Nome";
            //cmbUnidade.ValueMember = "ID";
        }
        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Produto> displayedValues = new List<Produto>();
            foreach (Produto ci in cmbProduto.Items)
            displayedValues.Add(ci);
            txtUnidade.Text = TipoUnidadeBLL.GetById(displayedValues[cmbProduto.SelectedIndex].TipoUnidadeId).Item.Nome;
            if (txtUnidade.Text == "UN")
            {
                nudQtde.DecimalPlaces = 0;
            }
            if (txtUnidade.Text == "KG")
            {
                nudQtde.DecimalPlaces = 2;
            }
        }

        private void FormRegistroSaida_Load(object sender, EventArgs e)
        {
            List<Produto> displayedValues = new List<Produto>();
            foreach (Produto ci in cmbProduto.Items)
                displayedValues.Add(ci);
            txtUnidade.Text = TipoUnidadeBLL.GetById(displayedValues[cmbProduto.SelectedIndex].TipoUnidadeId).Item.Nome;
            if (txtUnidade.Text == "UN")
            {
                nudQtde.DecimalPlaces = 0;
            }
            if (txtUnidade.Text == "KG")
            {
                nudQtde.DecimalPlaces = 2;
            }
        }
    }
}

