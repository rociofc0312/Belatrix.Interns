using System.Linq;
using Belatrix.Models;

namespace Belatrix.Repository.SqlServer
{
    public class GenreRepository: Repository<Genre>, IGenreRepository
    {
        public GenreRepository(chinookContext dbContext) : base(dbContext)
        {
        }

        public Genre GetById(int id)
        {
            return _dbContext.Genre.FirstOrDefault(x => x.GenreId == id);
        }
    }
}
