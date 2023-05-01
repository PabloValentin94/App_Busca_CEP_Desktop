using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Busca_CEP_Desktop
{

    public partial class frm_principal : Form
    {

        public frm_principal()
        {

            InitializeComponent();

            this.Size = this.MinimumSize;

        }

        private void Principal_Load(object sender, EventArgs e)
        {

            Ocultar_Submenus();

        }

        private void Ocultar_Submenus()
        {

            pn_submenu_opcoes.Visible = false;

            pn_submenu_sobre.Visible = false;

        }

        private void Visualizacao_Submenus(Panel submenu)
        {

            if(submenu.Visible)
            {

                submenu.Visible = false;

            }

            else
            {

                Ocultar_Submenus();

                submenu.Visible = true;

            }

        }

        private void btn_opcoes_Click(object sender, EventArgs e)
        {

            Visualizacao_Submenus(pn_submenu_opcoes);

        }

        private void btn_sobre_Click(object sender, EventArgs e)
        {

            Visualizacao_Submenus(pn_submenu_sobre);

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Realmente deseja encerrar a aplicação?", "Atenção!", 
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                Application.Exit();

            }

        }

    }

}