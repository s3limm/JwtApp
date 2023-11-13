using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtApp.Domaim.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int Password { get; set; }
        public int AppRoleId { get; set; }

        //Relational Properties
        public AppRole? AppRole { get; set; }
    }
}
