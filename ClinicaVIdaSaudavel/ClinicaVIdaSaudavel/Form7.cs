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
    public partial class formAgendamento : Form
    {
        public formAgendamento()
        {
            InitializeComponent();
        }

        private void CarregarConsultas()

        {

            string connectionString = "Server=localhost;Database=ClinicaVidaSaudavel;Uid=root;"; // Substitua com suas credenciais


            string query = "SELECT * FROM Consultas";

            try
            {

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);


                    DataTable dataTable = new DataTable();


                    adapter.Fill(dataTable);


                    dataGridViewConsultas.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao carregar as consultas: " + ex.Message);
            }
        }







        private void formAgendamento_Load(object sender, EventArgs e)
        {
            CarregarConsultas();
        }

        private void dataGridViewConsultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (dataGridViewConsultas.SelectedRows.Count > 0)
            {
                
                int consultaId = Convert.ToInt32(dataGridViewConsultas.SelectedRows[0].Cells["id"].Value);

              
                DateTime novaDataHora = dateTimePickerRemarcar.Value;

                
                string connectionString = "Server=localhost;Database=ClinicaVidaSaudavel;Uid=root;Pwd=;";
                string query = "UPDATE Consultas SET data_hora = @novaDataHora, status = 'Remanejada' WHERE id = @consultaId";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@novaDataHora", novaDataHora);
                    cmd.Parameters.AddWithValue("@consultaId", consultaId);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Consulta remarcada com sucesso!");
                        CarregarConsultas(); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao remarcar a consulta: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma consulta para remarcar.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           
            if (dataGridViewConsultas.SelectedRows.Count > 0)
            {
                
                int consultaId = Convert.ToInt32(dataGridViewConsultas.SelectedRows[0].Cells["id"].Value);

               
                string connectionString = "Server=localhost;Database=ClinicaVidaSaudavel;Uid=root;Pwd=;";
                string query = "UPDATE Consultas SET status = 'Cancelada' WHERE id = @consultaId";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@consultaId", consultaId);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Consulta cancelada com sucesso!");
                        CarregarConsultas(); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cancelar a consulta: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma consulta para cancelar.");
            }
        }
    }
}


