using senai_filmes_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_filmes_webAPI.Interfaces
{
    /// <summary>
    /// interface responsável pelo repositório GeneroRepository
    /// </summary>
    public interface IGeneroRepository
    {
        // TIpoRetorno NomeMetodo (parâmetros);

        /// <summary>
        /// esse método retorna todos os generos
        /// </summary>
        /// <returns> uma lista de generos </returns>
        List<GeneroDomain> ListarTodos();

        /// <summary>
        /// busca um genero através do id
        /// </summary>
        /// <param name="id"> id do gnero que será buscado </param>
        /// <returns> um objeto do tipo GeneroDomain que foi buscado </returns>
        GeneroDomain BuscarPorId(int id);

        void Cadastrar(GeneroDomain novoGenero);

        /// <summary>
        /// atualiza um genero existente passando o id pelo corpo da requisição
        /// </summary>
        /// <param name="genero"> objeto genero com as novas informações </param>
        void AtualizarIdCorpo(GeneroDomain genero);

        /// <summary>
        /// atualiza um genero existenta passando o ID pela URL da requisição
        /// </summary>
        /// <param name="id"> id do genero que sera atualizado </param>
        /// <param name="genero"> objeto genero com as novas informações </param>
        void AtualizarIdUrl(int id, GeneroDomain genero);

        void Deletar(int id);
        
    }
}
