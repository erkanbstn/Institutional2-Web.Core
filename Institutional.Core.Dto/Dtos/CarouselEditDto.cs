﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institutional.Core.Dto.Dtos
{
    public class CarouselEditDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public IFormFile Picture { get; set; }
        public string ImageUrl { get; set; }
    }
}
