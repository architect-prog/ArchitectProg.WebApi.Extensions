namespace ArchitectProg.WebApi.Extensions.Responses;

public class CollectionWrapper<T>(IEnumerable<T> items, int totalCount)
{
    public IEnumerable<T> Items { get; } = items;
    public int TotalCount { get; } = totalCount;
}