using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using UOzturk.Listing.List;

namespace UOzturk.Listing.SystemCreatedList.Dto
{
    [AutoMapFrom(typeof(SystemCreatedListEntity))]
    public class SystemCreatedListDto : EntityDto
    {
        public string Name { get; set; }

        //Bunu silebilirsin, sadece debug için koyuyorum.
        public int ListTypeId { get; set; }

        public ListTypeEntity ListType { get; set; }
    }
}