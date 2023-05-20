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

    public partial class form_ceps_por_logradouro : Form
    {

        public form_ceps_por_logradouro()
        {

            InitializeComponent();

        }

        private void form_ceps_por_logradouro_Load(object sender, EventArgs e)
        {

            try
            {

                this.Size = new Size(661, 561);

                Configuracao_DataGridView();

                btn_limpar.Enabled = false;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Configuracao_DataGridView()
        {

            try
            {

                dgv_ceps_logradouro.ForeColor = Color.Black;

                dgv_ceps_logradouro.Rows.Clear();

                // Definição das colunas:

                dgv_ceps_logradouro.Columns.Insert(0, new DataGridViewTextBoxColumn());

                //dgv_ceps_logradouro.Columns.Insert(1, new DataGridViewTextBoxColumn());

                // Definindo os nomes das colunas:

                dgv_ceps_logradouro.Columns[0].Name = "C.E.P.";

                //dgv_ceps_logradouro.Columns[1].Name = "Número";

                // Permissões do usuário:

                dgv_ceps_logradouro.AllowUserToAddRows = false;

                dgv_ceps_logradouro.AllowUserToDeleteRows = false;

                dgv_ceps_logradouro.AllowUserToOrderColumns = true;

                // Estrutura do DataGridView:

                dgv_ceps_logradouro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgv_ceps_logradouro.ReadOnly = true;

            }

            catch (Exception ex)
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

                if(String.IsNullOrEmpty(txt_logradouro.Text))
                {

                    MessageBox.Show("Preencha o campo antes de prosseguir.", "Atenção!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                else
                {

                    btn_buscar.Enabled = false;

                    dgv_ceps_logradouro.Rows.Clear();

                    List<Cep> lista_ceps = await Data_Service.GetCepsByLogradouro(txt_logradouro.Text);

                    //int indice = 1;

                    for (int i = 0; i < lista_ceps.Count; i++)
                    {

                        if (lista_ceps[i].cep != "")
                        {

                            string[] digitos_cep = new string[8];

                            for (int j = 0; j <= 7; j++)
                            {

                                digitos_cep[j] = lista_ceps[i].cep[j].ToString();

                            }

                            string cep_formatado = digitos_cep[0] + digitos_cep[1] + "." +
                                                   digitos_cep[2] + digitos_cep[3] + digitos_cep[4] +
                                                   "-" + digitos_cep[5] + digitos_cep[6] + digitos_cep[7];

                            dgv_ceps_logradouro.Rows.Add(cep_formatado);

                            //indice++;

                        }

                    }

                    btn_buscar.Enabled = true;

                    btn_limpar.Enabled = true;

                }

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

                txt_logradouro.Clear();

                if (dgv_ceps_logradouro.Rows.Count > 0)
                {

                    dgv_ceps_logradouro.Rows.Clear();

                }

                btn_limpar.Enabled = false;

            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }

}
