﻿using System.ComponentModel.DataAnnotations;

namespace MyPageRazor2019_1.Models {
    public class Movie {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DataType ReleaseDate { get; set; }

        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}