﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using Microsoft.Owin.Security.DataHandler;
using MovieRentApp.Models;

namespace MovieRentApp.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers{ get; set; } 
        
    }
}