using Mangas.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Mangas.Services.Features.Mangas
{
    public class MangaService
    {
        private readonly List<Manga> _mangas = new List<Manga>();

        public IEnumerable<Manga> GetAll() => _mangas;

        public Manga GetById(int id) => _mangas.FirstOrDefault(m => m.Id == id);

        public void Add(Manga manga) => _mangas.Add(manga);

        public void Update(Manga updatedManga)
        {
            var manga = _mangas.FirstOrDefault(m => m.Id == updatedManga.Id);
            if (manga != null)
            {
                manga.Title = updatedManga.Title;
                manga.Author = updatedManga.Author;
                manga.Volume = updatedManga.Volume;
            }
        }

        public void Delete(int id) => _mangas.RemoveAll(m => m.Id == id);
    }
}
