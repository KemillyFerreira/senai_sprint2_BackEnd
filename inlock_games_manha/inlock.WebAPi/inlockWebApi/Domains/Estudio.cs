using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace inlock_games_manha.Domains
{
    public partial class Estudio
    {
        public Estudio()
        {
            Jogos = new HashSet<Jogo>();
        }

        public int IdEstudio { get; set; }

        [Required(ErrorMessage = "O nome do estudio é obrigatório!")]


        public string NomeEstudio { get; set; }

        public virtual ICollection<Jogo> Jogos { get; set; }
    }
}
