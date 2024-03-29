﻿using ParthsBooks.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace ParthsBooks.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [Range(1, 10000)]
        public double ListPrice { get; set; }
        public string price => ListPrice.ToString();
        public string ImageUrl { get; set; }
        [Required]
        public int CategoryId { get; set; } // foreign key reference
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        [Required]
        public int CoverTypeId { get; set; } // foreign key reference
        [ForeignKey("CoverTypeId")]
        public CoverType CoverType { get; set; }
        
    }
}