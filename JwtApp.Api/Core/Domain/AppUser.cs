namespace JwtApp.Api.Core.Domain
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int Password { get; set; }
        public int AppRoleId { get; set; }

        //Relational Properties
        public AppRole AppRole { get; set; }
        
        public AppUser()
        {
            AppRole = new AppRole();
        }

    }
}
