namespace AmosDocumentValidator.Shared.Interfaces;

public interface IFileSourceManager
{
    Task<IReadOnlyList<FileInfo>> GetLocalFilesAsync(string folderPath);
    Task<IReadOnlyList<FileInfo>> GetDriveFilesAsync(string apiKey, string folderId);
}
