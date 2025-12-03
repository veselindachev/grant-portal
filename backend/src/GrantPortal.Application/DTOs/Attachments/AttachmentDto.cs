namespace GrantPortal.Application.DTOs.Attachments;

public record AttachmentDto(Guid Id, string FileName, string ContentType, long Size, string? FieldId);
