namespace JwtApp.Api.Core.Application.Dto.Auth
{
    public class CheckUserResponseDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsExist { get; set; }
        public string Role { get; set; }
    }
}
