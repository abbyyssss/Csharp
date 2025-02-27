namespace ClinicaVIdaSaudavel
{
    partial class FormLogin
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
            btnLogin = new Button();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btnsairlogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(133, 342);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(92, 69);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(83, 190);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(169, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(83, 240);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(108, 23);
            txtSenha.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 190);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 5;
            label1.Text = "Usuário:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logotipo_Clínica__1_;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 243);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 7;
            label2.Text = "Senha:";
            // 
            // btnsairlogin
            // 
            btnsairlogin.BackColor = Color.Transparent;
            btnsairlogin.FlatAppearance.BorderSize = 2;
            btnsairlogin.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnsairlogin.FlatAppearance.MouseOverBackColor = Color.Cyan;
            btnsairlogin.FlatStyle = FlatStyle.Flat;
            btnsairlogin.ForeColor = Color.Black;
            btnsairlogin.Image = Properties.Resources.icons8_saída_de_emergência_80;
            btnsairlogin.Location = new Point(265, 3);
            btnsairlogin.Name = "btnsairlogin";
            btnsairlogin.Size = new Size(68, 86);
            btnsairlogin.TabIndex = 8;
            btnsairlogin.UseVisualStyleBackColor = false;
            btnsairlogin.Click += btnsairlogin_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(106, 199, 188);
            ClientSize = new Size(345, 450);
            Controls.Add(btnsairlogin);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(btnLogin);
            Name = "FormLogin";
            Text = "FormLogin";
            Load += TelaLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button btnsairlogin;
    }
}