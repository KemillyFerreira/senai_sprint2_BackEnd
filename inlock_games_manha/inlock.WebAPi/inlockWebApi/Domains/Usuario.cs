using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace inlock_games_manha.Domains
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }

        public string Email { get; set; }

        [Required(ErrorMessage = "O campo email é obrigatório")]
        [DataType(DataType.EmailAddress)]

        public string Senha { get; set; }

        [Required(ErrorMessage = "O campo senha é obrigatório")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "A senha deve conter no minimo 3 caracteres")]

        public int? IdTipoUsuario { get; set; }

        [Required(ErrorMessage = "O campo tipo de usuario é obrigatório")]

        public virtual TipoUsuario IdTipoUsuarioNavigation { get; set; }
    }
}
