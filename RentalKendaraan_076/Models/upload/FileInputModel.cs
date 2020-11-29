using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalKendaraan_076.Models.upload
{
    public class FileInputModel
    {
        public IFormFile FileToUpload { get; set; }
    }
}
