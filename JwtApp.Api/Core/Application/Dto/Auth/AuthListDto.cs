namespace JwtApp.Api.Core.Application.Dto.Auth
{
    public class AuthListDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int Password { get; set; }
        public int AppRoleId { get; set; }
    }
}
