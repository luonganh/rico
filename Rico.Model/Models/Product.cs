﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rico.Model.Models
{
    [Table("Products")]
    public class Product
    {
        public int ID { get; set; }

        public string Name { get; set; }


    }
}