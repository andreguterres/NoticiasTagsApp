namespace NoticiasTagsApp.Models
{
    public class UsuarioModel
    {     
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Senha { get; set; }
            public string Email { get; set; }

            // Relacionamento 1:N com Noticia
            public ICollection<NoticiaModel> Noticias { get; set; }
        

    }
}
