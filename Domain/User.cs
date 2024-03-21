namespace SunOut_ERP_Backend.Domain
{
    public class User()
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public int Type { get; set; }
    }
}
