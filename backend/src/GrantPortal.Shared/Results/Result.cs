namespace GrantPortal.Shared.Results;

public class Result<T>
{
    public bool IsSuccess { get; }
    public string? ErrorCode { get; }
    public T? Value { get; }

    private Result(bool isSuccess, T? value, string? errorCode)
    {
        IsSuccess = isSuccess;
        Value = value;
        ErrorCode = errorCode;
    }

    public static Result<T> Success(T value) => new(true, value, null);

    public static Result<T> Failure(string errorCode) => new(false, default, errorCode);
}
