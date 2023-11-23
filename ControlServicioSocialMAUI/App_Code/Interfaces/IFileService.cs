namespace MAUIControlServicioSocial.App_Code.Interfaces
{
    public interface IFileService
    {
        Task SaveFileAsync(string filename, Stream fileStream);
        Task<Stream> GetFileAsync(string filename);
    }
}
