namespace WFPresentationLayer
{
    partial class FormUpdateCliente
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
            this.btnUpdateCliente = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.mtxtTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxtTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.mtxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoCliente = new System.Windows.Forms.ComboBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpdateCliente
            // 
            this.btnUpdateCliente.Location = new System.Drawing.Point(317, 308);
            this.btnUpdateCliente.Name = "btnUpdateCliente";
            this.btnUpdateCliente.Size = new System.Drawing.Size(144, 23);
            this.btnUpdateCliente.TabIndex = 65;
            this.btnUpdateCliente.Text = "Update Cliente";
            this.btnUpdateCliente.UseVisualStyleBackColor = true;
            this.btnUpdateCliente.Click += new System.EventHandler(this.btnUpdateCliente_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 64;
            this.label6.Text = "Tipo de Cliente";
            // 
            // mtxtTelefone2
            // 
            this.mtxtTelefone2.BackColor = System.Drawing.Color.White;
            this.mtxtTelefone2.Location = new System.Drawing.Point(416, 182);
            this.mtxtTelefone2.Mask = "+99 (99) 90000-0000";
            this.mtxtTelefone2.Name = "mtxtTelefone2";
            this.mtxtTelefone2.Size = new System.Drawing.Size(114, 23);
            this.mtxtTelefone2.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 62;
            this.label4.Text = "Telefone 2";
            // 
            // mtxtTelefone1
            // 
            this.mtxtTelefone1.BackColor = System.Drawing.Color.White;
            this.mtxtTelefone1.Location = new System.Drawing.Point(416, 138);
            this.mtxtTelefone1.Mask = "+99 (99) 90000-0000";
            this.mtxtTelefone1.Name = "mtxtTelefone1";
            this.mtxtTelefone1.Size = new System.Drawing.Size(114, 23);
            this.mtxtTelefone1.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 60;
            this.label5.Text = "Telefone 1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(271, 249);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 15);
            this.label16.TabIndex = 58;
            this.label16.Text = "RG";
            // 
            // mtxtCpf
            // 
            this.mtxtCpf.BackColor = System.Drawing.Color.White;
            this.mtxtCpf.Location = new System.Drawing.Point(271, 223);
            this.mtxtCpf.Mask = "000.000.000-00";
            this.mtxtCpf.Name = "mtxtCpf";
            this.mtxtCpf.Size = new System.Drawing.Size(90, 23);
            this.mtxtCpf.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 56;
            this.label3.Text = "CPF";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(271, 182);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 23);
            this.txtEmail.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 54;
            this.label2.Text = "Email";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(271, 138);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 52;
            this.label1.Text = "Nome";
            // 
            // cmbTipoCliente
            // 
            this.cmbTipoCliente.FormattingEnabled = true;
            this.cmbTipoCliente.Location = new System.Drawing.Point(416, 223);
            this.cmbTipoCliente.Name = "cmbTipoCliente";
            this.cmbTipoCliente.Size = new System.Drawing.Size(114, 23);
            this.cmbTipoCliente.TabIndex = 51;
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(271, 267);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(100, 23);
            this.txtRg.TabIndex = 66;
            // 
            // FormUpdateCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.btnUpdateCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtxtTelefone2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtxtTelefone1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.mtxtCpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipoCliente);
            this.Name = "FormUpdateCliente";
            this.Text = "FormUpdateCliente";
            this.Load += new System.EventHandler(this.FormUpdateCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnUpdateCliente;
        private Label label6;
        private MaskedTextBox mtxtTelefone2;
        private Label label4;
        private MaskedTextBox mtxtTelefone1;
        private Label label5;
        private Label label16;
        private MaskedTextBox mtxtCpf;
        private Label label3;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private ComboBox cmbTipoCliente;
        private TextBox txtRg;
    }
}