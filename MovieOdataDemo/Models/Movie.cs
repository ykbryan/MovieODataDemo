using System;
using System.ComponentModel.DataAnnotations;

namespace MovieOdataDemo.Models
{
    public class Movie
    {
        public Movie()
        {
            Name = "Movie name is empty";
            Description = "";
            Rating = 0.0;
        }

        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Movie name cannot exceed 50 characters.")]
        public String Name { get; set; }

        public String? Description { get; set; }

        public Double? Rating { get; set; }

    }
}

