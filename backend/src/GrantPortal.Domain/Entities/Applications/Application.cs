using GrantPortal.Domain.Entities.Attachments;
using GrantPortal.Domain.Entities.Users;
using GrantPortal.Domain.Enums;

namespace GrantPortal.Domain.Entities.Applications;

public class Application
{
    public Guid Id { get; set; }
    public Guid GrantProgramId { get; set; }
    public Guid ApplicantId { get; set; }
    public ApplicationStatus Status { get; set; }
    public List<ApplicationAnswer> Answers { get; set; } = new();
    public List<ApplicationAttachment> Attachments { get; set; } = new();
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
