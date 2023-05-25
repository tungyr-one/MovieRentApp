using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using AutoMapper;
using MovieRentApp.Dtos;
using MovieRentApp.Models;

namespace MovieRentApp.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [System.Web.Http.HttpPost]
        // GET: Rentals
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);
            //var customer = _context.Customers.Where(c => c.Id == newRental.CustomerId);

            var movies = _context.Movies.Where(
                m => newRental.MovieIds.Contains(m.Id)).ToList();

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                {
                    return BadRequest($"Movie {movie.Name} is not available.");
                }

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Today,
                };
                
                _context.Rentals.Add(rental);
            }
            
            _context.SaveChanges();

            return Ok();
        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult GetNewRentals()
        {
            //var rentalDtos = _context.Rentals.Include("customer").Include("movie").ToList().Select(Mapper.Map<Rental,NewRentalDto>);
            var rentalDtos = _context.Rentals.Include("customer").Include("movie").ToList();

            return Ok(rentalDtos);
        }
    }
}