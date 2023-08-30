namespace SistemaKF
{
    partial class telaLogin
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
            lblUsuario = new Label();
            btnEntrar = new Button();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            lblSenha = new Label();
            btnSair = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.Location = new Point(43, 39);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(71, 33);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            lblUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrar.Location = new Point(260, 296);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(179, 86);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuario.Location = new Point(43, 75);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(396, 53);
            txtUsuario.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            txtSenha.Location = new Point(43, 199);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(396, 53);
            txtSenha.TabIndex = 4;
            // 
            // lblSenha
            // 
            lblSenha.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblSenha.Location = new Point(43, 163);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(71, 33);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            lblSenha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.Location = new Point(43, 334);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(184, 48);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // telaLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 428);
            Controls.Add(btnSair);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtUsuario);
            Controls.Add(btnEntrar);
            Controls.Add(lblUsuario);
            Name = "telaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Button btnEntrar;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label lblSenha;
        private Button btnSair;
    }
}