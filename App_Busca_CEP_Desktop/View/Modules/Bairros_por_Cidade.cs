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

    public partial class form_bairros_por_cidade : Form
    {

        public form_bairros_por_cidade()
        {

            InitializeComponent();

        }

        private void form_bairros_por_cidade_Load(object sender, EventArgs e)
        {

            try
            {

                this.Size = new Size(661, 561);

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }

}
