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
    public partial class FormAdministrador : System.Windows.Forms.Form
    {
        public FormAdministrador()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            new FormCadastro().Show();


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            new RelatorioForm().Show();
        }
    }
}
