namespace OnlineB2BStoreBackend.Endpoints.GroupMenu.Dtos
{
    public class UpdateMenuGroupRequest
    {
        public int Id { get; set; }
        public string NameFa { get; set; }
        public string NameEn { get; set; }
        public string IconAddress { get; set; }
        public string CssAddress { get; set; }
    }
}
