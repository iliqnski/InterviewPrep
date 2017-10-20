﻿namespace SourceControlSystem.Api.Models.Projects
{
    using SourceControlSystem.Models;
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    public class SoftwareProjectDetailsModel
    {
        public static Expression<Func<SoftwareProject, SoftwareProjectDetailsModel>> FromModel
        {
            get
            {
                return p => new SoftwareProjectDetailsModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    CreatedOn = p.CreatedOn,
                    TotalUsers = p.Users.Count()
                };
            }
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreatedOn { get; set; }

        public int TotalUsers { get; set; }
    }
}