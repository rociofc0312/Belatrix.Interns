namespace Belatrix.Repository.SqlServer
{
    public class UnitofWork: IUnitofWork
    {
        public IGenreRepository Genres { get; }

        public UnitofWork(chinookContext dbContext)
        {
            Genres = new GenreRepository(dbContext);
        }
    }
}
