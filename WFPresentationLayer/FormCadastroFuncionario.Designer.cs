namespace WFPresentationLayer
{
    partial class FormCadastroFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFuncionario = new System.Windows.Forms.TabPage();
            this.btnProximo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mtxtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.tabEndereço = new System.Windows.Forms.TabPage();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.mtxtNumero = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mtxtCep = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipoFuncionario = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabFuncionario.SuspendLayout();
            this.tabEndereço.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFuncionario);
            this.tabControl1.Controls.Add(this.tabEndereço);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 2;
            // 
            // tabFuncionario
            // 
            this.tabFuncionario.BackColor = System.Drawing.Color.GhostWhite;
            this.tabFuncionario.Controls.Add(this.cmbTipoFuncionario);
            this.tabFuncionario.Controls.Add(this.label7);
            this.tabFuncionario.Controls.Add(this.btnProximo);
            this.tabFuncionario.Controls.Add(this.label6);
            this.tabFuncionario.Controls.Add(this.cmbGenero);
            this.tabFuncionario.Controls.Add(this.mtxtTelefone);
            this.tabFuncionario.Controls.Add(this.label5);
            this.tabFuncionario.Controls.Add(this.label4);
            this.tabFuncionario.Controls.Add(this.txtEmail);
            this.tabFuncionario.Controls.Add(this.mtxtDataNascimento);
            this.tabFuncionario.Controls.Add(this.label3);
            this.tabFuncionario.Controls.Add(this.mtxtCpf);
            this.tabFuncionario.Controls.Add(this.label2);
            this.tabFuncionario.Controls.Add(this.label1);
            this.tabFuncionario.Controls.Add(this.txtNome);
            this.tabFuncionario.Location = new System.Drawing.Point(4, 24);
            this.tabFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabFuncionario.Name = "tabFuncionario";
            this.tabFuncionario.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabFuncionario.Size = new System.Drawing.Size(792, 422);
            this.tabFuncionario.TabIndex = 0;
            this.tabFuncionario.Text = "Funcionario";
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProximo.Location = new System.Drawing.Point(50, 285);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(461, 46);
            this.btnProximo.TabIndex = 34;
            this.btnProximo.Text = "Proxímo";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Genero";
            // 
            // cmbGenero
            // 
            this.cmbGenero.BackColor = System.Drawing.Color.White;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outre"});
            this.cmbGenero.Location = new System.Drawing.Point(50, 171);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(121, 23);
            this.cmbGenero.TabIndex = 12;
            // 
            // mtxtTelefone
            // 
            this.mtxtTelefone.BackColor = System.Drawing.Color.White;
            this.mtxtTelefone.Location = new System.Drawing.Point(333, 171);
            this.mtxtTelefone.Mask = "+99 (99) 90000-0000";
            this.mtxtTelefone.Name = "mtxtTelefone";
            this.mtxtTelefone.Size = new System.Drawing.Size(114, 23);
            this.mtxtTelefone.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(50, 116);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(178, 23);
            this.txtEmail.TabIndex = 8;
            // 
            // mtxtDataNascimento
            // 
            this.mtxtDataNascimento.BackColor = System.Drawing.Color.White;
            this.mtxtDataNascimento.Location = new System.Drawing.Point(333, 111);
            this.mtxtDataNascimento.Mask = "00/00/0000";
            this.mtxtDataNascimento.Name = "mtxtDataNascimento";
            this.mtxtDataNascimento.Size = new System.Drawing.Size(90, 23);
            this.mtxtDataNascimento.TabIndex = 7;
            this.mtxtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data de Nascimento";
            // 
            // mtxtCpf
            // 
            this.mtxtCpf.BackColor = System.Drawing.Color.White;
            this.mtxtCpf.Location = new System.Drawing.Point(333, 56);
            this.mtxtCpf.Mask = "000,000,000-00";
            this.mtxtCpf.Name = "mtxtCpf";
            this.mtxtCpf.Size = new System.Drawing.Size(90, 23);
            this.mtxtCpf.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(50, 56);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(178, 23);
            this.txtNome.TabIndex = 1;
            // 
            // tabEndereço
            // 
            this.tabEndereço.BackColor = System.Drawing.Color.White;
            this.tabEndereço.Controls.Add(this.btnCadastrar);
            this.tabEndereço.Controls.Add(this.label15);
            this.tabEndereço.Controls.Add(this.mtxtNumero);
            this.tabEndereço.Controls.Add(this.label14);
            this.tabEndereço.Controls.Add(this.txtEstado);
            this.tabEndereço.Controls.Add(this.label13);
            this.tabEndereço.Controls.Add(this.txtCidade);
            this.tabEndereço.Controls.Add(this.label11);
            this.tabEndereço.Controls.Add(this.txtComplemento);
            this.tabEndereço.Controls.Add(this.label10);
            this.tabEndereço.Controls.Add(this.txtBairro);
            this.tabEndereço.Controls.Add(this.label9);
            this.tabEndereço.Controls.Add(this.txtRua);
            this.tabEndereço.Controls.Add(this.label8);
            this.tabEndereço.Controls.Add(this.mtxtCep);
            this.tabEndereço.Location = new System.Drawing.Point(4, 24);
            this.tabEndereço.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEndereço.Name = "tabEndereço";
            this.tabEndereço.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEndereço.Size = new System.Drawing.Size(792, 422);
            this.tabEndereço.TabIndex = 1;
            this.tabEndereço.Text = "Endereço";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(52, 271);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(435, 47);
            this.btnCadastrar.TabIndex = 33;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(333, 211);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 15);
            this.label15.TabIndex = 32;
            this.label15.Text = "Número";
            // 
            // mtxtNumero
            // 
            this.mtxtNumero.BackColor = System.Drawing.Color.White;
            this.mtxtNumero.Location = new System.Drawing.Point(333, 228);
            this.mtxtNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxtNumero.Mask = "0999";
            this.mtxtNumero.Name = "mtxtNumero";
            this.mtxtNumero.Size = new System.Drawing.Size(110, 23);
            this.mtxtNumero.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(339, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 15);
            this.label14.TabIndex = 30;
            this.label14.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.White;
            this.txtEstado.Location = new System.Drawing.Point(333, 111);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(178, 23);
            this.txtEstado.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(339, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 15);
            this.label13.TabIndex = 28;
            this.label13.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.Color.White;
            this.txtCidade.Location = new System.Drawing.Point(333, 56);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(178, 23);
            this.txtCidade.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "Complemento";
            // 
            // txtComplemento
            // 
            this.txtComplemento.BackColor = System.Drawing.Color.White;
            this.txtComplemento.Location = new System.Drawing.Point(50, 166);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(178, 23);
            this.txtComplemento.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.White;
            this.txtBairro.Location = new System.Drawing.Point(50, 111);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(178, 23);
            this.txtBairro.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Logradouro";
            // 
            // txtRua
            // 
            this.txtRua.BackColor = System.Drawing.Color.White;
            this.txtRua.Location = new System.Drawing.Point(50, 56);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(178, 23);
            this.txtRua.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "CEP";
            // 
            // mtxtCep
            // 
            this.mtxtCep.BackColor = System.Drawing.Color.White;
            this.mtxtCep.Location = new System.Drawing.Point(333, 166);
            this.mtxtCep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxtCep.Mask = "00000-000";
            this.mtxtCep.Name = "mtxtCep";
            this.mtxtCep.Size = new System.Drawing.Size(110, 23);
            this.mtxtCep.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "Tipo de Funcionario";
            // 
            // cmbTipoFuncionario
            // 
            this.cmbTipoFuncionario.FormattingEnabled = true;
            this.cmbTipoFuncionario.Location = new System.Drawing.Point(50, 219);
            this.cmbTipoFuncionario.Name = "cmbTipoFuncionario";
            this.cmbTipoFuncionario.Size = new System.Drawing.Size(121, 23);
            this.cmbTipoFuncionario.TabIndex = 36;
            // 
            // FormCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormCadastroCliente";
            this.Text = "Cadastro de Funcionario";
            this.tabControl1.ResumeLayout(false);
            this.tabFuncionario.ResumeLayout(false);
            this.tabFuncionario.PerformLayout();
            this.tabEndereço.ResumeLayout(false);
            this.tabEndereço.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabFuncionario;
        private Button btnProximo;
        private Label label6;
        private ComboBox cmbGenero;
        private MaskedTextBox mtxtTelefone;
        private Label label5;
        private Label label4;
        private TextBox txtEmail;
        private MaskedTextBox mtxtDataNascimento;
        private Label label3;
        private MaskedTextBox mtxtCpf;
        private Label label2;
        private Label label1;
        private TextBox txtNome;
        private TabPage tabEndereço;
        private Button btnCadastrar;
        private Label label15;
        private MaskedTextBox mtxtNumero;
        private Label label14;
        private TextBox txtEstado;
        private Label label13;
        private TextBox txtCidade;
        private Label label11;
        private TextBox txtComplemento;
        private Label label10;
        private TextBox txtBairro;
        private Label label9;
        private TextBox txtRua;
        private Label label8;
        private MaskedTextBox mtxtCep;
        private ComboBox cmbTipoFuncionario;
        private Label label7;
    }
}