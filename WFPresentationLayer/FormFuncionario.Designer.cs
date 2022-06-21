namespace WFPresentationLayer
{
    partial class FormFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFuncionario));
            this.btnRegistrarFornecedor = new System.Windows.Forms.Button();
            this.btnRegistrarSaida = new System.Windows.Forms.Button();
            this.btnRegistrarEntrada = new System.Windows.Forms.Button();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistrarFornecedor
            // 
            this.btnRegistrarFornecedor.Location = new System.Drawing.Point(35, 148);
            this.btnRegistrarFornecedor.Name = "btnRegistrarFornecedor";
            this.btnRegistrarFornecedor.Size = new System.Drawing.Size(129, 23);
            this.btnRegistrarFornecedor.TabIndex = 11;
            this.btnRegistrarFornecedor.Text = "Cadastrar Fornecedor";
            this.btnRegistrarFornecedor.UseVisualStyleBackColor = true;
            this.btnRegistrarFornecedor.Click += new System.EventHandler(this.btnRegistrarFornecedor_Click);
            // 
            // btnRegistrarSaida
            // 
            this.btnRegistrarSaida.Location = new System.Drawing.Point(35, 119);
            this.btnRegistrarSaida.Name = "btnRegistrarSaida";
            this.btnRegistrarSaida.Size = new System.Drawing.Size(117, 23);
            this.btnRegistrarSaida.TabIndex = 10;
            this.btnRegistrarSaida.Text = "Registrar Saida";
            this.btnRegistrarSaida.UseVisualStyleBackColor = true;
            this.btnRegistrarSaida.Click += new System.EventHandler(this.btnRegistrarSaida_Click);
            // 
            // btnRegistrarEntrada
            // 
            this.btnRegistrarEntrada.Location = new System.Drawing.Point(35, 90);
            this.btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            this.btnRegistrarEntrada.Size = new System.Drawing.Size(117, 23);
            this.btnRegistrarEntrada.TabIndex = 9;
            this.btnRegistrarEntrada.Text = "Registrar Entrada";
            this.btnRegistrarEntrada.UseVisualStyleBackColor = true;
            this.btnRegistrarEntrada.Click += new System.EventHandler(this.btnRegistrarEntrada_Click);
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Location = new System.Drawing.Point(35, 61);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(117, 23);
            this.btnCadastrarProduto.TabIndex = 8;
            this.btnCadastrarProduto.Text = "Cadastrar Produto";
            this.btnCadastrarProduto.UseVisualStyleBackColor = true;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Location = new System.Drawing.Point(35, 32);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(117, 23);
            this.btnCadastrarCliente.TabIndex = 6;
            this.btnCadastrarCliente.Text = "Cadastrar Cliente";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // FormFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 210);
            this.Controls.Add(this.btnRegistrarFornecedor);
            this.Controls.Add(this.btnRegistrarSaida);
            this.Controls.Add(this.btnRegistrarEntrada);
            this.Controls.Add(this.btnCadastrarProduto);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFuncionario";
            this.Text = "FarmaciaZyx";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRegistrarFornecedor;
        private Button btnRegistrarSaida;
        private Button btnRegistrarEntrada;
        private Button btnCadastrarProduto;
        private Button btnCadastrarCliente;
    }
}