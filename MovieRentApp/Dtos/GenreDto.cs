﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRentApp.Dtos
{
    public class GenreDto
    {
        public byte Id { get; set; }
        public string Name { get; set; }
    }
}