namespace AmosDocumentValidator.Shared.Interfaces;

public interface IProcessingPipeline
{
    Task<IReadOnlyList<ProcessingResult>> ProcessFilesAsync(
        IEnumerable<FileInfo> files,
        ProcessingOptions options,
        IProgress<ProcessingProgress>? progress = null,
        CancellationToken cancellationToken = default);
}
