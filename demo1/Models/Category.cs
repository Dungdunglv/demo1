﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace demo1.Models
{
    public class Category
    {
        public long CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}