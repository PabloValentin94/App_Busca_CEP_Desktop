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

    public partial class form_logradouros_por_bairro : Form
    {

        string[] estados = { "AC", "AL", "AM", "AP", "BA", "CE", "DF",
                             "ES", "GO", "MA", "MG", "MS", "MT", "PA",
                             "PB", "PE", "PI", "PR", "RJ", "RN", "RO",
                             "RR", "RS", "SC", "SE", "SP", "TO"};

        public form_logradouros_por_bairro()
        {

            InitializeComponent();

        }

        private void form_logradouros_por_bairro_Load(object sender, EventArgs e)
        {

            try
            {

                this.Size = new Size(661, 561);

                Configuracao_DataGridView();

                cbbox_estado.DataSource = this.estados;

                btn_buscar.Enabled = false;

                btn_limpar.Enabled = false;

                /* Impedindo que o usuário digite nos ComboBoxes, podendo
                 * apenas escolher as opções do seu respectivo menu de contexto. */

                cbbox_estado.DropDownStyle = ComboBoxStyle.DropDownList;

                cbbox_cidade.DropDownStyle = ComboBoxStyle.DropDownList;

                cbbox_bairro.DropDownStyle = ComboBoxStyle.DropDownList;

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

                dgv_logradouros_bairro.ForeColor = Color.Black;

                // Definição das colunas:

                dgv_logradouros_bairro.Columns.Insert(0, new DataGridViewTextBoxColumn());

                // Definindo os nomes das colunas:

                dgv_logradouros_bairro.Columns[0].Name = "Logradouro";

                // Permissões do usuário:

                dgv_logradouros_bairro.AllowUserToAddRows = false;

                dgv_logradouros_bairro.AllowUserToDeleteRows = false;

                dgv_logradouros_bairro.AllowUserToOrderColumns = true;

                // Estrutura do DataGridView:

                dgv_logradouros_bairro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgv_logradouros_bairro.ReadOnly = true;

            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private bool Verificacao_Valor_Campo(string texto)
        {

            if (String.IsNullOrEmpty(texto))
            {

                return false;

            }

            else
            {

                return true;

            }

        }

        private async void cbbox_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                btn_buscar.Enabled = false;

                btn_limpar.Enabled = false;

                List<Cidade> lista_cidades = await Data_Service.GetCidadesByUF(this.estados[cbbox_estado.SelectedIndex]);

                cbbox_cidade.DisplayMember = "descricao";

                cbbox_cidade.ValueMember = "id_cidade";

                cbbox_cidade.DataSource = lista_cidades;

                btn_buscar.Enabled = true;

                btn_limpar.Enabled = true;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private async void cbbox_cidade_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                btn_buscar.Enabled = false;

                btn_limpar.Enabled = false;

                List<Bairro> lista_bairros = await Data_Service.GetBairrosByIDCidade((int) cbbox_cidade.SelectedValue);

                cbbox_bairro.DisplayMember = "descricao_bairro";

                cbbox_bairro.ValueMember = "descricao_bairro";

                cbbox_bairro.DataSource = lista_bairros;

                btn_buscar.Enabled = true;

                btn_limpar.Enabled = true;

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

                btn_buscar.Enabled = false;

                btn_limpar.Enabled = false;

                if(Verificacao_Valor_Campo(cbbox_estado.Text) &&
                   Verificacao_Valor_Campo(cbbox_cidade.Text) &&
                   Verificacao_Valor_Campo(cbbox_bairro.Text))
                {

                    dgv_logradouros_bairro.Rows.Clear();

                    List<Logradouro> lista_logradouros =
                    await Data_Service.GetLogradourosByBairroAndIDCidade(
                    cbbox_bairro.Text, (int)cbbox_cidade.SelectedValue);

                    for (int i = 0; i < lista_logradouros.Count; i++)
                    {

                        if (lista_logradouros[i].descricao != "")
                        {

                            dgv_logradouros_bairro.Rows.Add(lista_logradouros[i].descricao);

                        }

                    }

                }

                else
                {

                    MessageBox.Show("Preencha todos os campos corretamente antes de prosseguir.",
                                    "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            finally
            {

                btn_buscar.Enabled = true;

                btn_limpar.Enabled = true;

            }

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {

            try
            {

                if (dgv_logradouros_bairro.Rows.Count > 0)
                {

                    dgv_logradouros_bairro.Rows.Clear();

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
