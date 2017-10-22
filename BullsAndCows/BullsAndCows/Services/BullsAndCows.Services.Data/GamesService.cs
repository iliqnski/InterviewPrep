namespace BullsAndCows.Services.Data
{
    using System;
    using System.Linq;
    using BullsAndCows.Data.Models;
    using BullsAndCows.Data.Repositories;

    public class GamesService : IGamesService
    {
        private IRepository<Game> gamesRepo;

        public GamesService(IRepository<Game> gamesRepo)
        {
            this.gamesRepo = gamesRepo;
        }

        public IQueryable<Game> GetPulbicGames(int page = 1)
        {
            return this.gamesRepo
                        .All()
                        .Where(g => g.GameState == GameState.WaitingForOpponents)
                        .OrderBy(g => g.GameState)
                        .ThenBy(g => g.Name)
                        .ThenBy(g => g.DateCreated)
                        .ThenBy(g => g.RedUser.Email)
                        .Skip((page - 1) * 10)
                        .Take(10);
        }
    }
}
