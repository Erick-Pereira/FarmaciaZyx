using BusinessLogicalLayer;
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
    public partial class FormUpdateSenha : Form
    {
        public FormUpdateSenha()
        {
            InitializeComponent();
        }
        FuncionarioBLL funcionarioBLL = new FuncionarioBLL();
        FuncionarioValidator funcionarioValidator = new FuncionarioValidator();
        private void btnUpdateSenha_Click(object sender, EventArgs e)
        {
            
        }
    }
}
