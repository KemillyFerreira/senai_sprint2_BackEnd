using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.inlock.webApi_.Domains;
using senai.inlock.webApi_.Interfaces;
using senai.inlock.webApi_.Repositories;
using System;
using System.Collections.Generic;

/// <summary>
/// controlador responsável pelos endopoints (url) referente ao genero
/// </summary>
namespace senai.inlock.webApi_.Conrtrollers
{
    //define que o tipo de resposta da API será em json
    [Produces("application/json")]

    //define que a rota seja dominio/api/nomeController - ex: http://localhost:5000/api/Genero
    [Route("api/[controller]")]

    //define que é um controllador de api
    [ApiController]


    public class JogoController : ControllerBase
    {
        private IJogoRepository _jogoRepository { get; set; }

        public JogoController()
        {
            _jogoRepository = new JogoRepository();
        }
        

        /// <summary>
        /// lista todos os jogos
        /// </summary>
        /// <returns> uma lista de jogos e um status code </returns>
       
        // o usuário precisa estar logado para listar todos os generos
        
        // verifica se o usuário está logado
       [Authorize] 
       [HttpGet]
       public IActionResult Get()
        {
            List<JogoDomain> listaJogo = _jogoRepository.ListarTodos();

            return Ok(listaJogo);
        }


        /// <summary>
        /// buscar pelo id
        /// </summary>
        /// <param name="id"> id do jogo </param>
        /// <returns> objeto jogoBuscado ou notFound caso não encontre </returns>
        /// somente um usuário administrador pode buscar um genero pelo id 
        
        [Authorize(Roles = "1")]
        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            JogoDomain jogoBuscado = _jogoRepository.BuscarPorId(id);

            if (jogoBuscado == null)
            {
                return NotFound("Nenhum jogo foi encontrado!");
            }
            return Ok(jogoBuscado);
        }


        /// <summary>
        /// cadastra um novo jogo
        /// </summary>
        /// <param name="novoJogo"> objeto recebido na requisição </param>
        /// <returns> um status code </returns>
        
        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(JogoDomain novoJogo)
        {
            _jogoRepository.Cadastrar(novoJogo);

            return StatusCode(201);
        }


        /// <summary>
        /// deleta um jogo
        /// </summary>
        /// <param name="id"> id do jogo que vai ser deletado </param>
        /// <returns> um status code 204 (NoContent) </returns>
        
        [Authorize(Roles = "1")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _jogoRepository.Deletar(id);

            return StatusCode(204);
        }


        /// <summary>
        /// atualiza um jogo
        /// </summary>
        /// <param name="id"> id do jogo </param>
        /// <param name="jogoAtualizado"> objeto que receberá as novas informações </param>
        /// <returns> retorna um status code </returns>
        
        [Authorize(Roles = "1")]
        [HttpPut("{id}")]
        public IActionResult PutUrl(int id, JogoDomain jogoAtualizado)
        {
            JogoDomain jogoBuscado = _jogoRepository.BuscarPorId(id);

            if (jogoBuscado == null)
            {
                return NotFound
                (new
                {
                    mensagem = "O Jogo não foi encontrado :(",
                    erro = "true"
                }
                );
            }

            try
            {
                _jogoRepository.AtualizarIdUrl(id, jogoAtualizado);

                return NoContent();
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }
    }
}
