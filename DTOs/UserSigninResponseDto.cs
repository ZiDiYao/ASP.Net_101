namespace WebApplicationC__Tut101.DTOs.Responses
{
    public class UserSigninResponseDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        // 之后你要教前端拿着这个 Token 来访问其他接口
        public string Token { get; set; }
    }
}