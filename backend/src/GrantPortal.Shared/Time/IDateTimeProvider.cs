namespace GrantPortal.Shared.Time;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}
