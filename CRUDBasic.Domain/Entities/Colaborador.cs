using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDBasic.Domain.Entities
{
    public class Colaborador
    {
        public int ColaboradorId { get; set; }
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public string Pis { get; set; }
        public string Cpf { get; set; }
        public bool Estrangeiro { get; set; }
        public string Observacao { get; set; }
        public bool Ativo { get; set; }
        public string RG { get; set; }
        public string Passaporte { get; set; }        
        public string Sexo { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
