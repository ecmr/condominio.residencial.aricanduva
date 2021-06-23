using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebCondominio.Residencial.Models
{
    public class Morador
    {
        [Key]
        public int IdMorador { get; set; }
        public string Bloco { get; set; }
        public string Apartamento { get; set; }
        public Pessoa Pessoa { get; set; }
        public Proprietario Proprietario { get; set; }
        public Inquilino Inquilino { get; set; }
        public List<Veiculo> Veiculos { get; set; }
    }
}
