﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Entities
{
    public class WebsuperUser : IdentityUser
    {
        public string FullName { get; set; }
        public string Adress { get; set; }
    }
}
