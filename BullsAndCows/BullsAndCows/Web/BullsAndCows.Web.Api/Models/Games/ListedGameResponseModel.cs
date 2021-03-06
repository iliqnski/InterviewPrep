﻿namespace BullsAndCows.Web.Api.Models.Games
{
    using Data.Models;
    using Infrastructure.Mappings;
    using System;
    using AutoMapper;

    public class ListedGameResponseModel
        : IMapFrom<Game>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Blue { get; set; }

        public string Red { get; set; }

        public string GameState { get; set; }

        public DateTime DateCreated { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<Game, ListedGameResponseModel>()
                .ForMember(g => g.Blue, opts => opts.MapFrom(g => g.BlueUser == null ? "" : g.BlueUser.Email))
                .ForMember(g => g.Red, opts => opts.MapFrom(g => g.RedUser.Email))
                .ForMember(g => g.GameState, opts => opts.MapFrom(g => g.GameState.ToString()));
        }
    }
}