using Microsoft.EntityFrameworkCore;
using NoticiasTagsApp.Context;
using NoticiasTagsApp.Models;

namespace NoticiasTagsApp.Repository
{
    public class TagRepository : ITagRepository
    {
        private readonly Contexto _context;

        public TagRepository(Contexto context)
        {
            _context = context;
        }

        public async Task<Tag> GetByIdAsync(int id)
        {
            return await _context.Tags
                .Include(t => t.NoticiaTags)
                    .ThenInclude(nt => nt.Noticia)
                .FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<IEnumerable<Tag>> GetAllAsync()
        {
            return await _context.Tags
                .Include(t => t.NoticiaTags)
                    .ThenInclude(nt => nt.Noticia)
                .ToListAsync();
        }

        public async Task AddAsync(Tag tag)
        {
            await _context.Tags.AddAsync(tag);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Tag tag)
        {
            _context.Tags.Update(tag);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var tag = await GetByIdAsync(id);
            if (tag != null)
            {
                _context.Tags.Remove(tag);
                await _context.SaveChangesAsync();
            }
        }
    }
}