using ArchitectProg.WebApi.Extensions.Responses;

namespace ArchitectProg.WebApi.Extensions.Extensions;

public static class ResponseWrappersExtensions
{
    public static CollectionWrapper<T> WrapCollection<T>(this IEnumerable<T> source, int totalCount)
    {
        ArgumentNullException.ThrowIfNull(source);

        var result = new CollectionWrapper<T>(source, totalCount);
        return result;
    }
}