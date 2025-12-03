namespace GrantPortal.Contracts.Requests;

public record UploadAttachmentRequest(string FileName, string ContentType, string? FieldId);
