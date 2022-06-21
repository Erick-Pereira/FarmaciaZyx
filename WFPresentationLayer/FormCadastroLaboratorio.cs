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
        public FormCadastroLaboratorio()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            LaboratorioBLL laboratorioBLL = new LaboratorioBLL();
            Laboratorio laboratorio = new Laboratorio(txtLaboratorio.Text);
            Response response = laboratorioBLL.Insert(laboratorio);
            MessageBox.Show(response.Message);
        }
    }
}
