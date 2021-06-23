using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebCondominio.Residencial.Models
{
    public class Veiculo
    {
        [Key]
        public int IdVeiculo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Ano { get; set; }
        public string Cor { get; set; }
        public string Placa { get; set; }
    }
}
