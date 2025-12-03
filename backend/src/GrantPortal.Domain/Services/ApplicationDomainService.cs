using GrantPortal.Domain.Entities.Applications;
using GrantPortal.Domain.Enums;

namespace GrantPortal.Domain.Services;

public class ApplicationDomainService
{
    public bool CanSubmit(Application application)
    {
        return application.Status == ApplicationStatus.Draft;
    }
}
