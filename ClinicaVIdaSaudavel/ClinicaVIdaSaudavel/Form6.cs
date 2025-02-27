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
    public partial class RelatorioForm : System.Windows.Forms.Form
    {
        public RelatorioForm()
        {
            InitializeComponent();
        }
        private void CarregarConsultas()
        {
            string connString = "server=localhost;database=ClinicaVidaSaudavel;uid=root;";
            string query = "SELECT c.id, c.data_hora, c.status, p.nome AS Paciente, m.nome AS Medico " +
                           "FROM consultas c " +
                           "JOIN pacientes p ON c.id_paciente = p.id " +
                           "JOIN medicos m ON c.id_medico = m.id";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvConsultas.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
            }
        }


        private void RelatorioForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
