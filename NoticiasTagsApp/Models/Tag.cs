namespace NoticiasTagsApp.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        // Navegação
        public ICollection<NoticiaTag> NoticiaTags { get; set; }
    }


}

