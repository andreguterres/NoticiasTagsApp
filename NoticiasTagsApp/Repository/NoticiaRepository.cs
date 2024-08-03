using Microsoft.EntityFrameworkCore;
using NoticiasTagsApp.Context;
using NoticiasTagsApp.Models;

namespace NoticiasTagsApp.Repository
{
    public class NoticiaRepository : INoticiaRepository
    {
        private readonly Contexto _context;

        public NoticiaRepository(Contexto context)
        {
            _context = context;
        }

        public async Task<Noticia> GetByIdAsync(int id)
        {
            return await _context.Noticias
                .Include(n => n.Usuario)
                .Include(n => n.NoticiaTags)
                    .ThenInclude(nt => nt.Tag)
                .FirstOrDefaultAsync(n => n.Id == id);
        }

        public async Task<IEnumerable<Noticia>> GetAllAsync()
        {
            return await _context.Noticias
                .Include(n => n.Usuario)
                .Include(n => n.NoticiaTags)
                    .ThenInclude(nt => nt.Tag)
                .ToListAsync();
        }

        public async Task AddAsync(Noticia noticia)
        {
            await _context.Noticias.AddAsync(noticia);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Noticia noticia)
        {
            _context.Noticias.Update(noticia);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var noticia = await GetByIdAsync(id);
            if (noticia != null)
            {
                _context.Noticias.Remove(noticia);
                await _context.SaveChangesAsync();
            }
        }
    }
}
