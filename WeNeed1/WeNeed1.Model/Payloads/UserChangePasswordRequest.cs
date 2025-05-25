namespace WeNeed1.Model.Payloads;

public class UserChangePasswordRequest
{
    public int Id { get; set; }
    public string Password { get; set; } = null!;
    public string NewPassword { get; set; } = null!;
}