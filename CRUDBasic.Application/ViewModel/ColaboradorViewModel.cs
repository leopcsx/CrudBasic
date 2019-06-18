using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDBasic.Application.ViewModel
{
    public class ColaboradorViewModel
    {
        [Key]
        public int ColaboradorId { get; set; }

        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        public string Matricula { get; set; }

        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        public string Nome { get; set; }

        [MaxLength(11, ErrorMessage = "Máximo {0} caracteres")]
        public string Pis { get; set; }

        [MaxLength(11, ErrorMessage = "Máximo {0} caracteres")]
        public string Cpf { get; set; }

        public bool Estrangeiro { get; set; }
        public string Observacao { get; set; }
        public bool Ativo { get; set; }
        public string RG { get; set; }
        public string Passaporte { get; set; }

        [MaxLength(1, ErrorMessage = "Máximo {0} caracteres")]
        public string Sexo { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
