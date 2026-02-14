using CinemaApp.Modules.Core.Base;
using CinemaApp.Modules.Films.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CinemaApp.Modules.Films.Models
{
    internal class Movie : EntityBase
    {
        //public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Duration { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public Genres Genre { get; set; }
        [Required]
        public string PosterUrl { get; set; }
        public bool IsActive { get; set; }
        //public DateTime CreatedAt { get; set; }
        //public DateTime? UpdatedAt { get; set; }

    }
}
