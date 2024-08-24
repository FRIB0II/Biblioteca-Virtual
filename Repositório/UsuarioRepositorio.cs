using Biblioteca_Virtual.Data;
using Biblioteca_Virtual.Models;
using Biblioteca_Virtual.Repositório.Interfaces;

namespace Biblioteca_Virtual.Repositório
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
            _contextdb.Add(usuario);
            _contextdb.SaveChanges();

            return usuario;
        }

        public UsuarioModel BuscarPorId(int Id)
        {
            UsuarioModel usuario = _contextdb.Usuarios.FirstOrDefault(x => x.Id == Id);
            
            return usuario;
        }

        public UsuarioModel BuscarPorEmailESenha(string Email, string Senha)
        {   
            UsuarioModel usuario = _contextdb.Usuarios.FirstOrDefault(x => x.Email == Email && x.Senha == Senha);

            return usuario;
        }

        public UsuarioModel Atualizar(UsuarioModel usuario)
        {
            UsuarioModel usuarioDb = BuscarPorId(usuario.Id);

            usuarioDb.Nome = usuario.Nome;
            usuarioDb.Sobrenome = usuario.Sobrenome;
            usuarioDb.Email = usuario.Email;
            usuarioDb.Senha = usuario.Senha;
            usuarioDb.Celular = usuario.Celular;

            _contextdb.Update(usuarioDb);
            _contextdb.SaveChanges();

            return usuario;

        }

        public bool Deletar(int Id)
        {
            UsuarioModel usuarioDb = BuscarPorId(Id);
            
            _contextdb.Remove(usuarioDb);
            _contextdb.SaveChanges();

            return true;
        }
    }
}
