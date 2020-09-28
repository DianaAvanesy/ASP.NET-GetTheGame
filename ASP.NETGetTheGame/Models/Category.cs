﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETGetTheGame.Models
{
    public class Category
    {
        public int Id { get; set;}

        //make required

        [Required]
        public string Name { get; set;}
    }
}