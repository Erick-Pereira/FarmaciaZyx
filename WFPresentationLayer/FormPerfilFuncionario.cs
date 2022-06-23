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
        TipoFuncionarioBLL tipoFuncionarioBLL = new TipoFuncionarioBLL();
        private void FormPerfilFuncionario_Load(object sender, EventArgs e)
        {
            Funcionario funcionario = funcionarioBLL.GetByID(FuncionarioLogin.id).Item;
            
            lblEmail.Text = funcionario.Email;
            lblNome.Text = funcionario.Nome;
            lblPermissao.Text = tipoFuncionarioBLL.GetByID(funcionario.TipoFuncionarioId).Item.Nome;
        }
    }
}
