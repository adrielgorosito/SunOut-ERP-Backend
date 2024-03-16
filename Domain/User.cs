namespace SunOut_ERP_Backend.Domain
{
    public class User(string u, string p, int t)
    {
        public string username { get; set; } = u;
        public string password { get; set; } = p;
        public int type { get; set; } = t;
    }
}
