using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MovieRentApp.Models;

namespace MovieRentApp.ViewModels
{
    public class MovieFormViewModel
    {
        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }

        public int? Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Release date")]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Number in stock")]
        [Range(0, 20)]
        [Required]
        public byte? NumberInStock { get; set; }
        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }
        public IEnumerable<Genre> Genres { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }
    }
}