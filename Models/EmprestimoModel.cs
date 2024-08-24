namespace Biblioteca_Virtual.Models
{
    public class EmprestimoModel
    {
        public DateTime DataEmprestimo { get; set; }

        public int UsuarioId { get; set; }
        public UsuarioModel Usuario { get; set; }

        public int LivroId { get; set; }
        public LivroModel Livro { get; set; }
    }
}
