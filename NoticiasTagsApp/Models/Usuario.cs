namespace NoticiasTagsApp.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }

        // Navegação
        public ICollection<Noticia> Noticias { get; set; }
    }

}
