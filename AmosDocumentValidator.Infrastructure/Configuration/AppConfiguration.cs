namespace AmosDocumentValidator.Infrastructure.Configuration;

public class AppConfiguration
{
    public string Version { get; set; } = "Beta v1.0";
    public string LastUpdate { get; set; } = "31 DEC 25";
    
    public PathConfiguration Paths { get; set; } = new();
    public ValidationConfiguration Validation { get; set; } = new();
    public ActionStepConfiguration ActionStep { get; set; } = new();
}

public class PathConfiguration
{
    public string BaseDirectory { get; set; } = GetBaseDirectory();
    public string DataFolder { get; set; } = "DATA";
    public string InputFolder { get; set; } = "INPUT";
    public string LogFolder { get; set; } = "log";
    public string CredentialsFile { get; set; } = "bin/link.txt";
    
    private static string GetBaseDirectory()
    {
        if (IsRunningFromExecutable())
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }
        return Directory.GetCurrentDirectory();
    }
    
    private static bool IsRunningFromExecutable()
    {
        return !string.IsNullOrEmpty(AppDomain.CurrentDomain.FriendlyName) 
               && AppDomain.CurrentDomain.FriendlyName.EndsWith(".exe");
    }
}

public class ValidationConfiguration
{
    public List<string> SeqAutoValidPatterns { get; set; } = new() { "1.", "2.", "3.", "10." };
    public string InvalidCharactersPattern { get; set; } = @"[\\/*?:""<>|]";
}

public class ActionStepConfiguration
{
    public bool EnabledByDefault { get; set; } = true;
    public string SheetName { get; set; } = "ActionStepControl";
    public bool SummaryEnabledByDefault { get; set; } = true;
    public string SummarySheetName { get; set; } = "ASC_Summary";
}
