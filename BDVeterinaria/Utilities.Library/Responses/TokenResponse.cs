namespace Utilities.Library.Responses
{
    public class TokenResponse
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
        public UserResponse userResponse { get; set; }
        public DateTime ExpirationLocal => Expiration.ToLocalTime();
    }
}
