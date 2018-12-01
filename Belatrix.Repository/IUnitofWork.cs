namespace Belatrix.Repository
{
    public interface IUnitofWork
    {
        IGenreRepository Genres { get; }
    }
}
