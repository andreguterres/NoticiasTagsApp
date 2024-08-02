namespace NoticiasTagsApp.Models
{
    public class TagModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        // Relacionamento N:N com Noticia através de NoticiaTag
        public ICollection<NoticiaTagModel> NoticiaTags { get; set; }
    }

}

