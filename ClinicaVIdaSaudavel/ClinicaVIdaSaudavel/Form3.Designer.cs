namespace ClinicaVIdaSaudavel
{
    partial class FormMedico
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
            dataGridViewConsultasMedico = new DataGridView();
            btnCancelarConsulta = new Button();
            btnsairlogin = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsultasMedico).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewConsultasMedico
            // 
            dataGridViewConsultasMedico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConsultasMedico.Location = new Point(1, 3);
            dataGridViewConsultasMedico.Name = "dataGridViewConsultasMedico";
            dataGridViewConsultasMedico.RowTemplate.Height = 25;
            dataGridViewConsultasMedico.Size = new Size(351, 189);
            dataGridViewConsultasMedico.TabIndex = 0;
            // 
            // btnCancelarConsulta
            // 
            btnCancelarConsulta.Location = new Point(100, 230);
            btnCancelarConsulta.Name = "btnCancelarConsulta";
            btnCancelarConsulta.Size = new Size(156, 41);
            btnCancelarConsulta.TabIndex = 1;
            btnCancelarConsulta.Text = "button1";
            btnCancelarConsulta.UseVisualStyleBackColor = true;
            btnCancelarConsulta.Click += btnCancelarConsulta_Click_1;
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
            btnsairlogin.Location = new Point(146, 333);
            btnsairlogin.Name = "btnsairlogin";
            btnsairlogin.Size = new Size(68, 86);
            btnsairlogin.TabIndex = 10;
            btnsairlogin.UseVisualStyleBackColor = false;
            // 
            // FormMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(106, 199, 188);
            ClientSize = new Size(352, 450);
            Controls.Add(btnsairlogin);
            Controls.Add(btnCancelarConsulta);
            Controls.Add(dataGridViewConsultasMedico);
            Name = "FormMedico";
            Text = "FormMedico";
            Load += FormMedico_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsultasMedico).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewConsultasMedico;
        private Button btnCancelarConsulta;
        private Button btnsairlogin;
    }
}