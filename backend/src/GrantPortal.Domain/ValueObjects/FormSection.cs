namespace GrantPortal.Domain.ValueObjects;

public class FormSection
{
    public string Title { get; set; } = string.Empty;
    public List<FormFieldDefinition> Fields { get; set; } = new();
}
