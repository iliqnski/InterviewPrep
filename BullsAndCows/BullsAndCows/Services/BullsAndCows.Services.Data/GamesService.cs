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

        public Game CreateGame(string name, string number, string userId)
        {
            var newGame = new Game
            {
                Name = name,
                GameState = GameState.WaitingForOpponents,
                RedUserId = userId,
                DateCreated = DateTime.UtcNow,
                RedUserNumber = null,
            };

            this.gamesRepo.Add(newGame);
            this.gamesRepo.SaveChanges();

            return newGame;
        }

        public IQueryable<Game> GetPulbicGames(int page = 1, string userId = null)
        {
            return this.gamesRepo
                        .All()
                        .Where(g => g.GameState == GameState.WaitingForOpponents
                            || (g.GameState != GameState.WaitingForOpponents
                            && (g.RedUserId == userId || g.BlueUserId == userId)))
                        .OrderBy(g => g.GameState)
                        .ThenBy(g => g.Name)
                        .ThenBy(g => g.DateCreated)
                        .ThenBy(g => g.RedUser.Email)
                        .Skip((page - 1) * 10)
                        .Take(10);
        }

        public IQueryable<Game> GetGameDetails(int id)
        {
            return this.gamesRepo
                .All()
                .Where(g => g.Id == id);
        }
    }
}
