using System.Collections.Generic;
using System.Threading.Tasks;
using Library.API.Models;

namespace Library.API.Core.Interfaces
{
    public interface IBookCategoryService
    {
         Task<List<BookCategory>> AddCategoriesFromBook(List<string> categories, Book book);
    }
}