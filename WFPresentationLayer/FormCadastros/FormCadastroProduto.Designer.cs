namespace WFPresentationLayer
{
    partial class FormCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroProduto));
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLaboratorio = new System.Windows.Forms.ComboBox();
            this.cmbUnidade = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOpenLaboratorio = new System.Windows.Forms.Button();
            this.panelCadastroLaboratorio = new System.Windows.Forms.Panel();
            this.mtxtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLaboratorio = new System.Windows.Forms.TextBox();
            this.btnCadastrarLaboratorio = new System.Windows.Forms.Button();
            this.panelCadastroLaboratorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(211, 306);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(124, 34);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(277, 78);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(277, 124);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(100, 23);
            this.txtDescricao.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Laboratorio";
            // 
            // cmbLaboratorio
            // 
            this.cmbLaboratorio.FormattingEnabled = true;
            this.cmbLaboratorio.Location = new System.Drawing.Point(277, 168);
            this.cmbLaboratorio.Name = "cmbLaboratorio";
            this.cmbLaboratorio.Size = new System.Drawing.Size(100, 23);
            this.cmbLaboratorio.TabIndex = 9;
            this.cmbLaboratorio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbLaboratorio_MouseClick);
            // 
            // cmbUnidade
            // 
            this.cmbUnidade.FormattingEnabled = true;
            this.cmbUnidade.Location = new System.Drawing.Point(277, 219);
            this.cmbUnidade.Name = "cmbUnidade";
            this.cmbUnidade.Size = new System.Drawing.Size(100, 23);
            this.cmbUnidade.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Un";
            // 
            // btnOpenLaboratorio
            // 
            this.btnOpenLaboratorio.Location = new System.Drawing.Point(344, 306);
            this.btnOpenLaboratorio.Name = "btnOpenLaboratorio";
            this.btnOpenLaboratorio.Size = new System.Drawing.Size(130, 34);
            this.btnOpenLaboratorio.TabIndex = 12;
            this.btnOpenLaboratorio.Text = "Cadastrar Laboratorio";
            this.btnOpenLaboratorio.UseVisualStyleBackColor = true;
            this.btnOpenLaboratorio.Click += new System.EventHandler(this.btnCadastrarLaboratorio_Click);
            // 
            // panelCadastroLaboratorio
            // 
            this.panelCadastroLaboratorio.BackColor = System.Drawing.Color.White;
            this.panelCadastroLaboratorio.Controls.Add(this.mtxtCNPJ);
            this.panelCadastroLaboratorio.Controls.Add(this.label4);
            this.panelCadastroLaboratorio.Controls.Add(this.label6);
            this.panelCadastroLaboratorio.Controls.Add(this.txtLaboratorio);
            this.panelCadastroLaboratorio.Controls.Add(this.btnCadastrarLaboratorio);
            this.panelCadastroLaboratorio.Enabled = false;
            this.panelCadastroLaboratorio.Location = new System.Drawing.Point(474, 12);
            this.panelCadastroLaboratorio.Name = "panelCadastroLaboratorio";
            this.panelCadastroLaboratorio.Size = new System.Drawing.Size(202, 209);
            this.panelCadastroLaboratorio.TabIndex = 13;
            this.panelCadastroLaboratorio.Visible = false;
            // 
            // mtxtCNPJ
            // 
            this.mtxtCNPJ.Location = new System.Drawing.Point(51, 108);
            this.mtxtCNPJ.Mask = "00.000.000/0000-00";
            this.mtxtCNPJ.Name = "mtxtCNPJ";
            this.mtxtCNPJ.Size = new System.Drawing.Size(100, 23);
            this.mtxtCNPJ.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "CNPJ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Laboratorio";
            // 
            // txtLaboratorio
            // 
            this.txtLaboratorio.Location = new System.Drawing.Point(51, 57);
            this.txtLaboratorio.Name = "txtLaboratorio";
            this.txtLaboratorio.Size = new System.Drawing.Size(100, 23);
            this.txtLaboratorio.TabIndex = 19;
            // 
            // btnCadastrarLaboratorio
            // 
            this.btnCadastrarLaboratorio.Location = new System.Drawing.Point(51, 146);
            this.btnCadastrarLaboratorio.Name = "btnCadastrarLaboratorio";
            this.btnCadastrarLaboratorio.Size = new System.Drawing.Size(100, 23);
            this.btnCadastrarLaboratorio.TabIndex = 18;
            this.btnCadastrarLaboratorio.Text = "Cadastrar";
            this.btnCadastrarLaboratorio.UseVisualStyleBackColor = true;
            this.btnCadastrarLaboratorio.Click += new System.EventHandler(this.btnCadastrarLaboratorio_Click_1);
            // 
            // FormCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 456);
            this.Controls.Add(this.btnOpenLaboratorio);
            this.Controls.Add(this.cmbUnidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbLaboratorio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.panelCadastroLaboratorio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastroProduto";
            this.Text = "Cadastro de produto";
            this.Load += new System.EventHandler(this.FormCadastroProduto_Load);
            this.panelCadastroLaboratorio.ResumeLayout(false);
            this.panelCadastroLaboratorio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCadastrar;
        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private TextBox txtDescricao;
        private Label label3;
        private ComboBox cmbLaboratorio;
        private ComboBox cmbUnidade;
        private Label label5;
        private Button btnOpenLaboratorio;
        private Panel panelCadastroLaboratorio;
        private MaskedTextBox mtxtCNPJ;
        private Label label4;
        private Label label6;
        private TextBox txtLaboratorio;
        private Button btnCadastrarLaboratorio;
    }
}