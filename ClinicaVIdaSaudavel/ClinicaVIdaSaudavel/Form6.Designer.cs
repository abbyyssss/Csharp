namespace ClinicaVIdaSaudavel
{
    partial class RelatorioForm
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
            dgvConsultas = new DataGridView();
            paciente = new DataGridViewTextBoxColumn();
            médico = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            data = new DataGridViewTextBoxColumn();
            btnGerarRelatorio = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvConsultas).BeginInit();
            SuspendLayout();
            // 
            // dgvConsultas
            // 
            dgvConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultas.Columns.AddRange(new DataGridViewColumn[] { paciente, médico, ID, data });
            dgvConsultas.Location = new Point(2, 12);
            dgvConsultas.Name = "dgvConsultas";
            dgvConsultas.RowTemplate.Height = 25;
            dgvConsultas.Size = new Size(443, 235);
            dgvConsultas.TabIndex = 1;
            // 
            // paciente
            // 
            paciente.HeaderText = "paciente";
            paciente.Name = "paciente";
            // 
            // médico
            // 
            médico.HeaderText = "médico";
            médico.Name = "médico";
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // data
            // 
            data.HeaderText = "data/hora";
            data.Name = "data";
            // 
            // btnGerarRelatorio
            // 
            btnGerarRelatorio.Location = new Point(114, 321);
            btnGerarRelatorio.Name = "btnGerarRelatorio";
            btnGerarRelatorio.Size = new Size(215, 32);
            btnGerarRelatorio.TabIndex = 2;
            btnGerarRelatorio.Text = "gerar PDF";
            btnGerarRelatorio.UseVisualStyleBackColor = true;
            btnGerarRelatorio.Click += button1_Click;
            // 
            // RelatorioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(106, 199, 188);
            ClientSize = new Size(450, 588);
            Controls.Add(btnGerarRelatorio);
            Controls.Add(dgvConsultas);
            Name = "RelatorioForm";
            Text = "Form6";
            Load += RelatorioForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsultas).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvConsultas;
        private DataGridViewTextBoxColumn paciente;
        private DataGridViewTextBoxColumn médico;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn data;
        private Button btnGerarRelatorio;
    }
}