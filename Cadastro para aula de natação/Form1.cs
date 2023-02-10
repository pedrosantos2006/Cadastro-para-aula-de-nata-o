using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_para_aula_de_natação
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Enter(object sender, EventArgs e)
        {

        }

        private void txtAnoUltimoAniversario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnoUltimoAniversario_Enter(object sender, EventArgs e)
        {
            if( txtAnoNascimento.Text.Trim().Length < 4)
            {
                MessageBox.Show("É preciso informar o ANO DE NASCIMENTO com 4 digitos", "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtAnoNascimento.Focus();
            }
        }
    }
}
