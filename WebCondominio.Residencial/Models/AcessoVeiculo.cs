using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebCondominio.Residencial.Models
{
    public class AcessoVeiculo
    {
        [Key]
        public int IdAcessoVeiculo { get; set; }

        /// <summary>
        /// Registrar a TAG do Sem Parar 
        /// </summary>
        public string RegistroAcesso { get; set; }

        public Veiculo Veiculo { get; set; }
    }
}
