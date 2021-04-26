using System.ComponentModel.DataAnnotations;

namespace senai.inlock.webApi_.Domains
{
    public class UsuarioDomain
    {
        /// <summary>
        /// classe que representa a entidade usuário
        /// </summary>
        public int idUsuario { get; set; }

      
        [Required(ErrorMessage = "O campo email é obrigatório")]
        [DataType(DataType.EmailAddress)]

        public string email { get; set; }


        [Required(ErrorMessage = "O campo senha é obrigatório")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "A senha deve conter no minimo 3 caracteres")]

        public string senha { get; set; }


        [Required(ErrorMessage = "O campo tipo de usuario é obrigatório")]
        public int idTipoUsuario { get; set; }
    }
}
