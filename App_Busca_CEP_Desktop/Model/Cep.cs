﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Busca_CEP_Desktop.Model
{

    public class Cep
    {

        public int id { get; set; }

        public int id_logradouro { get; set; }

        public string descricao { get; set; }

        public string complemento { get; set; }

        public string tipo { get; set; }

        public int id_cidade { get; set; }

        public string descricao_cidade { get; set; }

        public string codigo_ibge_cidade { get; set; }

        public string uf { get; set; }

        public string descricao_bairro { get; set; }

        public string descricao_sem_numero { get; set; }

        public string cep { get; set; }

    }

}
