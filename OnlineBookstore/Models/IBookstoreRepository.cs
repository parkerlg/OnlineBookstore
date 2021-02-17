using System;
using System.Linq;

namespace OnlineBookstore.Models
{
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get; }
    }

}
