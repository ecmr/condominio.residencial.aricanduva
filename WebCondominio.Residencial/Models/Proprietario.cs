using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebCondominio.Residencial.Models
{
    public class Proprietario
    {
        [Key]
        public int IdProprietario { get; set; }
        public string NumeroMatricula { get; set; }
    }
}
