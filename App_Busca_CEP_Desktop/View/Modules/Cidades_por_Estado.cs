using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using App_Busca_CEP_Desktop.Model;
using App_Busca_CEP_Desktop.Service;

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

                cbbox_estado.DataSource = this.estados;

                btn_limpar.Enabled = false;

            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Configuracao_DataGridView()
        {

            try
            {

                dgv_cidades_estado.ForeColor = Color.Black;

                dgv_cidades_estado.Columns.Clear();

                // Definição das colunas:

                dgv_cidades_estado.Columns.Insert(0, new DataGridViewTextBoxColumn());

                // Definindo os nomes das colunas:

                dgv_cidades_estado.Columns[0].Name = "Cidade";

                // Permissões do usuário:

                dgv_cidades_estado.AllowUserToAddRows = false;

                dgv_cidades_estado.AllowUserToDeleteRows = false;

                dgv_cidades_estado.AllowUserToOrderColumns = true;

                // Estrutura do DataGridView:

                dgv_cidades_estado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgv_cidades_estado.ReadOnly = true;

            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {

            try
            {

                if (MessageBox.Show("Deseja voltar à tela inicial?", "Atenção!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    this.Close();

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private async void btn_buscar_Click(object sender, EventArgs e)
        {

            try
            {

                btn_buscar.Enabled = false;

                dgv_cidades_estado.Rows.Clear();

                List<Cidade> lista_cidades = await Data_Service.GetCidadesByUF(this.estados[cbbox_estado.SelectedIndex]);

                for (int i = 0; i < lista_cidades.Count; i++)
                {

                    if (lista_cidades[i].descricao != "")
                    {

                        dgv_cidades_estado.Rows.Add(lista_cidades[i].descricao);

                    }

                }

                btn_buscar.Enabled = true;

                btn_limpar.Enabled = true;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {

            try
            {

                if (dgv_cidades_estado.Rows.Count > 0)
                {

                    dgv_cidades_estado.Rows.Clear();

                }

                btn_limpar.Enabled = false;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }

}
