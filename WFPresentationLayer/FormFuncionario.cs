using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WfPresentationLayer;

namespace WFPresentationLayer
{
    public partial class FormFuncionario : Form
    {
        private Form currentChildForm;
        public FormFuncionario()
        {
            InitializeComponent();
            if (FuncionarioLogin.tipoFuncionarioId != 1)
            {
                btnCadastroFuncionario.Enabled = false;
                btnCadastroFuncionario.Visible = false;
            }
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            this.Close();
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnPerfilFuncionario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPerfilFuncionario());
        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormClientes());
        }

        private void btnRegistroEntrada_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRegistroEntrada());
        }

        private void btnRegistroSaida_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRegistroSaida());
        }

        private void btnCadastroFornecedor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormFornecedores());
        }

        private void btnCadastroFuncionario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormFuncionarios());
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormProdutos());
        }

        private void btnLaboratorios_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLaboratorios());
        }

        private void FormFuncionario_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FormPerfilFuncionario());
        }
    }
}


