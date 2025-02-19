using BookShoppingCartMvcUI.Models;

using Microsoft.EntityFrameworkCore;
namespace EBookStore.Repositories
{
    public class HomeRepository : IHomeRepository
    {
        private readonly ApplicationDbContext _db;

        public HomeRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Genre>> Genres()
        {
            return await _db.Genres.ToListAsync();
        }
        public async Task<IEnumerable<Book>> GetBooks(string sTerm = "", int genreId = 0)
        {
            sTerm = sTerm?.ToLower() ?? "";  // Ensure sTerm is not null

            var books = await (from book in _db.Books
                               join genre in _db.Genres
                               on book.GenreId equals genre.Id
                               where (string.IsNullOrWhiteSpace(sTerm) || book.BookName.ToLower().StartsWith(sTerm))
                                     && (genreId == 0 || book.GenreId == genreId)  // ✅ Ensure genre filtering works
                               select new Book
                               {
                                   Id = book.Id,
                                   Image = book.Image,
                                   AuthorName = book.AuthorName,
                                   BookName = book.BookName,
                                   GenreId = book.GenreId,
                                   Price = book.Price,
                                   GenreName = genre.GenreName
                               }).ToListAsync();

            return books;
        }

    }
}
