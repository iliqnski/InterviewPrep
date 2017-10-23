namespace BullsAndCows.Services.Data
{
    using BullsAndCows.Data.Models;
    using System.Linq;

    public interface IGamesService
    {
        IQueryable<Game> GetPulbicGames(int page = 1, string userId = null);
        Game CreateGame(string name, string number, string userId);

        IQueryable<Game> GetGameDetails(int id);
    }
}
