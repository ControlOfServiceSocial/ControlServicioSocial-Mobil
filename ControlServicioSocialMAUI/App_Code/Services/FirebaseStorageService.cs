using Firebase.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ControlServicioSocialMAUI.App_Code.Services
{
    public class FirebaseStorageService
    {
        private static FirebaseStorage storage;

        static FirebaseStorageService()
        {
            //var bucket = "controlserviciosocial-a46d2.appspot.com";
            var bucket = "controlserviciosocial-6759e.appspot.com";
            var auth = ""; // Deja esto en blanco si tu storage está configurado con reglas públicas
            storage = new FirebaseStorage(bucket, new FirebaseStorageOptions
            {
                AuthTokenAsyncFactory = () => Task.FromResult(auth)
            });
        }

        public static async Task<string> UploadFile(Stream stream, string fileName)
        {
            var fileUrl = await storage
                .Child("certificados") // Reemplaza con la carpeta deseada
                .Child(fileName)
                .PutAsync(stream);

            return fileUrl;
        }
        public static async Task<ImageSource> LoadImages(string filename)
        {
            var webClient = new WebClient();
            var url = await storage
                .Child("imagenes") // Reemplaza con la carpeta deseada
                .Child(filename)
                .GetDownloadUrlAsync();

            var imageBytes = webClient.DownloadData(url);
            return ImageSource.FromStream(() => new MemoryStream(imageBytes));
        }
        public static async Task<string> GetImageDownloadUrlAsync(string fileName)
        {
            try
            {
                var fileReference = storage
                    .Child("imagenes") // Reemplaza con la carpeta deseada
                    .Child(fileName);

                var downloadUrl = await fileReference.GetDownloadUrlAsync();
                return downloadUrl;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener la URL de la imagen: {ex.Message}");
                return null;
            }
        }
        public static async Task<FileResultt> GetImage(string imageName)
        {
            try
            {
                var imageUrl = await storage
                    .Child("imagenes")
                    .Child(imageName)
                    .GetDownloadUrlAsync();

                Console.WriteLine(string.Format("URL de la imagen: {0}", imageUrl));

                return new FileResultt { FileUrl = imageUrl };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new FileResultt { Error = ex.ToString() };
            }
        }
    }
    public class FileResultt
    {
        public string FileUrl { get; set; }
        public string Error { get; set; }
    } 
}
