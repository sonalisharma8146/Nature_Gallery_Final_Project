using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nature_Gallery_Final_Project.Models
{
    //Upload record which keeps the time of upload , publisher and the image information
    public class UploadRecord
    {
        public int Id { get; set; }

        public int ImageId { get; set; }

        public int PublisherId { get; set; }

        public Image Image { get; set; }

        public Publisher Publisher { get; set; }


        public DateTime UploadTime { get; set; }


    }
}
