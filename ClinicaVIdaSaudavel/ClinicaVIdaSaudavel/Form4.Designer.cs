namespace ClinicaVIdaSaudavel
{
    partial class FormAdministrador
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
            btnCadastro = new Button();
            btnSair = new Button();
            btnRelatorio = new Button();
            btnAgendamentoadm = new Button();
            SuspendLayout();
            // 
            // btnCadastro
            // 
            btnCadastro.Location = new Point(307, 466);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(92, 69);
            btnCadastro.TabIndex = 2;
            btnCadastro.Text = "Cadastro";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(38, 462);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(107, 75);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnRelatorio
            // 
            btnRelatorio.Location = new Point(38, 160);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(116, 24);
            btnRelatorio.TabIndex = 4;
            btnRelatorio.Text = "relatórios";
            btnRelatorio.UseVisualStyleBackColor = true;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // btnAgendamentoadm
            // 
            btnAgendamentoadm.Location = new Point(38, 190);
            btnAgendamentoadm.Name = "btnAgendamentoadm";
            btnAgendamentoadm.Size = new Size(116, 25);
            btnAgendamentoadm.TabIndex = 5;
            btnAgendamentoadm.Text = "Agendamentos";
            btnAgendamentoadm.UseVisualStyleBackColor = true;
            // 
            // FormAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(106, 199, 188);
            ClientSize = new Size(451, 604);
            Controls.Add(btnAgendamentoadm);
            Controls.Add(btnRelatorio);
            Controls.Add(btnSair);
            Controls.Add(btnCadastro);
            Name = "FormAdministrador";
            Text = "FormAdministrador";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadastro;
        private Button btnSair;
        private Button btnRelatorio;
        private Button btnAgendamentoadm;
    }
}