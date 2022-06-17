using BusinessLogicalLayer;
using Shared;

namespace WfPresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            //LoginValidator validator = new LoginValidator();
            //Response response = validator.Validate(login);
            //MessageBox.Show(Response.Message);
        }
    }
}