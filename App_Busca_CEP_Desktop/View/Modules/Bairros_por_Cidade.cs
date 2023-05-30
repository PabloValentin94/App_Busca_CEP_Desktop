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

    public partial class form_bairros_por_cidade : Form
    {

        string[] estados = { "AC", "AL", "AM", "AP", "BA", "CE", "DF",
                             "ES", "GO", "MA", "MG", "MS", "MT", "PA",
                             "PB", "PE", "PI", "PR", "RJ", "RN", "RO",
                             "RR", "RS", "SC", "SE", "SP", "TO"};

        public form_bairros_por_cidade()
        {

            InitializeComponent();

        }

        private void form_bairros_por_cidade_Load(object sender, EventArgs e)
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

                dgv_bairros_cidade.ForeColor = Color.Black;

                dgv_bairros_cidade.Columns.Clear();

                // Definição das colunas:

                dgv_bairros_cidade.Columns.Insert(0, new DataGridViewTextBoxColumn());

                /*dgv_bairros_cidade.Columns.Insert(1, new DataGridViewTextBoxColumn());

                dgv_bairros_cidade.Columns.Insert(2, new DataGridViewTextBoxColumn());*/

                // Definindo os nomes das colunas:

                dgv_bairros_cidade.Columns[0].Name = "Bairros:";

                /*dgv_bairros_cidade.Columns[1].Name = "Cidade";

                dgv_bairros_cidade.Columns[2].Name = "Estado";*/

                // Permissões do usuário:

                dgv_bairros_cidade.AllowUserToAddRows = false;

                dgv_bairros_cidade.AllowUserToDeleteRows = false;

                dgv_bairros_cidade.AllowUserToOrderColumns = true;

                // Estrutura do DataGridView:

                dgv_bairros_cidade.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgv_bairros_cidade.ReadOnly = true;

            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private bool Verificacao_Valor_Campo(string texto)
        {

            if(String.IsNullOrEmpty(texto))
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

                List<Cidade> lista_cidades_revisada = new List<Cidade>();

                for(int i = 0; i< lista_cidades.Count; i++)
                {

                    if(!String.IsNullOrEmpty(lista_cidades[i].descricao))
                    {

                        lista_cidades_revisada.Add(lista_cidades[i]);

                    }

                }

                cbbox_cidade.DisplayMember = "descricao";

                cbbox_cidade.ValueMember = "id_cidade";

                cbbox_cidade.DataSource = lista_cidades_revisada;

                btn_buscar.Enabled = true;

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

                if(MessageBox.Show("Deseja voltar à tela inicial?", "Atenção!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    this.Close();

                }

            }

            catch(Exception ex)
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

                if(Verificacao_Valor_Campo(cbbox_estado.Text) && Verificacao_Valor_Campo(cbbox_cidade.Text))
                {

                    dgv_bairros_cidade.Rows.Clear();

                    //string cidade = cbbox_cidade.SelectedText, estado = cbbox_estado.SelectedText;

                    List<Bairro> lista_bairros = await Data_Service.GetBairrosByIDCidade((int)cbbox_cidade.SelectedValue);

                    if(lista_bairros.Count > 0)
                    {

                        for(int i = 0; i < lista_bairros.Count; i++)
                        {

                            if(lista_bairros[i].descricao_bairro != "")
                            {

                                dgv_bairros_cidade.Rows.Add(lista_bairros[i].descricao_bairro/*, cidade, estado*/);

                            }

                        }

                    }

                    else
                    {

                        MessageBox.Show("Nenhum registro encontrado no sistema! Tente outro valor.",
                                        "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }

                else
                {

                    MessageBox.Show("Preencha todos os campos corretamente antes de prosseguir.",
                                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }

            catch(Exception ex)
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

                if(dgv_bairros_cidade.Rows.Count > 0)
                {

                    dgv_bairros_cidade.Rows.Clear();

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
