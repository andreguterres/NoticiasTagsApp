using static NoticiasTagsApp.Models.Usuario;

namespace NoticiasTagsApp.Models
{
    public class Noticia
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }

        // Chave estrangeira
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        // Navegação
        public ICollection<NoticiaTag> NoticiaTags { get; set; }
    }

}
