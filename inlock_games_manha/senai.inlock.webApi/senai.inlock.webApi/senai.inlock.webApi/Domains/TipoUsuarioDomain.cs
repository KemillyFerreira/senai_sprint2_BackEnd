using System.ComponentModel.DataAnnotations;


namespace senai.inlock.webApi_.Domains
{
    public class TipoUsuarioDomain
    {
        /// <summary>
        /// classe que representa a entidade dos tipos de usuario existente
        /// </summary>
        public int idTipoUsuario { get; set; }


        [Required(ErrorMessage = "Preencha o campo titulo")]
        public string titulo { get; set; }
    }
}
