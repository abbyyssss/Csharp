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
using static ClinicaVIdaSaudavel.FormLogin;

namespace ClinicaVIdaSaudavel
{
    public partial class FormCadastro : System.Windows.Forms.Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nomeUsuario = txtNomeUsuario.Text;
            string senha = txtSenha.Text;
            string tipoUsuario = comboBoxTipoUsuario.SelectedItem.ToString();
            string nome = txtNome.Text;
            string cpf = txtCPF.Text;
            string dataNascimento = txtDataNascimento.Text;

            if (string.IsNullOrEmpty(nomeUsuario) || string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(tipoUsuario))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return;
            }

            
            string query = "INSERT INTO usuarios (nome_usuario, senha, tipo_usuario, id_paciente, id_medico) " +
                           "VALUES (@nome_usuario, @senha, @tipo_usuario, @id_paciente, @id_medico)";
            MySqlConnection conn = DatabaseHelper.GetConnection();

            try
            {
                DatabaseHelper.OpenConnection(conn);

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome_usuario", nomeUsuario);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@tipo_usuario", tipoUsuario);

                int idPaciente = 0;
                int idMedico = 0;

                
                if (tipoUsuario == "Paciente")
                {
                    idPaciente = CriarPaciente(nome, cpf, dataNascimento, conn);
                }

                
                if (tipoUsuario == "Medico")
                {
                    idMedico = CriarMedico(nome, cpf, conn);
                }

               
                if (tipoUsuario == "Administrador")
                {
                    idPaciente = 0;  
                    idMedico = 0;    
                }

                cmd.Parameters.AddWithValue("@id_paciente", idPaciente);
                cmd.Parameters.AddWithValue("@id_medico", idMedico);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
            finally
            {
                DatabaseHelper.CloseConnection(conn);
            }
        }

        private static int CriarPaciente (string nome, string cpf, string dataNascimento, MySqlConnection conn)
        {
            string queryPaciente = "INSERT INTO pacientes (nome, cpf, data_nascimento) VALUES (@nome, @cpf, @data_nascimento)";
            int pacienteId = 0;

            try
            {
                MySqlCommand cmd = new MySqlCommand(queryPaciente, conn);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@data_nascimento", dataNascimento);

                cmd.ExecuteNonQuery();

                // Obtendo o último ID inserido
                pacienteId = Convert.ToInt32(new MySqlCommand("SELECT LAST_INSERT_ID()", conn).ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar paciente: " + ex.Message);
            }

            return pacienteId;
        }

       
        private static int CriarMedico(string nome, string cpf, MySqlConnection conn)
        {
            string queryMedico = "INSERT INTO medicos (nome, cpf) VALUES (@nome, @cpf)";
            int medicoId = 0;

            try
            {
                MySqlCommand cmd = new MySqlCommand(queryMedico, conn);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@cpf", cpf);

                cmd.ExecuteNonQuery();

                // Obtendo o último ID inserido
                medicoId = Convert.ToInt32(new MySqlCommand("SELECT LAST_INSERT_ID()", conn).ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar médico: " + ex.Message);
            }

            return medicoId;
        }
    }
}

      
