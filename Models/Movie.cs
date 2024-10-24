﻿using eMovieTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eMovieTickets.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        // Relationships
        public List<Actor_Movie> Actor_Movies { get; set; }

        // Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema cinema { get; set; }

        // Producer (Fix casing of "ProducerId")
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")] // Change "ProducerID" to "ProducerId"
        public Producer producer { get; set; }
    }
}
