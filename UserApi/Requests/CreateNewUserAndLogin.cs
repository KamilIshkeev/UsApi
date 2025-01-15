namespace UserApi.Requests
{
    public class CreateNewUserAndLogin
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
