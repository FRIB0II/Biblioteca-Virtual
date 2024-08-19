using Biblioteca_Virtual.Data;
using Biblioteca_Virtual.Models;

namespace Biblioteca_Virtual.Repositório.Interfaces
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly ContextDb _contextdb;

        public UsuarioRepositorio(ContextDb contextdb)
        {
            _contextdb = contextdb;
        }

        public UsuarioModel Adicionar(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        public UsuarioModel Atualizar(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        public UsuarioModel BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Deletar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
