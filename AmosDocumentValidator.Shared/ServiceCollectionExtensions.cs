namespace AmosDocumentValidator.Shared;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddAmosDocumentValidator(this IServiceCollection services)
    {
        // Register all core services
        services.AddValidationServices();
        services.AddInfrastructureServices();
        services.AddCoreServices();
        
        return services;
    }
    
    public static IServiceCollection AddValidationServices(this IServiceCollection services)
    {
        services.AddSingleton<IValidationEngine, ValidationEngine>();
        services.AddSingleton<IPatternMatcher, PatternMatcher>();
        services.AddSingleton<ITextNormalizer, TextNormalizer>();
        
        return services;
    }
    
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddSingleton<IExcelReader, ExcelReader>();
        services.AddSingleton<IExcelWriter, ExcelWriter>();
        services.AddSingleton<IDriveService, DriveService>();
        services.AddSingleton<ISettingsManager, SettingsManager>();
        services.AddSingleton<IFileSourceManager, FileSourceManager>();
        
        return services;
    }
    
    public static IServiceCollection AddCoreServices(this IServiceCollection services)
    {
        services.AddSingleton<IExcelProcessor, ExcelProcessor>();
        services.AddSingleton<IProcessingPipeline, ProcessingPipeline>();
        services.AddSingleton<ILogbookManager, LogbookManager>();
        
        return services;
    }
}
