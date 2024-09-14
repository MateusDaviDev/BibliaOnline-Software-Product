using BibliaOnline.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BibliaOnline.Services;

public class BibliaService:IBibliaService
{
 //Private readonly IBibliaService _biblia;

    public async Task<DetailsCapModel> GetBook(string livro,string? capitulos,[FromRoute] string capitulo)
    {
        var capituloo = capitulo;
        var url = "https://www.abibliadigital.com.br/api/verses/nvi/"+livro+"/"+capituloo;
        var client = new HttpClient();
        var response = await client.GetAsync(url);
        var content = await response.Content.ReadAsStringAsync();
        var livros = JsonConvert.DeserializeObject<DetailsCapModel>(content);
        return livros;
    }
    
 
    
     public  async Task<List<BookModel>> GetBooks()
    {
        var url = "https://www.abibliadigital.com.br/api/books/";
        var client = new HttpClient();
        var response = await client.GetAsync(url);
        var content = await response.Content.ReadAsStringAsync();
        var livros = JsonConvert.DeserializeObject<List<BookModel>>(content);
        return livros;
    }

    public async Task<RondomVerseDto> GetRondomVerse()
    {
        var url = "https://www.abibliadigital.com.br/api/verses/nvi/random";
        var client = new HttpClient();
        var response = await client.GetAsync(url);
        var content = await response.Content.ReadAsStringAsync();
        var versiculo = JsonConvert.DeserializeObject<RondomVerseDto>(content);
        return versiculo;
    }
     
     
}

