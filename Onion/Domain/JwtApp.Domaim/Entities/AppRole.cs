﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtApp.Domaim.Entities
{
    public class AppRole
    {
        public int Id { get; set; }
        public string? Definition { get; set; }
        public List<AppUser>? AppUsers { get; set; }
    }
}
