namespace projeto2
{
    partial class Form1
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
            btnEnviar = new Button();
            txtCodigo = new TextBox();
            txtNome = new TextBox();
            txtRM = new TextBox();
            lblCodigo = new Label();
            lblNome = new Label();
            lblRM = new Label();
            dgvAluno = new DataGridView();
            lblCep = new Label();
            txtcep = new TextBox();
            lblRua = new Label();
            txtRua = new TextBox();
            lblBairro = new Label();
            txtBairro = new TextBox();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAluno).BeginInit();
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(123, 207);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(553, 41);
            btnEnviar.TabIndex = 0;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(12, 91);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(289, 23);
            txtCodigo.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(289, 23);
            txtNome.TabIndex = 2;
            // 
            // txtRM
            // 
            txtRM.Location = new Point(12, 144);
            txtRM.Name = "txtRM";
            txtRM.Size = new Size(289, 23);
            txtRM.TabIndex = 3;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(95, 73);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(104, 15);
            lblCodigo.TabIndex = 4;
            lblCodigo.Text = "Código do Aluno: ";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(95, 19);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(98, 15);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome do Aluno: ";
            // 
            // lblRM
            // 
            lblRM.AutoSize = true;
            lblRM.Location = new Point(111, 126);
            lblRM.Name = "lblRM";
            lblRM.Size = new Size(31, 15);
            lblRM.TabIndex = 6;
            lblRM.Text = "RM: ";
            // 
            // dgvAluno
            // 
            dgvAluno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAluno.Location = new Point(189, 272);
            dgvAluno.Name = "dgvAluno";
            dgvAluno.Size = new Size(426, 152);
            dgvAluno.TabIndex = 7;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(513, 19);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(31, 15);
            lblCep.TabIndex = 9;
            lblCep.Text = "CEP:";
            // 
            // txtcep
            // 
            txtcep.Location = new Point(482, 37);
            txtcep.Name = "txtcep";
            txtcep.Size = new Size(194, 23);
            txtcep.TabIndex = 8;
            txtcep.TextChanged += textBox1_TextChanged;
            // 
            // lblRua
            // 
            lblRua.AutoSize = true;
            lblRua.Location = new Point(513, 73);
            lblRua.Name = "lblRua";
            lblRua.Size = new Size(30, 15);
            lblRua.TabIndex = 11;
            lblRua.Text = "Rua:";
            // 
            // txtRua
            // 
            txtRua.Enabled = false;
            txtRua.Location = new Point(482, 91);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(289, 23);
            txtRua.TabIndex = 10;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(513, 126);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(41, 15);
            lblBairro.TabIndex = 13;
            lblBairro.Text = "Bairro:";
            // 
            // txtBairro
            // 
            txtBairro.Enabled = false;
            txtBairro.Location = new Point(482, 144);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(289, 23);
            txtBairro.TabIndex = 12;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(696, 36);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 450);
            Controls.Add(btnBuscar);
            Controls.Add(lblBairro);
            Controls.Add(txtBairro);
            Controls.Add(lblRua);
            Controls.Add(txtRua);
            Controls.Add(lblCep);
            Controls.Add(txtcep);
            Controls.Add(dgvAluno);
            Controls.Add(lblRM);
            Controls.Add(lblNome);
            Controls.Add(lblCodigo);
            Controls.Add(txtRM);
            Controls.Add(txtNome);
            Controls.Add(txtCodigo);
            Controls.Add(btnEnviar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvAluno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnviar;
        private TextBox txtCodigo;
        private TextBox txtNome;
        private TextBox txtRM;
        private Label lblCodigo;
        private Label lblNome;
        private Label lblRM;
        private DataGridView dgvAluno;
        private Label lblCep;
        private TextBox txtcep;
        private Label lblRua;
        private TextBox txtRua;
        private Label lblBairro;
        private TextBox txtBairro;
        private Button btnBuscar;
    }
}
