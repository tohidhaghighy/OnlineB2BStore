using OnlineB2BStoreBackend.Domain.Base;

namespace OnlineB2BStoreBackend.Domain.Models
{
    public class MenuGroup
    {
        public int MenuGroupId { get; set; }
        public string MenuGroupNameEn { get; set; }
        public string MenuGroupNameFa { get; set; }
        public string MenuGroupCss { get; set; }
        public string MenuGroupIcon { get; set; }
        public int? MenuGroupParentId { get; set; }

    }
}
