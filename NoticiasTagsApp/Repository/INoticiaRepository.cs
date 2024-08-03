using NoticiasTagsApp.Models;

namespace NoticiasTagsApp.Repository
{
    public interface INoticiaRepository
    {
        Task<Noticia> GetByIdAsync(int id);
        Task<IEnumerable<Noticia>> GetAllAsync();
        Task AddAsync(Noticia noticia);
        Task UpdateAsync(Noticia noticia);
        Task DeleteAsync(int id);
    }
}
