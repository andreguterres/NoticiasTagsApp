using static NoticiasTagsApp.Models.NoticiaModel;
using static NoticiasTagsApp.Models.TagModel;

namespace NoticiasTagsApp.Models
{
    public class NoticiaTagModel
    {
            public int Id { get; set; }

            // Chave estrangeira para Noticia
            public int NoticiaId { get; set; }
            public NoticiaModel Noticia { get; set; }

            // Chave estrangeira para Tag
            public int TagId { get; set; }
           public TagModel Tag { get; set; }
        }

    }

