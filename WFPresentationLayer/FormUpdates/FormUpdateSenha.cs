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
    public partial class FormUpdateSenha : Form
    {
        FuncionarioBLL funcionarioBLL = new FuncionarioBLL();
        FuncionarioValidator funcionarioValidator = new FuncionarioValidator();
        StringValidator stringValidator = new StringValidator();
        Funcionario funcionario = new Funcionario();
        public FormUpdateSenha(Funcionario _funcionario)
        {
            funcionario = _funcionario;
            InitializeComponent();
        }


        private void btnUpdateSenha_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            Hash hash = new Hash();
            if (string.IsNullOrEmpty(txtSenhaAntiga.Text))
            { stringBuilder.AppendLine("Senha Antiga deve ser informada"); }
            if (string.IsNullOrEmpty(txtNovaSenha.Text))
            { stringBuilder.AppendLine("Nova Senha deve ser informada"); }
            if (string.IsNullOrEmpty(txtConfirmarNovaSenha.Text))
            { stringBuilder.AppendLine("Senha para Confirmação deve ser informada"); }
            if (string.IsNullOrWhiteSpace(stringBuilder.ToString()))
            {
                string senha = funcionarioBLL.GetSenhaByID(funcionario.ID).Item.Senha;
                string senhaAntiga = hash.ComputeSha256Hash(txtSenhaAntiga.Text);

                if (senhaAntiga == senha)
                {
                    if (hash.ComputeSha256Hash(txtNovaSenha.Text) != senha)
                    {
                        stringBuilder.AppendLine(stringValidator.ValidateIfSenha1EqualsToSenha2(txtNovaSenha.Text, txtConfirmarNovaSenha.Text));
                        if (string.IsNullOrWhiteSpace(stringBuilder.ToString()))
                        {
                            stringBuilder.AppendLine(stringValidator.ValidateSenha(txtNovaSenha.Text));
                            if (string.IsNullOrWhiteSpace(stringBuilder.ToString()))
                            {
                                funcionario.Senha = hash.ComputeSha256Hash(txtNovaSenha.Text);
                                Response response = funcionarioBLL.UpdateSenha(funcionario);
                                MessageBox.Show(response.Message);
                            }
                            else
                            {
                                MessageBox.Show(stringBuilder.ToString());
                            }
                        }
                        else
                        {
                            MessageBox.Show(stringBuilder.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Senha nova não pode ser igual a antiga");
                    }
                }
                else
                {
                    MessageBox.Show("Para redefinir sua senha a senha antiga deve ser informada");
                }
            }
            else
            {
                MessageBox.Show(stringBuilder.ToString());
            }

            txtSenhaAntiga.Text = "";
            txtNovaSenha.Text = "";
            txtConfirmarNovaSenha.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
