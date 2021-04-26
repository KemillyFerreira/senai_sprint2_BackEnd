using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_filmes_webAPI.Domains
{
    public class FilmeDomain
    {
        /// <summary>
        /// classe que representa a entidade Filmes
        /// </summary>
        public int idFilme { get; set; }
        public string titulo { get; set; }
        public int idGenero { get; set; }
    }
}
