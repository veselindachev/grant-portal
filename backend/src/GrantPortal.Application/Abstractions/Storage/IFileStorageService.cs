namespace GrantPortal.Application.Abstractions.Storage;

public interface IFileStorageService
{
    Task<string> UploadAsync(Stream fileStream, string fileName, CancellationToken cancellationToken = default);
    Task<Stream> DownloadAsync(string path, CancellationToken cancellationToken = default);
}
