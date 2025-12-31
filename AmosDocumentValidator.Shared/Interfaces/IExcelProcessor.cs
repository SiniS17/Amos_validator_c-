namespace AmosDocumentValidator.Shared.Interfaces;

public interface IExcelProcessor
{
    Task<ProcessingResult> ProcessFileAsync(
        string filePath, 
        ProcessingOptions options, 
        CancellationToken cancellationToken = default);
}
