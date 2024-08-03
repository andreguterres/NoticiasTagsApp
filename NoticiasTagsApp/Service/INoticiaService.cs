using NoticiasTagsApp.Models;

namespace NoticiasTagsApp.Service
{
    public interface INoticiaService
    {
        Task<Noticia> GetNoticiaByIdAsync(int id);
        Task<IEnumerable<Noticia>> GetAllNoticiasAsync();
        Task AddNoticiaAsync(Noticia noticia);
        Task UpdateNoticiaAsync(Noticia noticia);
        Task DeleteNoticiaAsync(int id);
    }
}
