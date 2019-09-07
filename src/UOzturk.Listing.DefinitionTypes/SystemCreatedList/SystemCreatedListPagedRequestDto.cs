namespace UOzturk.Listing.DefinitionTypes.SystemCreatedList
{
    public class SystemCreatedListPagedRequestDto : PagedResultRequest
    {
        public string Name { get; set; }

        public int? ListTypeId { get; set; }
    }
}