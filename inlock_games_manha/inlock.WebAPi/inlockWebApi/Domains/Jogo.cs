using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace inlock_games_manha.Domains
{
    public partial class Jogo
    {
        public int IdJogo { get; set; }
        [Required(ErrorMessage = "O nome do jogo é obrigatório")]

        public string NomeJogo { get; set; }

        public string Descricao { get; set; }
       
        [DataType(DataType.Date)]


        public DateTime DataLancamento { get; set; }

        [Required(ErrorMessage = "O valor do jogo deve ser preenchido")]

        public int Valor { get; set; }

        public int? IdEstudio { get; set; }


        public virtual Estudio IdEstudioNavigation { get; set; }
    }
}
