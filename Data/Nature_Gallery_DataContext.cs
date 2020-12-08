using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nature_Gallery_Final_Project.Models;

namespace Nature_Gallery_Final_Project.Models
{
    //Connects the database 
    public class Nature_Gallery_DataContext : DbContext
    {
        public Nature_Gallery_DataContext (DbContextOptions<Nature_Gallery_DataContext> options)
            : base(options)
        {
        }

        public DbSet<Nature_Gallery_Final_Project.Models.Image> Image { get; set; }

        public DbSet<Nature_Gallery_Final_Project.Models.Publisher> Publisher { get; set; }

        public DbSet<Nature_Gallery_Final_Project.Models.UploadRecord> UploadRecord { get; set; }
    }
}
