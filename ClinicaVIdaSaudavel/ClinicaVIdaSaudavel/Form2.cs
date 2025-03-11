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
    public partial class FormPaciente : System.Windows.Forms.Form
    {
        public FormPaciente()
        {
            InitializeComponent();
        }
        private void CarregarConsultasPaciente(int idPaciente)
        {
            string connectionString = "Server=localhost;Database=ClinicaVidaSaudavel;Uid=root;Pwd=;";


            string query = "SELECT c.id, c.data_hora, c.status, p.nome AS nome_paciente, m.nome AS nome_medico, c.observacoes " +
                           "FROM Consultas c " +
                           "JOIN pacientes p ON c.id_paciente = p.id " +
                           "JOIN medicos m ON c.id_medico = m.id " +
                           "WHERE p.id = @idPaciente";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@idPaciente", idPaciente);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewConsultasPaciente.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar as consultas: " + ex.Message);
            }
        }

        private void CarregarMedicos()
        {
            string connectionString = "Server=localhost;Database=ClinicaVidaSaudavel;Uid=root;Pwd=;";
            string query = "SELECT id, nome FROM medicos";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);


                    comboBoxMedico.DataSource = dataTable;
                    comboBoxMedico.DisplayMember = "nome";
                    comboBoxMedico.ValueMember = "id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar médicos: " + ex.Message);
            }
        }


        private void FormPaciente_Load(object sender, EventArgs e)
        {

        }

        private void btnAgendarConsultas_Click(object sender, EventArgs e)
        {
            string nomePaciente = "João Silva";
            int idMedico = (int)comboBoxMedico.SelectedValue;
            DateTime dataHoraConsulta = dateTimePickerConsulta.Value;
            string observacoes = textBoxObservacoes.Text;

            string connectionString = "Server=localhost;Database=ClinicaVidaSaudavel;Uid=root;Pwd=;";
            string query = "INSERT INTO Consultas (data_hora, status, id_paciente, id_medico, observacoes) " +
                           "VALUES (@dataHora, 'Agendada', (SELECT id FROM pacientes WHERE nome = @nomePaciente), @idMedico, @observacoes)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nomePaciente", nomePaciente);
                    cmd.Parameters.AddWithValue("@idMedico", idMedico);
                    cmd.Parameters.AddWithValue("@dataHora", dataHoraConsulta);
                    cmd.Parameters.AddWithValue("@observacoes", observacoes);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Consulta agendada com sucesso!");

                    
                    CarregarConsultasPaciente(1); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao agendar consulta: " + ex.Message);
            }
        }

        private void btnsairlogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
