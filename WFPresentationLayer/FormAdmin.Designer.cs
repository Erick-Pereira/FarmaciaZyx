namespace WFPresentationLayer
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.btnRegistrarEntrada = new System.Windows.Forms.Button();
            this.btnRegistrarSaida = new System.Windows.Forms.Button();
            this.btnRegistrarFornecedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Location = new System.Drawing.Point(12, 29);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(117, 23);
            this.btnCadastrarCliente.TabIndex = 0;
            this.btnCadastrarCliente.Text = "Cadastrar Cliente";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(12, 58);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(134, 23);
            this.btnCadastrarFuncionario.TabIndex = 1;
            this.btnCadastrarFuncionario.Text = "Cadastrar Funcionario";
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Location = new System.Drawing.Point(12, 87);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(117, 23);
            this.btnCadastrarProduto.TabIndex = 2;
            this.btnCadastrarProduto.Text = "Cadastrar Produto";
            this.btnCadastrarProduto.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarEntrada
            // 
            this.btnRegistrarEntrada.Location = new System.Drawing.Point(12, 116);
            this.btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            this.btnRegistrarEntrada.Size = new System.Drawing.Size(117, 23);
            this.btnRegistrarEntrada.TabIndex = 3;
            this.btnRegistrarEntrada.Text = "Registrar Entrada";
            this.btnRegistrarEntrada.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarSaida
            // 
            this.btnRegistrarSaida.Location = new System.Drawing.Point(12, 145);
            this.btnRegistrarSaida.Name = "btnRegistrarSaida";
            this.btnRegistrarSaida.Size = new System.Drawing.Size(117, 23);
            this.btnRegistrarSaida.TabIndex = 4;
            this.btnRegistrarSaida.Text = "Registrar Saida";
            this.btnRegistrarSaida.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarFornecedor
            // 
            this.btnRegistrarFornecedor.Location = new System.Drawing.Point(12, 174);
            this.btnRegistrarFornecedor.Name = "btnRegistrarFornecedor";
            this.btnRegistrarFornecedor.Size = new System.Drawing.Size(134, 23);
            this.btnRegistrarFornecedor.TabIndex = 5;
            this.btnRegistrarFornecedor.Text = "Cadastrar Fornecedor";
            this.btnRegistrarFornecedor.UseVisualStyleBackColor = true;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 300);
            this.Controls.Add(this.btnRegistrarFornecedor);
            this.Controls.Add(this.btnRegistrarSaida);
            this.Controls.Add(this.btnRegistrarEntrada);
            this.Controls.Add(this.btnCadastrarProduto);
            this.Controls.Add(this.btnCadastrarFuncionario);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdmin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCadastrarCliente;
        private Button btnCadastrarFuncionario;
        private Button btnCadastrarProduto;
        private Button btnRegistrarEntrada;
        private Button btnRegistrarSaida;
        private Button btnRegistrarFornecedor;
    }
}