namespace PersonalSiteMVC.Models
{
    public class CredentialSettings
    {
        public Email Email { get; set; } = null!;
    }

    public class Email
    {
        public string Server { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Recipient { get; set; } = null!;
    }
}
