﻿namespace WeNeed1.Model.Payloads
{
    public class UserUpdateDto
    {
        
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }
        
        public string? PhoneNumber { get; set; }
        
        public byte[]? ProfilePicture { get; set; }
        
    }
}
