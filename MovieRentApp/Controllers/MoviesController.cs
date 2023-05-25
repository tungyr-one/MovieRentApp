using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Razor;
using MovieRentApp.Models;
using MovieRentApp.ViewModels;

namespace MovieRentApp.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Matrix" };

            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            
            return View(viewModel); 
            //return View(movie);
            //return Content("Hello Victor!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult New()
        {
            List<Genre> genres = _context.Genres.ToList();

            var viewModel = new MovieFormViewModel()
            {
                Genres = genres
            };

            return View("MovieForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel(movie)
                {
                    Genres = _context.Genres.ToList()
                };

                return View("MovieForm", viewModel);
            }


            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.ReleaseDate= movie.ReleaseDate;
                movieInDb.NumberInStock = movie.NumberInStock;
            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }

        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            var viewModel = new MovieFormViewModel(movie)
            {
                Genres = _context.Genres.ToList()
            };
            
            return View("MovieForm", viewModel);
        }

        // movies
        public ViewResult Index()
        {
            if (User.IsInRole(RoleName.CanManageMovies))
            return View("List");

            return View("ReadOnlyList");
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.
                Include(m => m.Genre).
                SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }
        
        public ActionResult Example(int? number)
        {
            return Content($"This is an example {number}");
        }

        [Route("movies/released/{year}/{month:regex(d{4}):range(1, 12)}")]
        //[Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}