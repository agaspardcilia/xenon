﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Xenon___Allianz.Models
{
    public class UserModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Type { get; set; } = 4;
        public string Mail { get; set; }
    }
}