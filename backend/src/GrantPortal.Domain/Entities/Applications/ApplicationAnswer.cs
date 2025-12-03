namespace GrantPortal.Domain.Entities.Applications;

public class ApplicationAnswer
{
    public Guid Id { get; set; }
    public Guid ApplicationId { get; set; }
    public string FieldId { get; set; } = string.Empty;
    public string? Value { get; set; }
}
