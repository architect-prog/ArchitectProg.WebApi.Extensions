namespace ArchitectProg.WebApi.Extensions.Responses;

public class ErrorResult
{
    public int StatusCode { get; }
    public string? Error { get; }

    public ErrorResult(int statusCode, string? error)
    {
        Error = error;
        StatusCode = statusCode;
    }
}