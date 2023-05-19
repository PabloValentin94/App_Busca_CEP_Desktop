using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Busca_CEP_Desktop.View.Modules
{

    public partial class form_cidades_por_estado : Form
    {

        string[] estados = { "AC", "AL", "AM", "AP", "BA", "CE", "DF",
                             "ES", "GO", "MA", "MG", "MS", "MT", "PA",
                             "PB", "PE", "PI", "PR", "RJ", "RN", "RO",
                             "RR", "RS", "SC", "SE", "SP", "TO"};

        public form_cidades_por_estado()
        {

            InitializeComponent();

        }

        private void form_cidades_por_estado_Load(object sender, EventArgs e)
        {

            try
            {

                this.Size = new Size(661, 561);

                Configuracao_DataGridView();

            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Configuracao_DataGridView()
        {

            dgv_cidades_estado.Columns.Clear();

            // Definição das colunas:

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Deseja voltar à tela inicial?", "Atenção!",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.Close();

            }

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

            dgv_cidades_estado.Rows.Clear();

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {

            if(dgv_cidades_estado.Rows.Count > 0)
            {

                dgv_cidades_estado.Rows.Clear();

                btn_limpar.Enabled = false;

            }

        }
    }

}
