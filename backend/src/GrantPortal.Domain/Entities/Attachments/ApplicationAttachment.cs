namespace GrantPortal.Domain.Entities.Attachments;

public class ApplicationAttachment
{
    public Guid Id { get; set; }
    public Guid ApplicationId { get; set; }
    public string FileName { get; set; } = string.Empty;
    public string ContentType { get; set; } = string.Empty;
    public long Size { get; set; }
    public string StoragePath { get; set; } = string.Empty;
    public string? FieldId { get; set; }
}
