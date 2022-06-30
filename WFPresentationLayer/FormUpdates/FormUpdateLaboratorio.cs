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
        LaboratorioValidator laboratorioValidator = new LaboratorioValidator();
        LaboratorioBLL laboratorioBLL = new LaboratorioBLL();



        private void btnUpdateLaboratorio_Click(object sender, EventArgs e)
        {
            Laboratorio update = new Laboratorio();
            update.ID = laboratorio.ID;
            update.Nome = txtLaboratorio.Text;
            update.CNPJ = mtxtCNPJ.Text;
            update.CNPJ = update.CNPJ.Replace(",", ".");
            Response response = laboratorioValidator.Validate(update);
            if (response.HasSuccess)
            {
                response = laboratorioBLL.Update(update);
       
            }
                MessageBox.Show(response.Message);
        }

        private void FormUpdateLaboratorio_Load(object sender, EventArgs e)
        {
            txtLaboratorio.Text = laboratorio.Nome;
            mtxtCNPJ.Text = laboratorio.CNPJ;
        }
    }
}