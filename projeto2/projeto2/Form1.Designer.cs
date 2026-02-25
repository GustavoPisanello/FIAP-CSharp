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
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(113, 152);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(553, 41);
            btnEnviar.TabIndex = 0;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(12, 42);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(289, 23);
            txtCodigo.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(479, 42);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(309, 23);
            txtNome.TabIndex = 2;
            // 
            // txtRM
            // 
            txtRM.Location = new Point(207, 95);
            txtRM.Name = "txtRM";
            txtRM.Size = new Size(358, 23);
            txtRM.TabIndex = 3;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(95, 24);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(104, 15);
            lblCodigo.TabIndex = 4;
            lblCodigo.Text = "Código do Aluno: ";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(592, 24);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(98, 15);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome do Aluno: ";
            // 
            // lblRM
            // 
            lblRM.AutoSize = true;
            lblRM.Location = new Point(363, 77);
            lblRM.Name = "lblRM";
            lblRM.Size = new Size(31, 15);
            lblRM.TabIndex = 6;
            lblRM.Text = "RM: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRM);
            Controls.Add(lblNome);
            Controls.Add(lblCodigo);
            Controls.Add(txtRM);
            Controls.Add(txtNome);
            Controls.Add(txtCodigo);
            Controls.Add(btnEnviar);
            Name = "Form1";
            Text = "Form1";
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
    }
}
