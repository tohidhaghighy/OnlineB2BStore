namespace OnlineB2BStoreBackend.Endpoints.User.Dtos
{
    public class GetUserResponse
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Pass { get; set; }
        public string Address { get; set; }
        public int City { get; set; }
        public int Country { get; set; }
        public DateTime CreatedDate { get; set; }
        public int RoleID { get; set; }
        public int TypeID { get; set; }
        public string ImageUrl { get; set; }
    }
}
