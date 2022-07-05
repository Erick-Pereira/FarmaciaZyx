using BusinessLogicalLayer;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFPresentationLayer
{
    public partial class FormUpdateCliente : Form
    {
        ClienteBLL clienteBLL = new ClienteBLL();
        TipoClienteBLL tipoClienteBLL = new TipoClienteBLL();
        ClienteValidator clienteValidator = new ClienteValidator();
        GeneroBLL generoBLL = new GeneroBLL();
        DateTimeValidator dateTimeValidator = new DateTimeValidator();
        Cliente cliente = new Cliente();
        public FormUpdateCliente(Cliente _cliente)
        {
            cliente = _cliente;
            InitializeComponent();
        }
        private void FormUpdateCliente_Load(object sender, EventArgs e)
        {
            cmbTipoCliente.DataSource = tipoClienteBLL.GetAll().Dados;
            cmbTipoCliente.DisplayMember = "Nome";
            cmbTipoCliente.ValueMember = "ID";
            cmbGenero.DataSource = generoBLL.GetAll().Dados;
            cmbGenero.DisplayMember = "Nome";
            cmbGenero.ValueMember = "ID";
            txtNome.Text = cliente.Nome;
            mtxtCpf.Text = cliente.CPF;
            mtxtTelefone1.Text = cliente.Telefone1;
            mtxtTelefone2.Text = cliente.Telefone2;
            txtRg.Text = cliente.RG;
            txtEmail.Text = cliente.Email;
            cmbGenero.SelectedValue = cliente.GeneroId;
            cmbTipoCliente.SelectedValue = cliente.TipoClienteId;
            mtxtDataNascimento.Text = Convert.ToString(cliente.DataNascimento, new CultureInfo("pt-br"));
        }

        private void btnUpdateCliente_Click(object sender, EventArgs e)
        {
            Cliente update = new Cliente();
            update.ID = cliente.ID;
            update.Nome = txtNome.Text;
            update.CPF = mtxtCpf.Text;
            update.Telefone1 = mtxtTelefone1.Text;
            update.RG = txtRg.Text;
            update.Telefone2 = mtxtTelefone2.Text;
            string erro = dateTimeValidator.VerifyIfIsNull(mtxtDataNascimento.Text);
            DateTime dataNascimento = new DateTime();
            if (string.IsNullOrWhiteSpace(erro))
            {
                dataNascimento = Convert.ToDateTime(mtxtDataNascimento.Text,new CultureInfo("pt-br"));
                update.DataNascimento = dataNascimento;
                update.Email = txtEmail.Text;
                update.GeneroId = Convert.ToInt32(cmbGenero.SelectedValue);
                update.CPF = update.CPF.Replace(",", ".");
                update.RG = update.RG.Replace(",", ".");
                update.TipoClienteId = Convert.ToInt32(cmbTipoCliente.SelectedValue);
                Response response = clienteValidator.Validate(update);
                if (response.HasSuccess)
                {
                    response = clienteBLL.Update(update);

                }
                MessageBox.Show(response.Message);
            }
            else
            {
                MessageBox.Show(erro);
            }
        }
    }
}
