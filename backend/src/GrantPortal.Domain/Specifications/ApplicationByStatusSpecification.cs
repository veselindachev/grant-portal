using GrantPortal.Domain.Entities.Applications;
using GrantPortal.Domain.Enums;

namespace GrantPortal.Domain.Specifications;

public class ApplicationByStatusSpecification
{
    public ApplicationStatus Status { get; }

    public ApplicationByStatusSpecification(ApplicationStatus status)
    {
        Status = status;
    }

    public bool IsSatisfiedBy(Application application) => application.Status == Status;
}
