using static NoticiasTagsApp.Models.Noticia;
using static NoticiasTagsApp.Models.Tag;

namespace NoticiasTagsApp.Models
{
    public class NoticiaTag
    {
        public int Id { get; set; }

        // Chaves estrangeiras
        public int NoticiaId { get; set; }
        public Noticia Noticia { get; set; }

        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }



}

