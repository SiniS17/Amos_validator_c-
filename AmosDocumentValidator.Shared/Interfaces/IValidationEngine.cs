namespace AmosDocumentValidator.Shared.Interfaces;

public interface IValidationEngine
{
    ValidationResult Validate(string text, string? seqValue = null, string? headerText = null, string? desText = null);
}
