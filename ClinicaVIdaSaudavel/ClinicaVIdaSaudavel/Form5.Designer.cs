namespace ClinicaVIdaSaudavel
{
    partial class FormCadastro
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
            pictureBox1 = new PictureBox();
            comboBoxTipoUsuario = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtNomeUsuario = new TextBox();
            txtSenha = new TextBox();
            txtNome = new TextBox();
            txtDataNascimento = new TextBox();
            txtCPF = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnCadastrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logotipo_Clínica__1_;
            pictureBox1.Location = new Point(1, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // comboBoxTipoUsuario
            // 
            comboBoxTipoUsuario.FormattingEnabled = true;
            comboBoxTipoUsuario.Items.AddRange(new object[] { "Paciente", "Medico", "Administrador" });
            comboBoxTipoUsuario.Location = new Point(198, 75);
            comboBoxTipoUsuario.Name = "comboBoxTipoUsuario";
            comboBoxTipoUsuario.Size = new Size(150, 23);
            comboBoxTipoUsuario.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 9);
            label1.Name = "label1";
            label1.Size = new Size(260, 30);
            label1.TabIndex = 9;
            label1.Text = "olá, bem vindo à nossa clinica! para se registrar, \r\ncomplete com suas informações abaixo!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 78);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 10;
            label2.Text = "você é:";
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Location = new Point(134, 150);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(100, 23);
            txtNomeUsuario.TabIndex = 11;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(134, 195);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 12;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(134, 245);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 13;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.Location = new Point(134, 291);
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(100, 23);
            txtDataNascimento.TabIndex = 14;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(134, 351);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(100, 23);
            txtCPF.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 150);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 16;
            label3.Text = "nome de usuario: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 198);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 17;
            label4.Text = "senha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 248);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 18;
            label5.Text = "nome completo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 294);
            label6.Name = "label6";
            label6.Size = new Size(115, 15);
            label6.TabIndex = 19;
            label6.Text = "Data de nascimento:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(80, 354);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 20;
            label7.Text = "cpf:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(148, 433);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(123, 71);
            btnCadastrar.TabIndex = 21;
            btnCadastrar.Text = "Finalizar cadastro";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(106, 199, 188);
            ClientSize = new Size(420, 612);
            Controls.Add(btnCadastrar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtCPF);
            Controls.Add(txtDataNascimento);
            Controls.Add(txtNome);
            Controls.Add(txtSenha);
            Controls.Add(txtNomeUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxTipoUsuario);
            Controls.Add(pictureBox1);
            Name = "FormCadastro";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox comboBoxTipoUsuario;
        private Label label1;
        private Label label2;
        private TextBox txtNomeUsuario;
        private TextBox txtSenha;
        private TextBox txtNome;
        private TextBox txtDataNascimento;
        private TextBox txtCPF;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnCadastrar;
    }
}