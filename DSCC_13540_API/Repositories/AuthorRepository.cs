using DSCC_13540_API.Data;
using DSCC_13540_API.Interfaces;
using DSCC_13540_API.Models;

namespace DSCC_13540_API.Repositories
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(LibraryContext context) : base(context)
        {
        }
    }
}
