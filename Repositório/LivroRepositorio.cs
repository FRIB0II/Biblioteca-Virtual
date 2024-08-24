using Biblioteca_Virtual.Data;
using Biblioteca_Virtual.Repositório.Interfaces;

namespace Biblioteca_Virtual.Repositório
{
    public class LivroRepositorio : ILivroRepositorio
    {
        private readonly ContextDb _contextdb;

        public LivroRepositorio(ContextDb contextdb)
        {
            _contextdb = contextdb;
        }
    }
}
