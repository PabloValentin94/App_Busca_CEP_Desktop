using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using App_Busca_CEP_Desktop.View.Modules;

namespace App_Busca_CEP_Desktop
{

    public partial class form_principal : Form
    {

        private Form formulario_externo = null;

        public form_principal()
        {

            InitializeComponent();

        }

        private void Principal_Load(object sender, EventArgs e)
        {

            try
            {

                this.Size = new Size(900, 600);

                Ocultar_Submenus();

            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Ocultar_Submenus()
        {

            try
            {

                pn_submenu_opcoes.Visible = false;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Visualizacao_Submenus(Panel submenu)
        {

            try
            {

                if (submenu.Visible)
                {

                    submenu.Visible = false;

                }

                else
                {

                    Ocultar_Submenus();

                    submenu.Visible = true;

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Associar_Panel_Form_Externo(Form formulario_requisitado)
        {

            if(this.formulario_externo != null)
            {

                this.formulario_externo.Close();

            }

            // Formulário:

            this.formulario_externo = formulario_requisitado;

            this.formulario_externo.TopLevel = false;

            this.formulario_externo.FormBorderStyle = FormBorderStyle.None;

            this.formulario_externo.Dock = DockStyle.Fill;

            // Painel:

            pn_form_externo.Controls.Add(this.formulario_externo);

            pn_form_externo.Tag = this.formulario_externo;

            this.formulario_externo.BringToFront();

            this.formulario_externo.Show();

        }

        private void btn_opcoes_Click(object sender, EventArgs e)
        {

            try
            {

                Visualizacao_Submenus(pn_submenu_opcoes);

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {

            try
            {

                if (MessageBox.Show("Realmente deseja encerrar a aplicação?", "Atenção!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Application.Exit();

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_form_endereco_Click(object sender, EventArgs e)
        {

            try
            {

                Ocultar_Submenus();

                //Associar_Panel_Form_Externo();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_form_cidades_por_estado_Click(object sender, EventArgs e)
        {

            try
            {

                Ocultar_Submenus();

                Associar_Panel_Form_Externo(new form_cidades_por_estado());

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_form_ceps_por_logradouro_Click(object sender, EventArgs e)
        {

            try
            {

                Ocultar_Submenus();

                Associar_Panel_Form_Externo(new form_ceps_por_logradouro());

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_form_bairros_por_cidade_Click(object sender, EventArgs e)
        {

            try
            {

                Ocultar_Submenus();

                Associar_Panel_Form_Externo(new form_bairros_por_cidade());

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_form_logradouros_por_bairro_Click(object sender, EventArgs e)
        {

            try
            {

                Ocultar_Submenus();

                //Associar_Panel_Form_Externo();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }

}