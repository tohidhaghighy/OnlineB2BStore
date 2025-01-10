namespace OnlineB2BStoreBackend.Endpoints.GroupMenu.Dtos
{
    public class InsertMenuGroupRequest
    {
        public string NameFa { get; set; }
        public string NameEn { get; set; }
        public string IconAddress { get; set; }
        public string CssAddress { get; set; }
        public int? ParentId { get; set; }
    }
}
