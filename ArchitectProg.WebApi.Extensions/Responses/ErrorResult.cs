namespace ArchitectProg.WebApi.Extensions.Responses;

public class ErrorResult(int statusCode, string? error)
{
    public int StatusCode { get; } = statusCode;
    public string? Error { get; } = error;
}