﻿namespace Biblioteca_Virtual.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Senha{ get; set; }
        public string Celular { get; set; }

        public int EmprestimoId { get; set; }
        public ICollection<EmprestimoModel> Emprestimo { get; set; }
    }
}
