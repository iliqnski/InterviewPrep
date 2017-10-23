namespace BullsAndCows.Web.Api.Controllers
{
    using Services.Data;
    using System.Web.Http;
    using AutoMapper.QueryableExtensions;
    using Models.Games;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using AutoMapper;
    using System.Net.Http;

    public class GamesController : ApiController
    {
        private IGamesService gamesService;

        public GamesController(IGamesService gamesService)
        {
            this.gamesService = gamesService;
        }

        public IHttpActionResult Get(int page = 1)
        {
            var userId = this.User.Identity.GetUserId();
            var games = this.gamesService
                .GetPulbicGames(page, userId)
                .ProjectTo<ListedGameResponseModel>()
                .ToList();

            return Ok(games);
        }

        [Authorize]
        public IHttpActionResult Post(CreateGameRequestModel model)
        {
            if (model == null || !this.ModelState.IsValid)
            {
                if(model == null)
                {
                    return this.BadRequest("Game can not be empty!");
                }

                return this.BadRequest(this.ModelState);
            }

            var newGame = this.gamesService.CreateGame(
                model.Name, 
                model.Number, 
                this.User.Identity.GetUserId());

            var gameResult = gamesService
                .GetGameDetails(newGame.Id)
                .ProjectTo<ListedGameResponseModel>()
                .FirstOrDefault();

            return this.Created(string.Format("/api/Games/{0}", newGame.Id), gameResult);
        }
    }
}