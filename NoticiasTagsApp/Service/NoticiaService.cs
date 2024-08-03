using NoticiasTagsApp.Models;
using NoticiasTagsApp.Repository;

namespace NoticiasTagsApp.Service
{
    public class NoticiaService : INoticiaService
    {
        private readonly INoticiaRepository _noticiaRepository;

        public NoticiaService(INoticiaRepository noticiaRepository)
        {
            _noticiaRepository = noticiaRepository;
        }

        public async Task<Noticia> GetNoticiaByIdAsync(int id)
        {
            return await _noticiaRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Noticia>> GetAllNoticiasAsync()
        {
            return await _noticiaRepository.GetAllAsync();
        }

        public async Task AddNoticiaAsync(Noticia noticia)
        {
            await _noticiaRepository.AddAsync(noticia);
        }

        public async Task UpdateNoticiaAsync(Noticia noticia)
        {
            await _noticiaRepository.UpdateAsync(noticia);
        }

        public async Task DeleteNoticiaAsync(int id)
        {
            await _noticiaRepository.DeleteAsync(id);
        }
    }
}