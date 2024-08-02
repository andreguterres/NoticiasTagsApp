using static NoticiasTagsApp.Models.UsuarioModel;

namespace NoticiasTagsApp.Models
{
    public class NoticiaModel
    {
            public int Id { get; set; }
            public string Titulo { get; set; }
            public string Texto { get; set; }

            // Chave estrangeira para Usuario
            public int UsuarioId { get; set; }
            public UsuarioModel Usuario { get; set; }

            // Relacionamento N:N com Tag através de NoticiaTag
            public ICollection<NoticiaTagModel> NoticiaTags { get; set; }
        

    }
}
