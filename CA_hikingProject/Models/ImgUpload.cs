using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CA_hikingProject.Models
{
    public static class ImgUpload
    {
        public static bool CheckImageType(IFormFile Image)
        {
            return Image.ContentType == "image/jpg" || Image.ContentType == "image/jpeg" || Image.ContentType == "image/png" || Image.ContentType == "image/gif";

        }

        public static bool CheckImageSize(IFormFile Image, int mb)
        {
            return Image.Length / 1024 / 1024 < mb;
        }

        public static async Task<string> SaveImage(string folder, IFormFile Image)
        {
            string filename = Guid.NewGuid().ToString()+"_"+ Path.GetFileName(Image.FileName);

            string path = Path.Combine(folder, filename);

            using (var stream = new FileStream(path, FileMode.Create))

            {

                await Image.CopyToAsync(stream);

            }

           

            return filename;
        }

        public static bool DeleteImage(string folder, string filename)
        {
            string pathToImage = Path.Combine(folder, filename);

            if (File.Exists(pathToImage))
            {
                File.Delete(pathToImage);
                return true;
            }

            return false;
        }
    }
}
