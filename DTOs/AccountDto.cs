namespace YalabenaApi.DTOs
{
    public class AccountDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class AccountLoginDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

}
