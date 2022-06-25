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
    public partial class FormCadastroLaboratorio : Form
    {
        LaboratorioValidator laboratorioValidator = new LaboratorioValidator();
        LaboratorioBLL laboratorioBLL = new LaboratorioBLL();

        public FormCadastroLaboratorio()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtLaboratorio.Text;
            string cnpj = mtxtCNPJ.Text;
            cnpj = cnpj.Replace(",", ".");
            Laboratorio laboratorio = new Laboratorio(nome, cnpj);
            Response response = laboratorioValidator.Validate(laboratorio);
            if (response.HasSuccess)
            {
                response = laboratorioBLL.Insert(laboratorio);
                if (response.HasSuccess)
                {
                    txtLaboratorio.Text = "";
                    mtxtCNPJ.Text = "";
                }
            }
                MessageBox.Show(response.Message);
        }
    }
}
