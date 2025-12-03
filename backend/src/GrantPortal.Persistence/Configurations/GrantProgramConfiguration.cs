using GrantPortal.Domain.Entities.Grants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GrantPortal.Persistence.Configurations;

public class GrantProgramConfiguration : IEntityTypeConfiguration<GrantProgram>
{
    public void Configure(EntityTypeBuilder<GrantProgram> builder)
    {
        // TODO: Configure keys, constraints, and owned types for form definitions.
        builder.HasKey(x => x.Id);
    }
}
