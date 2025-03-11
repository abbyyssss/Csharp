using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaVIdaSaudavel
{
    public partial class FormMedico : System.Windows.Forms.Form
    {
        public FormMedico()
        {
            InitializeComponent();
        }
        private void CarregarConsultasMedico(int idMedico)
        {
            string connectionString = "Server=localhost;Database=ClinicaVidaSaudavel;Uid=root;Pwd=;";


            string query = "SELECT c.id, c.data_hora, c.status, p.nome AS nome_paciente, m.nome AS nome_medico, c.observacoes " +
                           "FROM Consultas c " +
                           "JOIN pacientes p ON c.id_paciente = p.id " +
                           "JOIN medicos m ON c.id_medico = m.id " +
                           "WHERE m.id = @idMedico";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@idMedico", idMedico);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewConsultasMedico.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar as consultas: " + ex.Message);
            }
        }

        private void FormMedico_Load(object sender, EventArgs e)
        {

            CarregarConsultasMedico(1);

        }

        private void btnCancelarConsulta_Click(object sender, EventArgs e)
        {
            if (dataGridViewConsultasMedico.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma consulta para cancelar.");
                return;
            }

            int idConsulta = Convert.ToInt32(dataGridViewConsultasMedico.SelectedRows[0].Cells["id"].Value); // Obtém o ID da consulta
            string connectionString = "Server=localhost;Database=ClinicaVidaSaudavel;Uid=root;Pwd=;";
            string query = "UPDATE Consultas SET status = 'Cancelada' WHERE id = @idConsulta"; // Altera o status da consulta para "Cancelada"

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idConsulta", idConsulta);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Consulta cancelada com sucesso!");


                    CarregarConsultasMedico(1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cancelar consulta: " + ex.Message);
            }
        }

        private void btnsairlogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancelarConsulta_Click_1(object sender, EventArgs e)
        {

        }
    }
}
