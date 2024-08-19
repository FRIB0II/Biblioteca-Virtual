using Biblioteca_Virtual.Models;

namespace Biblioteca_Virtual.Repositório.Interfaces
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel Adicionar(UsuarioModel usuario);

        UsuarioModel BuscarPorId(int id);

        UsuarioModel Atualizar(UsuarioModel usuario);

        bool Deletar(int id);
    }
}
