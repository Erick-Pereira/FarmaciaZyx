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
    public partial class FormCadastroCliente : Form
    {
        ClienteBLL clienteBLL = new ClienteBLL();
        TipoClienteBLL tipoClienteBLL = new TipoClienteBLL();
        ClienteValidator clienteValidator = new ClienteValidator();
        GeneroBLL generoBLL = new GeneroBLL();
        DateTimeValidator dateTimeValidator = new DateTimeValidator();
        public FormCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Response response = new Response();
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string cpf = mtxtCpf.Text;
            string rg = txtRg.Text;
            cpf = cpf.Replace(",", ".");
            rg = rg.Replace(",", ".");
            int genero = (int)cmbGenero.SelectedValue;
            string telefone1 = mtxtTelefone1.Text;
            string telefone2 = mtxtTelefone2.Text;
            int tipoCliente = Convert.ToInt32(cmbTipoCliente.SelectedValue);
            string erro = dateTimeValidator.VerifyIfIsNull(mtxtDataNascimento.Text);
            DateTime dataNascimento = new DateTime();
            if (string.IsNullOrWhiteSpace(erro))
            {
                dataNascimento = Convert.ToDateTime(mtxtDataNascimento.Text);
            }
            Cliente cliente = new Cliente(nome, rg, cpf, telefone1, telefone2, email, tipoCliente, genero, dataNascimento);
            response = clienteValidator.Validate(cliente);
            response.Message += "\r\n" + erro;
            if (response.HasSuccess)
            {
                response = clienteBLL.Insert(cliente);
                if (response.HasSuccess)
                {
                    txtNome.Text = "";
                    txtEmail.Text = "";
                    mtxtCpf.Text = "";
                    txtRg.Text = "";
                    mtxtTelefone1.Text = "";
                    mtxtTelefone2.Text = "";
                    mtxtDataNascimento.Text = "";
                    cmbTipoCliente.SelectedIndex = 0;
                }
            }
            MessageBox.Show(response.Message);

        }

        private void FormCadastroCliente_Load(object sender, EventArgs e)
        {
            cmbTipoCliente.DataSource = tipoClienteBLL.GetAll().Dados;
            cmbTipoCliente.DisplayMember = "Nome";
            cmbTipoCliente.ValueMember = "ID";
            cmbGenero.DataSource = generoBLL.GetAll().Dados;
            cmbGenero.DisplayMember = "Nome";
            cmbGenero.ValueMember = "ID";
        }
    }
}
