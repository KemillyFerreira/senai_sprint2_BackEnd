using System;
using System.ComponentModel.DataAnnotations;


namespace senai.inlock.webApi_.Domains
{
    public class JogoDomain
    {
        /// <summary>
        /// classe que representa a entidade jogos
        /// </summary>
        public int idJogo { get; set; }

        [Required(ErrorMessage = "O nome do jogo é obrigatório")]

        public string nome { get; set; }

        public string descricao { get; set; }


        [DataType(DataType.Date)]
        public string dataLancamento { get; set; }


        [Required(ErrorMessage = "O valor do jogo deve ser preenchido")]
        public int valor { get; set; }

        public int idEstudio { get; set; }
    }
}
