using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Domains
{
    public class FuncionarioDomain
    {
        public int idFuncionario { get; set; }

        [Required(ErrorMessage = "Esse campo não pode ficar vazio")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Esse campo não pode ficar vazio")]
        public string sobrenome { get; set; }

        [Required(ErrorMessage = "Esse campo não pode ficar vazio")]
        [DataType(DataType.Date)]
        public DateTime dataNascimento { get; set; }

    }
}
