namespace SourceControlSystem.Api.Controllers
{
    using Common.Constants;
    using Data;
    using Models.Projects;
    using Services.Data;
    using SourceControlSystem.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public class ProjectsController : ApiController
    {
        private readonly IProjectsService projects;

        public ProjectsController(IProjectsService projects)
        {
            this.projects = projects;
        }

        public IHttpActionResult Get()
        {
            var result = this.projects
                .All(1)
                .Select(SoftwareProjectDetailsModel.FromModel);

            return this.Ok(result);
        }

        [Authorize]
        public IHttpActionResult Get(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return this.BadRequest("Id can not be null or empty");
            }

            var result = this.projects
                .All()
                .Where(p => 
                    p.Name == id &&
                    !p.Private || 
                    (p.Private && (p.Users.Any(c => c.UserName == this.User.Identity.Name))))
                .Select(SoftwareProjectDetailsModel.FromModel)
                .FirstOrDefault();

            if (result == null)
            {
                return this.NotFound();
            }

            return this.Ok(result);
        }

        [Route("api/projects/all")]
        public IHttpActionResult Get(int page, int pageSize = GlobalConstants.DefaultPageSize)
        {
            var result = this.projects
                .All(page, pageSize)
                .Select(SoftwareProjectDetailsModel.FromModel);

            return this.Ok(result);
        }

        [Authorize]
        public IHttpActionResult Post(SaveProjectRequestModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var createdProjectId = this.projects.Add
                (model.Name, model.Description, this.User.Identity.Name, model.Private);
            return this.Ok(createdProjectId);
        }
    }
}
