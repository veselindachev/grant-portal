using GrantPortal.Domain.ValueObjects;

namespace GrantPortal.Domain.Entities.Grants;

public class GrantProgram
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateRange ActivePeriod { get; set; } = new();
    public FormTemplate FormDefinition { get; set; } = new();
}
