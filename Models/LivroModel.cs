namespace Biblioteca_Virtual.Models
{
    public class LivroModel
    {
        public int Id { get; set; }
        public string NomeLivro { get; set; }
        public string NomeAutor { get; set; }
        public string DataPublicacao { get; set; }

        public int EmprestimoId { get; set; }
        public EmprestimoModel Emprestimo { get; set; }
    }
}
