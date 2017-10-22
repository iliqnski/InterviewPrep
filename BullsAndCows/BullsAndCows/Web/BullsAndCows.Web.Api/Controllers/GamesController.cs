namespace BullsAndCows.Web.Api.Controllers
{
    using Services.Data;
    using System.Web.Http;
    using AutoMapper.QueryableExtensions;
    using Models.Games;
    using System.Linq;

    public class GamesController : ApiController
    {
        private IGamesService gamesService;

        public GamesController(IGamesService gamesService)
        {
            this.gamesService = gamesService;
        }

        public IHttpActionResult Get(int page = 1)
        {
            if (this.User.Identity.IsAuthenticated)
            {

            }

            var games = this.gamesService
                .GetPulbicGames(page)
                .ProjectTo<ListedGameResponseModel>()
                .ToList();

            return Ok(games);
        }
    }
}