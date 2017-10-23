﻿namespace BullsAndCows.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Game
    {
        private ICollection<Guess> guesses;

        public Game()
        {
            this.guesses = new HashSet<Guess>();
        }

        public virtual ICollection<Guess> Guesses
        {
            get
            {
                return this.guesses;
            }
            set
            {
                this.guesses = value;
            }
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public DateTime DateCreated { get; set; }

        public GameState GameState { get; set; }

        public GameResult GameResult { get; set; }

        public string RedUserId { get; set; }

        public virtual User RedUser { get; set; }

        public string BlueUserId { get; set; }

        public virtual User BlueUser { get; set; }

        public string RedUserNumber { get; set; }

        public string BlueUserNumber { get; set; }
    }
}
