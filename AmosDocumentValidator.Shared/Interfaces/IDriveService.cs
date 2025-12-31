namespace AmosDocumentValidator.Shared.Interfaces;

public interface IDriveService
{
    Task<IReadOnlyList<DriveFileInfo>> ListExcelFilesAsync(string folderId);
    Task<string> DownloadFileAsync(string fileId, string destinationPath, IProgress<double>? progress = null);
}
