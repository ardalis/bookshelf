using System.Collections.Generic;
using System.Linq;

namespace Library.API.Models
{
    public class Bookshelf : BaseEntity
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsPublic { get; set; }

        public List<BookshelfBook> Books { get; private set; } = new List<BookshelfBook>();

        public void AddBook(Book book) // this is good, but you haven't eliminated the ability for client code to do this directly on Books
                                       // more info: https://ardalis.com/encapsulated-collections-in-entity-framework-core
        {
            Books.Add(new BookshelfBook { Book = book });
            return;
        }

        public void RemoveBook(int bookId) // same as above
        {
            var book = Books.FirstOrDefault(b => b.BookId == bookId);
            if (book != null)
            {
                Books.Remove(book);
            }
        }

    }
}