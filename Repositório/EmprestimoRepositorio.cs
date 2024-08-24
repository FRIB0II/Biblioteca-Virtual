using Biblioteca_Virtual.Data;
using Biblioteca_Virtual.Repositório.Interfaces;

namespace Biblioteca_Virtual.Repositório
{
    public class EmprestimoRepositorio : IEmprestimoRepositorio
    {
        private readonly ContextDb _contextdb;

        public EmprestimoRepositorio(ContextDb contextdb)
        {
            _contextdb = contextdb;
        }
    }
}
