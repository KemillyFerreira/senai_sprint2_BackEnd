using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi_.Domains
{
    public class TipoUsuarioDomain
    {
        public int idTipoUsuario { get; set; }
        [Required(ErrorMessage = "Preencha o campo titulo")]

        public string titulo { get; set; }
    }
}
