﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using MovieRentApp.Models;

namespace MovieRentApp.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        //[StringLength(255)]
        public string Name { get; set; }
        //[Min18YearsIfAMember]
        public DateTime? Birthday { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public byte MembershipTypeId { get; set; }
        public MembershipTypeDto MembershipType { get; set; }
    }
}