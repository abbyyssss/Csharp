namespace ClinicaVIdaSaudavel
{
    partial class FormPaciente
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
            dataGridViewConsultasPaciente = new DataGridView();
            comboBoxMedico = new ComboBox();
            btnAgendarConsultas = new Button();
            label1 = new Label();
            dataHoraConsulta = new Label();
            dateTimePickerConsulta = new DateTimePicker();
            obs = new Label();
            textBoxObservacoes = new TextBox();
            btnsairlogin = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsultasPaciente).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewConsultasPaciente
            // 
            dataGridViewConsultasPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConsultasPaciente.Location = new Point(0, 2);
            dataGridViewConsultasPaciente.Name = "dataGridViewConsultasPaciente";
            dataGridViewConsultasPaciente.RowTemplate.Height = 25;
            dataGridViewConsultasPaciente.Size = new Size(363, 181);
            dataGridViewConsultasPaciente.TabIndex = 0;
            // 
            // comboBoxMedico
            // 
            comboBoxMedico.FormattingEnabled = true;
            comboBoxMedico.Location = new Point(101, 248);
            comboBoxMedico.Name = "comboBoxMedico";
            comboBoxMedico.Size = new Size(101, 23);
            comboBoxMedico.TabIndex = 1;
            // 
            // btnAgendarConsultas
            // 
            btnAgendarConsultas.Location = new Point(85, 200);
            btnAgendarConsultas.Name = "btnAgendarConsultas";
            btnAgendarConsultas.Size = new Size(184, 30);
            btnAgendarConsultas.TabIndex = 2;
            btnAgendarConsultas.Text = "agendar";
            btnAgendarConsultas.UseVisualStyleBackColor = true;
            btnAgendarConsultas.Click += btnAgendarConsultas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 251);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "medico";
            // 
            // dataHoraConsulta
            // 
            dataHoraConsulta.AutoSize = true;
            dataHoraConsulta.Location = new Point(43, 277);
            dataHoraConsulta.Name = "dataHoraConsulta";
            dataHoraConsulta.Size = new Size(57, 15);
            dataHoraConsulta.TabIndex = 4;
            dataHoraConsulta.Text = "data hora";
            // 
            // dateTimePickerConsulta
            // 
            dateTimePickerConsulta.Location = new Point(106, 277);
            dateTimePickerConsulta.Name = "dateTimePickerConsulta";
            dateTimePickerConsulta.Size = new Size(134, 23);
            dateTimePickerConsulta.TabIndex = 5;
            // 
            // obs
            // 
            obs.AutoSize = true;
            obs.Location = new Point(47, 316);
            obs.Name = "obs";
            obs.Size = new Size(72, 15);
            obs.TabIndex = 6;
            obs.Text = "observações";
            // 
            // textBoxObservacoes
            // 
            textBoxObservacoes.Location = new Point(132, 315);
            textBoxObservacoes.Name = "textBoxObservacoes";
            textBoxObservacoes.Size = new Size(139, 23);
            textBoxObservacoes.TabIndex = 7;
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
            btnsairlogin.Location = new Point(143, 385);
            btnsairlogin.Name = "btnsairlogin";
            btnsairlogin.Size = new Size(68, 86);
            btnsairlogin.TabIndex = 9;
            btnsairlogin.UseVisualStyleBackColor = false;
            btnsairlogin.Click += btnsairlogin_Click;
            // 
            // FormPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(106, 199, 188);
            ClientSize = new Size(356, 518);
            Controls.Add(btnsairlogin);
            Controls.Add(textBoxObservacoes);
            Controls.Add(obs);
            Controls.Add(dateTimePickerConsulta);
            Controls.Add(dataHoraConsulta);
            Controls.Add(label1);
            Controls.Add(btnAgendarConsultas);
            Controls.Add(comboBoxMedico);
            Controls.Add(dataGridViewConsultasPaciente);
            Name = "FormPaciente";
            Text = "FormPaciente";
            Load += FormPaciente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsultasPaciente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewConsultasPaciente;
        private ComboBox comboBoxMedico;
        private Button btnAgendarConsultas;
        private Label label1;
        private Label dataHoraConsulta;
        private DateTimePicker dateTimePickerConsulta;
        private Label obs;
        private TextBox textBoxObservacoes;
        private Button btnsairlogin;
    }
}