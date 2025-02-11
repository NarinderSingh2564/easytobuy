﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyToBuy.Models.UIModels
{
    public class ProductRatingUIModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public List<IFormFile>? ProductRatingImage { get; set; }
        public int Rating { get; set; }
        public string ReviewTitle { get; set; }
        public string? ReviewDescription { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
