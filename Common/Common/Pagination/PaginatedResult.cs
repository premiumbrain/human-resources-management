namespace Common.Pagination
{
    public class PaginatedResult<TEntiy>(int pageIndex, int pageSize, long count, IEnumerable<TEntiy> data)
        where TEntiy : class
    {
        public int PageIndex { get; } = pageIndex;
        public int PageSize { get; } = pageSize;
        public long Count { get; } = count;
        public IEnumerable<TEntiy> Data { get; } = data;
    }
}
