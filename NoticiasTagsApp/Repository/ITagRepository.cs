using NoticiasTagsApp.Models;

namespace NoticiasTagsApp.Repository
{
    public interface ITagRepository
    {
        Task<Tag> GetByIdAsync(int id);
        Task<IEnumerable<Tag>> GetAllAsync();
        Task AddAsync(Tag tag);
        Task UpdateAsync(Tag tag);
        Task DeleteAsync(int id);
    }
}
