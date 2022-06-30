﻿using BusinessLogicalLayer;
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
        public FormUpdateSenha()
        {
            InitializeComponent();
        }
        FuncionarioBLL funcionarioBLL = new FuncionarioBLL();
        FuncionarioValidator funcionarioValidator = new FuncionarioValidator();
        StringValidator stringValidator = new StringValidator();

        private void btnUpdateSenha_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            Funcionario funcionario = (Funcionario)StaticItem.item;

            if (string.IsNullOrEmpty(txtSenhaAntiga.Text))
            { stringBuilder.AppendLine("Senha Antiga deve ser informada"); }
            if (string.IsNullOrEmpty(txtNovaSenha.Text))
            { stringBuilder.AppendLine("Nova Senha deve ser informada"); }
            if (string.IsNullOrEmpty(txtConfirmarNovaSenha.Text))
            { stringBuilder.AppendLine("Senha para Confirmação deve ser informada"); }
            if (string.IsNullOrWhiteSpace(stringBuilder.ToString()))
            {
                string senha = funcionarioBLL.GetSenhaByID(funcionario.ID).Item.Senha;
                if (txtSenhaAntiga.Text == senha)
                {
                    if (txtNovaSenha.Text != senha)
                    {
                        stringBuilder.AppendLine(stringValidator.ValidateIfSenha1EqualsToSenha2(txtNovaSenha.Text, txtConfirmarNovaSenha.Text));
                        if (string.IsNullOrWhiteSpace(stringBuilder.ToString()))
                        {
                            stringBuilder.AppendLine(stringValidator.ValidateSenha(txtNovaSenha.Text));
                            if (string.IsNullOrWhiteSpace(stringBuilder.ToString()))
                            {
                                funcionario.Senha = senha;
                                Response response = funcionarioBLL.UpdateSenha(funcionario);
                                MessageBox.Show(response.Message);
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