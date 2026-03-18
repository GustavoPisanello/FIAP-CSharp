namespace CadastroProdutos
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new TextBox();
            txtPreco = new TextBox();
            txtQuantidade = new TextBox();
            txtCep = new TextBox();
            txtBairro = new TextBox();
            txtCidade = new TextBox();
            txtEstado = new TextBox();
            txtLogradouro = new TextBox();
            btnCadastrar = new Button();
            btnExcluir = new Button();
            lblStatus = new Label();
            dgvProdutos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(54, 61);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome do Produto";
            txtNome.Size = new Size(237, 23);
            txtNome.TabIndex = 0;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(54, 104);
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = "Preço";
            txtPreco.Size = new Size(237, 23);
            txtPreco.TabIndex = 1;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(54, 153);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.PlaceholderText = "Quantidade";
            txtQuantidade.Size = new Size(237, 23);
            txtQuantidade.TabIndex = 2;
            txtQuantidade.TextChanged += txtQuantidade_TextChanged;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(54, 197);
            txtCep.Name = "txtCep";
            txtCep.PlaceholderText = "CEP";
            txtCep.Size = new Size(237, 23);
            txtCep.TabIndex = 3;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(54, 344);
            txtBairro.Name = "txtBairro";
            txtBairro.PlaceholderText = "Bairro";
            txtBairro.Size = new Size(237, 23);
            txtBairro.TabIndex = 4;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(54, 298);
            txtCidade.Name = "txtCidade";
            txtCidade.PlaceholderText = "Cidade";
            txtCidade.Size = new Size(237, 23);
            txtCidade.TabIndex = 5;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(54, 388);
            txtEstado.Name = "txtEstado";
            txtEstado.PlaceholderText = "Estado";
            txtEstado.Size = new Size(237, 23);
            txtEstado.TabIndex = 6;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(54, 246);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.PlaceholderText = "Logradouro";
            txtLogradouro.Size = new Size(237, 23);
            txtLogradouro.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(718, 61);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(138, 40);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(335, 61);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(138, 40);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(335, 396);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 11;
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(335, 132);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(521, 235);
            dgvProdutos.TabIndex = 12;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 450);
            Controls.Add(dgvProdutos);
            Controls.Add(lblStatus);
            Controls.Add(btnExcluir);
            Controls.Add(btnCadastrar);
            Controls.Add(txtLogradouro);
            Controls.Add(txtEstado);
            Controls.Add(txtCidade);
            Controls.Add(txtBairro);
            Controls.Add(txtCep);
            Controls.Add(txtQuantidade);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            Name = "FormPrincipal";
            Text = "Form1";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtPreco;
        private TextBox txtQuantidade;
        private TextBox txtCep;
        private TextBox txtBairro;
        private TextBox txtCidade;
        private TextBox txtEstado;
        private TextBox txtLogradouro;
        private Button btnCadastrar;
        private Button btnExcluir;
        private Label lblStatus;
        private DataGridView dgvProdutos;
    }
}
