using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace demo1.Models
{
    public class Brand
    {
        [Key] public int ID { get; set; }
        public long BrandID { get; set; }
        public string BrandName { get; set; }
    }
}