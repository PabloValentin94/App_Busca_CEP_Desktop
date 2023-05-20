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

    public partial class form_endereco_pelo_cep : Form
    {

        public form_endereco_pelo_cep()
        {

            InitializeComponent();

        }

        private void form_endereco_pelo_cep_Load(object sender, EventArgs e)
        {

            try
            {

                this.Size = new Size(661, 561);

                btn_limpar.Enabled = false;

            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Limpar_Textos()
        {

            try
            {

                txt_logradouro.Clear();

                txt_tipo.Clear();

                txt_bairro.Clear();

                txt_cidade.Clear();

                txt_codigo_ibge.Clear();

                txt_estado.Clear();

                txt_pais.Clear();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Associar_Endereco_Campos(Endereco endereco_requisitado)
        {

            txt_logradouro.Text = endereco_requisitado.descricao;

            txt_tipo.Text = endereco_requisitado.tipo;

            txt_bairro.Text = endereco_requisitado.descricao_bairro;

            txt_cidade.Text = endereco_requisitado.descricao_cidade;

            txt_codigo_ibge.Text = endereco_requisitado.codigo_cidade_ibge;

            txt_estado.Text = endereco_requisitado.UF;

            // Como enganar o usuário usando o back-end:

            txt_pais.Text = "Brasil";

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

                Limpar_Textos();

                msktxt_cep.Mask = "";

                Endereco endereco = await Data_Service.GetEnderecoByCep(msktxt_cep.Text);

                msktxt_cep.Mask = "##,###-###";

                Associar_Endereco_Campos(endereco);

                btn_limpar.Enabled = true;

                btn_buscar.Enabled = true;

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

                msktxt_cep.Clear();

                Limpar_Textos();

                btn_limpar.Enabled = false;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }

}
