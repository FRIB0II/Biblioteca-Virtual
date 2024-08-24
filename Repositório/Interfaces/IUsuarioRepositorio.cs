using Biblioteca_Virtual.Models;

namespace Biblioteca_Virtual.Repositório.Interfaces
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel Adicionar(UsuarioModel usuario);

        UsuarioModel BuscarPorId(int Id);

        UsuarioModel BuscarPorEmailESenha(string Email, string Senha);

        UsuarioModel Atualizar(UsuarioModel usuario);

        bool Deletar(int Id);
    }
}
