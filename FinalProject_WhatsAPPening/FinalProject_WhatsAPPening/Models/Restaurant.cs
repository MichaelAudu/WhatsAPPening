﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace FinalProject_WhatsAPPening.Models
{
    public class Restaurant
    {
        [DisplayName("Cuisine")]
        public List<string> CuisineTypes { get; set; }

        [DisplayName("Price Range")]
        public PriceRange PriceRange { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }

        [DisplayName("Street Address")]
        public string Address { get; set; }

        [DisplayName("Zip")]
        public int ZipCode { get; set; }      
    }

    public enum PriceRange
    {
        Cheap,
        Moderate,
        High,
        Expensive
    }
}