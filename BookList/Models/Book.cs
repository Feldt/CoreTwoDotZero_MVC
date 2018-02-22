﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookList.Models
{
    public class Book
    {
        public Int32 Id { get; set; }

        [Required]
        public String Name { get; set; }
    }
}