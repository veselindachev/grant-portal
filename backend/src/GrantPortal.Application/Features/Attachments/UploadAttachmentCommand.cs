using GrantPortal.Application.Abstractions.Messaging;
using GrantPortal.Application.DTOs.Attachments;

namespace GrantPortal.Application.Features.Attachments;

public record UploadAttachmentCommand(Guid ApplicationId, string FileName, Stream Content, string ContentType, string? FieldId) : ICommand<AttachmentDto>;
