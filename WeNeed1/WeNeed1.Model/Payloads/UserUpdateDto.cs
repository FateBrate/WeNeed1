namespace WeNeed1.Model.Payloads
{
    public class UserUpdateDto
    {
        public string? PhoneNumber { get; set; }
        
        public string? Email { get; set; }
        
        public string? UserName { get; set; }
        
        public byte[]? ProfilePicture { get; set; }
        
    }
}
