namespace OnlineB2BStoreBackend.Endpoints.GroupMenu.Dtos
{
    public class GroupMenuResponse
    {
        public int Id { get; set; }
        public string NameFa { get; set; }
        public string NameEn { get; set; }
        public string Slug { get; set; }
        public int Level { get; set; }
        public int? Parent { get; set; }
    }
}
