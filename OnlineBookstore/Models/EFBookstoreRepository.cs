using System;
using System.Linq;

namespace OnlineBookstore.Models
{
    public class EFBookstoreRepository:IBookstoreRepository
    {
        private BookstoreDBContext _context;

        public EFBookstoreRepository(BookstoreDBContext context)
        {
            _context = context;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
