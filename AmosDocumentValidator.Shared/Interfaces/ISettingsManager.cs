namespace AmosDocumentValidator.Shared.Interfaces;

public interface ISettingsManager
{
    T GetSetting<T>(string key, T defaultValue);
    void SetSetting<T>(string key, T value);
    void Save();
    void Load();
    void ResetToDefaults();
}
