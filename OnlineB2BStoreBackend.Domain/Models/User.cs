namespace OnlineB2BStoreBackend.Domain.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public string UserPass { get; set; }
        public string UserAddress { get; set; }
        public int UserCity { get; set; }
        public int UserCountry { get; set; }
        public DateTime UserCreatedDate { get; set; }
        public int UserRoleID { get; set; }
        public int UserTypeID { get; set; }
        public string UserImageUrl { get; set; }
    }
}
