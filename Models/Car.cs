using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Brand { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
    }
}