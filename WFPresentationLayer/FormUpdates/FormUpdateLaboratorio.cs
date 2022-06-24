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
    public partial class FormUpdateLaboratorio : Form
    {
        public FormUpdateLaboratorio()
        {
            InitializeComponent();
        }

        Laboratorio laboratorio = (Laboratorio)StaticItem.item;

        private void btnUpdateLaboratorio_Click(object sender, EventArgs e)
        {
            Laboratorio update = new Laboratorio();
            update.ID = laboratorio.ID;
            update.Nome = txtLaboratorio.Text;
            LaboratorioValidator laboratorioValidator = new LaboratorioValidator();
            Response response = laboratorioValidator.Validate(update);
            if (response.HasSuccess)
            {
                LaboratorioBLL laboratorioBLL = new LaboratorioBLL();
                Response response1 = laboratorioBLL.Update(update);
                MessageBox.Show(response1.Message);
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void FormUpdateLaboratorio_Load(object sender, EventArgs e)
        {
            txtLaboratorio.Text = laboratorio.Nome;
            mtxtCNPJ.Text = laboratorio.CNPJ;
        }
    }
}
