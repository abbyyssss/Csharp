
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ClinicaVIdaSaudavel
{
    public partial class FormLogin : System.Windows.Forms.Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public static class DatabaseHelper
        {
            private static string connectionString = "Server=localhost; Database=ClinicaVidaSaudavel; Uid=root;";

            public static MySqlConnection GetConnection()
            {
                return new MySqlConnection(connectionString);
            }

            public static void OpenConnection(MySqlConnection connection)
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();
            }

            public static void CloseConnection(MySqlConnection connection)
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }


        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nomeUsuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            string query = "SELECT * FROM usuarios WHERE nome_usuario = @nome_usuario AND senha = @senha";
            MySqlConnection conn = DatabaseHelper.GetConnection();

            try
            {
                DatabaseHelper.OpenConnection(conn);

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome_usuario", nomeUsuario);
                cmd.Parameters.AddWithValue("@senha", senha);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string tipoUsuario = reader["tipo_usuario"].ToString();
                    MessageBox.Show("Login bem-sucedido como " + tipoUsuario);


                    if (tipoUsuario == "Paciente")
                        new FormPaciente().Show();
                    else if (tipoUsuario == "Medico")
                        new FormMedico().Show();
                    else if (tipoUsuario == "Administrador")
                        new FormAdministrador().Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                DatabaseHelper.CloseConnection(conn);
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            new FormCadastro().Show();

            this.Hide();
        }

        private void btnsairlogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
