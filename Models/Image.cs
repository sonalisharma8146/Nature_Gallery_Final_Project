using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nature_Gallery_Final_Project.Models
{
    //Represents an uploaded image with a heading description and an image url
    public class Image
    {
        public int Id { get; set; }

        public string Heading { get; set; }

        public string Description { get; set; }

        [NotMapped]
        public IFormFile File { get; set; }

        public string ImageUrl { get; set; }



    }
}
