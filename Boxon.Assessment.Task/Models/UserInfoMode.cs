namespace Boxon.Assessment.Task.Models
{
    public class UserRecord
    {
        public List<UserInfoMode> UserInfoMode { get; set; }
    }
    public class UserInfoMode
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Language { get; set; }
        public string ArticalId { get; set; }
    }
}
