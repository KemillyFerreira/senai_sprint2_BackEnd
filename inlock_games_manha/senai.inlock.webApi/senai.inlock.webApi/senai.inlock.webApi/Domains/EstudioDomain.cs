using System.ComponentModel.DataAnnotations;


namespace senai.inlock.webApi_.Domains
{
    public class EstudioDomain
    {
        /// <summary>
        /// classe que representa a entidade estudio
        /// </summary>
        
        public int idEstudio { get; set; }
        
        [Required(ErrorMessage = "O nome do estudio é obrigatório!")]

        public string nomeEstudio { get; set; }
    }
}
