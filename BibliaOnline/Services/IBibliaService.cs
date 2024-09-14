using Microsoft.AspNetCore.Mvc;
using BibliaOnline.Models;

namespace BibliaOnline.Services;

public interface IBibliaService
{
    Task<DetailsCapModel> GetBook(string livro, string capitulos,string capitulo);
  

    Task<List<BookModel>> GetBooks();

    Task<RondomVerseDto> GetRondomVerse();
}