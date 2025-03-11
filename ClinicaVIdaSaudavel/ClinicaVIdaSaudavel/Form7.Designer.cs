namespace ClinicaVIdaSaudavel
{
    partial class formAgendamento
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
            btnRemarcar = new Button();
            btnCancelar = new Button();
            dataGridViewConsultas = new DataGridView();
            dateTimePickerRemarcar = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsultas).BeginInit();
            SuspendLayout();
            // 
            // btnRemarcar
            // 
            btnRemarcar.Location = new Point(12, 293);
            btnRemarcar.Name = "btnRemarcar";
            btnRemarcar.Size = new Size(88, 23);
            btnRemarcar.TabIndex = 0;
            btnRemarcar.Text = "remarcar";
            btnRemarcar.UseVisualStyleBackColor = true;
            btnRemarcar.Click += button1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(349, 293);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dataGridViewConsultas
            // 
            dataGridViewConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConsultas.Location = new Point(-3, -1);
            dataGridViewConsultas.Name = "dataGridViewConsultas";
            dataGridViewConsultas.RowTemplate.Height = 25;
            dataGridViewConsultas.Size = new Size(453, 269);
            dataGridViewConsultas.TabIndex = 3;
            dataGridViewConsultas.CellContentClick += dataGridViewConsultas_CellContentClick;
            // 
            // dateTimePickerRemarcar
            // 
            dateTimePickerRemarcar.Location = new Point(12, 322);
            dateTimePickerRemarcar.Name = "dateTimePickerRemarcar";
            dateTimePickerRemarcar.Size = new Size(152, 23);
            dateTimePickerRemarcar.TabIndex = 4;
            // 
            // formAgendamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(106, 199, 188);
            ClientSize = new Size(449, 556);
            Controls.Add(dateTimePickerRemarcar);
            Controls.Add(dataGridViewConsultas);
            Controls.Add(btnCancelar);
            Controls.Add(btnRemarcar);
            Name = "formAgendamento";
            Text = "Form7";
            Load += formAgendamento_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsultas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRemarcar;
        private Button btnCancelar;
        private DataGridView dataGridViewConsultas;
        private DateTimePicker dateTimePickerRemarcar;
    }
}