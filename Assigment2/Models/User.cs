﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assigment2.Models
{
    public class User : IdentityUser
    {
        public string IdentityNumber { get; set; }
        public string Status { get; set; }
    }
}