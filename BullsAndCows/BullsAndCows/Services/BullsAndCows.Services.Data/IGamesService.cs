namespace BullsAndCows.Services.Data
{
    using BullsAndCows.Data.Models;
    using System.Linq;

    public interface IGamesService
    {
        IQueryable<Game> GetPulbicGames(int page = 1);
    }
}
