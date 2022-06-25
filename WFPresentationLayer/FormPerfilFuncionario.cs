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
    public partial class FormPerfilFuncionario : Form
    {
        public FormPerfilFuncionario()
        {
            InitializeComponent();
        }
        FuncionarioBLL funcionarioBLL = new FuncionarioBLL();
        EstadoBLL EstadoBLL = new EstadoBLL();
        CidadeBLL CidadeBLL = new CidadeBLL();
        BairroBLL BairroBLL = new BairroBLL();
        EnderecoBLL enderecoBLL = new EnderecoBLL();
        TipoFuncionarioBLL tipoFuncionarioBLL = new TipoFuncionarioBLL();
        private void FormPerfilFuncionario_Load(object sender, EventArgs e)
        {
            Funcionario funcionario = funcionarioBLL.GetByID(FuncionarioLogin.id).Item;
            Endereco endereco = enderecoBLL.GetByID(funcionario.EnderecoId).Item;
            Bairro bairro = BairroBLL.GetByID(endereco.BairroID).Item;
            Cidade cidade = CidadeBLL.GetByID(bairro.CidadeId).Item;
            Estado estado = EstadoBLL.GetByID(cidade.EstadoId).Item;
            lblEstado.Text = estado.NomeEstado;
            lblCidade.Text = cidade.NomeCidade;
            lblBairro.Text = bairro.NomeBairro;
            lblRua.Text = endereco.Rua;
            lblNumero.Text = endereco.NumeroCasa;
            lblEmail.Text = funcionario.Email;
            lblNome.Text = funcionario.Nome;
            lblPermissao.Text = tipoFuncionarioBLL.GetByID(funcionario.TipoFuncionarioId).Item.Nome;
        }
    }
}