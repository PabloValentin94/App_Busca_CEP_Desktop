using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Busca_CEP_Desktop.Model
{

    public class Cidade
    {

        public int id_cidade { get; set; }

        public string descricao { get; set; }

        public string uf { get; set; }

        public int codigo_ibge { get; set; }

        public int ddd { get; set; }

    }

}
