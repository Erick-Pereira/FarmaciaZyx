namespace WFPresentationLayer
{
    partial class FormCadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroCliente));
            this.cmbTipoCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtRg = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.mtxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxtTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbTipoCliente
            // 
            this.cmbTipoCliente.FormattingEnabled = true;
            this.cmbTipoCliente.Location = new System.Drawing.Point(394, 190);
            this.cmbTipoCliente.Name = "cmbTipoCliente";
            this.cmbTipoCliente.Size = new System.Drawing.Size(114, 23);
            this.cmbTipoCliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(249, 105);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(249, 149);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 23);
            this.txtEmail.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // mtxtRg
            // 
            this.mtxtRg.Location = new System.Drawing.Point(249, 236);
            this.mtxtRg.Mask = "0.000.000";
            this.mtxtRg.Name = "mtxtRg";
            this.mtxtRg.Size = new System.Drawing.Size(100, 23);
            this.mtxtRg.TabIndex = 44;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(249, 216);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 15);
            this.label16.TabIndex = 43;
            this.label16.Text = "RG";
            // 
            // mtxtCpf
            // 
            this.mtxtCpf.BackColor = System.Drawing.Color.White;
            this.mtxtCpf.Location = new System.Drawing.Point(249, 190);
            this.mtxtCpf.Mask = "000.000.000-00";
            this.mtxtCpf.Name = "mtxtCpf";
            this.mtxtCpf.Size = new System.Drawing.Size(90, 23);
            this.mtxtCpf.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 41;
            this.label3.Text = "CPF";
            // 
            // mtxtTelefone1
            // 
            this.mtxtTelefone1.BackColor = System.Drawing.Color.White;
            this.mtxtTelefone1.Location = new System.Drawing.Point(394, 105);
            this.mtxtTelefone1.Mask = "+99 (99) 90000-0000";
            this.mtxtTelefone1.Name = "mtxtTelefone1";
            this.mtxtTelefone1.Size = new System.Drawing.Size(114, 23);
            this.mtxtTelefone1.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 45;
            this.label5.Text = "Telefone 1";
            // 
            // mtxtTelefone2
            // 
            this.mtxtTelefone2.BackColor = System.Drawing.Color.White;
            this.mtxtTelefone2.Location = new System.Drawing.Point(394, 149);
            this.mtxtTelefone2.Mask = "+99 (99) 90000-0000";
            this.mtxtTelefone2.Name = "mtxtTelefone2";
            this.mtxtTelefone2.Size = new System.Drawing.Size(114, 23);
            this.mtxtTelefone2.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 47;
            this.label4.Text = "Telefone 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 49;
            this.label6.Text = "Tipo de Cliente";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(295, 275);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(144, 23);
            this.btnCadastrar.TabIndex = 50;
            this.btnCadastrar.Text = "Cadastrar Cliente";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // FormCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtxtTelefone2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtxtTelefone1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtxtRg);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.mtxtCpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipoCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastroCliente";
            this.Text = "Cadastro Cliente";
            this.Load += new System.EventHandler(this.FormCadastroCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbTipoCliente;
        private Label label1;
        private TextBox txtNome;
        private TextBox txtEmail;
        private Label label2;
        private MaskedTextBox mtxtRg;
        private Label label16;
        private MaskedTextBox mtxtCpf;
        private Label label3;
        private MaskedTextBox mtxtTelefone1;
        private Label label5;
        private MaskedTextBox mtxtTelefone2;
        private Label label4;
        private Label label6;
        private Button btnCadastrar;
    }
}