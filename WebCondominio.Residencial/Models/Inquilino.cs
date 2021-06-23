using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebCondominio.Residencial.Models
{
    public class Inquilino
    {
        [Key]
        public int IdInquilino { get; set; }
        public string NumeroContrato { get; set; }
    }
}
