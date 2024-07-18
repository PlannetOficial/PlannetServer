using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Categories
{
    internal interface ICategoryRespository
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImgUrl { get; set; }
    }
}
