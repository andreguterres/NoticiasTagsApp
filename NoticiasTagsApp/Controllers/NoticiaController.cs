using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NoticiasTagsApp.Models;
using NoticiasTagsApp.Service;

namespace NoticiasTagsApp.Controllers
{
    public class NoticiaController : Controller
    {
        private readonly INoticiaService _noticiaService;

        public NoticiaController(INoticiaService noticiaService)
        {
            _noticiaService = noticiaService;
        }

        public async Task<IActionResult> Index()
        {
            var noticias = await _noticiaService.GetAllNoticiasAsync();
            return View(noticias);
        }

        public async Task<IActionResult> Details(int id)
        {
            var noticia = await _noticiaService.GetNoticiaByIdAsync(id);
            if (noticia == null)
            {
                return NotFound();
            }
            return View(noticia);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Noticia noticia)
        {
            if (ModelState.IsValid)
            {
                await _noticiaService.AddNoticiaAsync(noticia);
                return RedirectToAction(nameof(Index));
            }
            return View(noticia);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var noticia = await _noticiaService.GetNoticiaByIdAsync(id);
            if (noticia == null)
            {
                return NotFound();
            }
            return View(noticia);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Noticia noticia)
        {
            if (id != noticia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _noticiaService.UpdateNoticiaAsync(noticia);
                return RedirectToAction(nameof(Index));
            }
            return View(noticia);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var noticia = await _noticiaService.GetNoticiaByIdAsync(id);
            if (noticia == null)
            {
                return NotFound();
            }
            return View(noticia);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _noticiaService.DeleteNoticiaAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}