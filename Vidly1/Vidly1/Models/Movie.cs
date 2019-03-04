using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Display(Name ="Genere")]
        public byte GenereId { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name="Release Date")] 
        [Required]
        public DateTime ReleaseDate { get; set; }

        [Display(Name ="Number In Stock")]
        [Range(1,20)]
        public byte NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }

        public Genre Genere { get; set; }
    }
}